using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public partial class UcPrestamo : UserControl
    {
        #region Eventos Personalizados
        public event EventHandler SolicitarIrMesas;
        public event EventHandler PrestamoFinalizado;
        #endregion

        #region Atributos
        private Laboratorista laboratorista;
        private Carrito carritoCompartido;
        private List<Material> inventarioCompartido;
        private GestorExcel gestorExcel = new GestorExcel();
        private string categoriaActual = "Multímetros";
        #endregion

        #region Constructores
        public UcPrestamo()
        {
            InitializeComponent();
        }

        public UcPrestamo(Laboratorista lab, Carrito carrito, List<Material> inventario)
        {
            InitializeComponent();
            laboratorista = lab;
            carritoCompartido = carrito;
            inventarioCompartido = inventario;

            CargarSpritesPixelArt();
            RefrescarCarritoVisual();
            MostrarSubVista(pnlSelectorCategorias);
        }
        #endregion

        #region Métodos
        private void CargarSpritesPixelArt()
        {
            string carpetaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes");
            AsignarImagenSiExiste(picMultimetros, Path.Combine(carpetaImagenes, "multimetros.jpeg"));
            AsignarImagenSiExiste(picResistencias, Path.Combine(carpetaImagenes, "resistencias.jpeg"));
            AsignarImagenSiExiste(picCapacitores, Path.Combine(carpetaImagenes, "capacitores.jpeg"));
            AsignarImagenSiExiste(picCables, Path.Combine(carpetaImagenes, "cables.jpeg"));
            AsignarImagenSiExiste(picProtoboard, Path.Combine(carpetaImagenes, "protoboard.jpeg"));
            AsignarImagenSiExiste(picPinzas, Path.Combine(carpetaImagenes, "pinzas.jpeg"));
            AsignarImagenSiExiste(picDecoracionOsciloscopio, Path.Combine(carpetaImagenes, "osciloscopio.jpeg"));
            AsignarImagenSiExiste(picLaboratoristaGuia, Path.Combine(carpetaImagenes, "laboratorista_guia.jpeg"));
        }

        private void AsignarImagenSiExiste(PictureBox pic, string ruta)
        {
            if (File.Exists(ruta))
            {
                pic.Image = Image.FromFile(ruta);
            }
        }

        private int ObtenerLimitePorCategoria(string categoria)
        {
            switch (categoria)
            {
                case "Multímetros": return 1;
                case "Resistencias": return 15;
                case "Capacitores": return 10;
                case "Cables": return 6;
                case "Protoboard": return 3;
                case "Pinzas": return 2;
                default: return 10;
            }
        }

        private int ContarPiezasEnCarritoPorCategoria(string categoria)
        {
            if (carritoCompartido == null) return 0;

            int suma = 0;
            for (int i = 0; i < carritoCompartido.Items.Count; i++)
            {
                if (carritoCompartido.Items[i].Producto.Categoria == categoria)
                {
                    suma += carritoCompartido.Items[i].Cantidad;
                }
            }
            return suma;
        }

        private void ActualizarBarraProgresoCategoria()
        {
            int maximo = ObtenerLimitePorCategoria(categoriaActual);
            int actual = ContarPiezasEnCarritoPorCategoria(categoriaActual);

            pbCupoCategoria.Maximum = maximo;
            pbCupoCategoria.Value = actual > maximo ? maximo : actual;

            lblCupoCategoria.Text = "Cupo " + categoriaActual + ": " + actual + " / " + maximo + (actual >= maximo ? " (LLENO)" : "");
            lblCupoCategoria.ForeColor = (actual >= maximo)
                ? Color.FromArgb(46, 204, 113)
                : Color.FromArgb(255, 210, 120);
        }

        private void MostrarSubVista(Panel vistaActiva)
        {
            pnlSelectorCategorias.Visible = (vistaActiva == pnlSelectorCategorias);
            pnlOperacionPrestamo.Visible = (vistaActiva == pnlOperacionPrestamo);
            pnlTicketFinal.Visible = (vistaActiva == pnlTicketFinal);
            vistaActiva.BringToFront();
        }

        public void ActualizarVistaDesdeExterior()
        {
            RefrescarCarritoVisual();
            FiltrarTabla(txtBuscarMaterial.Text);
        }

        private void AbrirCategoria(string categoria)
        {
            categoriaActual = categoria;
            lblNombreCategoriaActual.Text = categoria.ToUpper();

            if (categoria == "Multímetros") picIconoCategoriaActual.Image = picMultimetros.Image;
            else if (categoria == "Resistencias") picIconoCategoriaActual.Image = picResistencias.Image;
            else if (categoria == "Capacitores") picIconoCategoriaActual.Image = picCapacitores.Image;
            else if (categoria == "Cables") picIconoCategoriaActual.Image = picCables.Image;
            else if (categoria == "Protoboard") picIconoCategoriaActual.Image = picProtoboard.Image;
            else if (categoria == "Pinzas") picIconoCategoriaActual.Image = picPinzas.Image;

            txtBuscarMaterial.Clear();
            FiltrarTabla("");
            RefrescarCarritoVisual();
            MostrarSubVista(pnlOperacionPrestamo);
        }

        private void FiltrarTabla(string filtro)
        {
            if (inventarioCompartido == null) return;

            dgvInventario.Rows.Clear();
            string texto = filtro.ToLower();

            for (int i = 0; i < inventarioCompartido.Count; i++)
            {
                Material mat = inventarioCompartido[i];
                if (mat.Categoria == categoriaActual && mat.Nombre.ToLower().Contains(texto))
                {
                    dgvInventario.Rows.Add(mat.Id, mat.Nombre, mat.StockDisponible, "0");
                }
            }
        }

        private void RefrescarCarritoVisual()
        {
            if (carritoCompartido == null) return;

            lstCarritoVivo.Items.Clear();
            List<string> lineas = carritoCompartido.MostrarProductos();
            int totalPiezas = 0;

            for (int i = 0; i < lineas.Count; i++)
            {
                lstCarritoVivo.Items.Add(lineas[i]);
                totalPiezas = totalPiezas + carritoCompartido.Items[i].Cantidad;
            }

            lblMesaActualBadge.Text = "Mesa asignada: " + carritoCompartido.MesaAsignada;
            lblResumenRapidoCarrito.Text = "• Piezas en carrito: " + totalPiezas + "\n• Mesa: " + carritoCompartido.MesaAsignada;
            ActualizarBarraProgresoCategoria();
        }
        #endregion

        #region Eventos de Controles
        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AbrirCategoria(btn.Tag.ToString());
        }

        private void btnIrAPedidoDesdeCat_Click(object sender, EventArgs e)
        {
            AbrirCategoria(categoriaActual);
        }

        private void btnVolverCategorias_Click(object sender, EventArgs e)
        {
            MostrarSubVista(pnlSelectorCategorias);
        }

        private void txtBuscarMaterial_TextChanged(object sender, EventArgs e)
        {
            FiltrarTabla(txtBuscarMaterial.Text);
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            dgvInventario.EndEdit();
            bool agregoAlgo = false;
            bool bloqueoPorValidacion = false;

            int limiteCategoria = ObtenerLimitePorCategoria(categoriaActual);
            int acumuladoCategoria = ContarPiezasEnCarritoPorCategoria(categoriaActual);

            foreach (DataGridViewRow fila in dgvInventario.Rows)
            {
                if (fila.Cells[0].Value == null) continue;

                string id = fila.Cells[0].Value.ToString();
                string cantTexto = fila.Cells[3].Value != null ? fila.Cells[3].Value.ToString().Trim() : "0";
                int cantidad = 0;

                if (int.TryParse(cantTexto, out cantidad) && cantidad > 0)
                {
                    Material matEncontrado = null;
                    for (int i = 0; i < inventarioCompartido.Count; i++)
                    {
                        if (inventarioCompartido[i].Id == id)
                        {
                            matEncontrado = inventarioCompartido[i];
                            break;
                        }
                    }

                    if (matEncontrado != null)
                    {
                        // 1. Validar límite máximo permitido por alumno en esta categoría
                        if (acumuladoCategoria >= limiteCategoria)
                        {
                            MessageBox.Show("Ya alcanzaste el límite máximo de " + limiteCategoria + " pieza(s) para la categoría " + categoriaActual + ". No puedes agregar más.", "Límite de categoría alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            bloqueoPorValidacion = true;
                            break;
                        }

                        if (acumuladoCategoria + cantidad > limiteCategoria)
                        {
                            int restantes = limiteCategoria - acumuladoCategoria;
                            MessageBox.Show("Excedes el límite de la categoría " + categoriaActual + " (máximo " + limiteCategoria + " piezas por alumno).\nSolo puedes agregar " + restantes + " pieza(s) más.", "Cupo excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            bloqueoPorValidacion = true;
                            continue;
                        }

                        // 2. Validar stock físico disponible en almacén
                        if (matEncontrado.StockDisponible <= 0)
                        {
                            MessageBox.Show("Ya no hay disponibilidad para: " + matEncontrado.Nombre + ".", "Sin disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            bloqueoPorValidacion = true;
                            continue;
                        }

                        if (cantidad > matEncontrado.StockDisponible)
                        {
                            MessageBox.Show("Stock insuficiente para: " + matEncontrado.Nombre + ".\nUnidades disponibles: " + matEncontrado.StockDisponible, "Disponibilidad limitada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            bloqueoPorValidacion = true;
                            continue;
                        }

                        matEncontrado.StockDisponible = matEncontrado.StockDisponible - cantidad;
                        carritoCompartido.AgregarProducto(matEncontrado, cantidad);
                        acumuladoCategoria += cantidad;
                        agregoAlgo = true;
                    }
                }
            }

            if (agregoAlgo)
            {
                FiltrarTabla(txtBuscarMaterial.Text);
                RefrescarCarritoVisual();

                if (acumuladoCategoria >= limiteCategoria)
                {
                    MessageBox.Show("¡Barra completa! Has alcanzado el límite máximo de " + limiteCategoria + " pieza(s) permitidas en " + categoriaActual + ".", "Cupo Lleno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (!bloqueoPorValidacion)
            {
                MessageBox.Show("Escribe una cantidad mayor a 0 en la columna 'Cantidad a pedir' antes de agregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            carritoCompartido.Vaciar(true);
            FiltrarTabla(txtBuscarMaterial.Text);
            RefrescarCarritoVisual();
        }

        private void btnIrAsignarMesa_Click(object sender, EventArgs e)
        {
            if (SolicitarIrMesas != null)
            {
                SolicitarIrMesas(this, EventArgs.Empty);
            }
        }

        private void btnConfirmarYRegistrar_Click(object sender, EventArgs e)
        {
            if (carritoCompartido.Items.Count == 0 && carritoCompartido.MesaAsignada == "Sin mesa asignada")
            {
                MessageBox.Show("Agrega al menos un material o asigna una mesa antes de confirmar el préstamo.", "Pedido vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormDatosAlumno modalAlumno = new FormDatosAlumno();
            if (modalAlumno.ShowDialog() == DialogResult.OK)
            {
                Alumno alumno = modalAlumno.AlumnoRegistrado;

                gestorExcel.GuardarPrestamo(laboratorista, alumno, carritoCompartido);

                lstTicketImpreso.Items.Clear();
                lstTicketImpreso.Items.Add("================================================");
                lstTicketImpreso.Items.Add("     FACULTAD DE INGENIERÍA - UNAM (VOLT TRACK) ");
                lstTicketImpreso.Items.Add("         COMPROBANTE OFICIAL DE PRÉSTAMO        ");
                lstTicketImpreso.Items.Add("================================================");
                lstTicketImpreso.Items.Add("Fecha/Hora:     " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                lstTicketImpreso.Items.Add("Laboratorista:  " + laboratorista.Nombre + " (" + laboratorista.NumeroCuenta + ")");
                lstTicketImpreso.Items.Add("------------------------------------------------");
                lstTicketImpreso.Items.Add("Alumno:         " + alumno.NombreCompleto);
                lstTicketImpreso.Items.Add("No. Cuenta:     " + alumno.NumeroCuenta + "  |  Brigada: " + alumno.Grupo);
                lstTicketImpreso.Items.Add("Mesa Asignada:  " + carritoCompartido.MesaAsignada);
                lstTicketImpreso.Items.Add("------------------------------------------------");
                lstTicketImpreso.Items.Add("MATERIAL PRESTADO:");

                List<string> listaFinal = carritoCompartido.MostrarProductos();
                if (listaFinal.Count == 0)
                {
                    lstTicketImpreso.Items.Add("  * Solo uso de espacio de trabajo (sin material)");
                }
                else
                {
                    for (int i = 0; i < listaFinal.Count; i++)
                    {
                        lstTicketImpreso.Items.Add("  • " + listaFinal[i]);
                    }
                }

                lstTicketImpreso.Items.Add("================================================");

                MostrarSubVista(pnlTicketFinal);
            }
        }

        private void btnFinalizarSiguienteAlumno_Click(object sender, EventArgs e)
        {
            carritoCompartido.Vaciar(false);
            RefrescarCarritoVisual();
            MostrarSubVista(pnlSelectorCategorias);

            if (PrestamoFinalizado != null)
            {
                PrestamoFinalizado(this, EventArgs.Empty);
            }
        }
        #endregion
    }
}