using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public partial class UcMesas : UserControl
    {
        #region Eventos Personalizados
        public event EventHandler MesaSeleccionadaParaCarrito;
        #endregion

        #region Atributos
        private Laboratorista laboratorista;
        private Carrito carritoCompartido;
        private Dictionary<string, int> lugaresFuentes;
        private GestorExcel gestorExcel = new GestorExcel();
        private string fuenteSeleccionadaActual = "";

        private Dictionary<string, string> asientosOcupadosDetalle = new Dictionary<string, string>();
        private Dictionary<string, Panel> ledsPorEstacion = new Dictionary<string, Panel>();
        private Dictionary<string, Button> botonesPorEstacion = new Dictionary<string, Button>();
        #endregion

        #region Constructores
        public UcMesas()
        {
            InitializeComponent();
        }

        public UcMesas(Laboratorista lab, Carrito carrito, Dictionary<string, int> lugares)
        {
            InitializeComponent();
            laboratorista = lab;
            carritoCompartido = carrito;
            lugaresFuentes = lugares;

            CargarImagenPochaccoFuente();
            ConstruirPlanoMesas();
            RefrescarPlanoMesas();
        }
        #endregion

        #region Métodos
        private void CargarImagenPochaccoFuente()
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "pochacco_fuente.jpeg");
            if (File.Exists(ruta))
            {
                picPochaccoFuente.Image = Image.FromFile(ruta);
            }
        }

        private void MostrarControlesAsignacion(bool visible)
        {
            pnlAsignacionDirecta.Visible = visible;
            btnConfirmarAsignacion.Visible = visible;
            btnCancelarAsignacion.Visible = visible;
        }

        private void ConstruirPlanoMesas()
        {
            gridTresMesas.Controls.Clear();
            ledsPorEstacion.Clear();
            botonesPorEstacion.Clear();

            string[] mesasOrdenVisual = { "3", "2", "1" };
            string[] letrasFuente = { "A", "B", "C" };

            for (int fila = 0; fila < 3; fila++)
            {
                string numMesa = mesasOrdenVisual[fila];

                Panel contenedorFila = new Panel();
                contenedorFila.Dock = DockStyle.Fill;
                contenedorFila.Margin = new Padding(5, 6, 5, 6);

                Label lblNumeroMesa = new Label();
                lblNumeroMesa.Dock = DockStyle.Right;
                lblNumeroMesa.Font = new Font("Consolas", 22F, FontStyle.Bold);
                lblNumeroMesa.ForeColor = Color.FromArgb(238, 69, 64);
                lblNumeroMesa.Text = numMesa;
                lblNumeroMesa.TextAlign = ContentAlignment.MiddleCenter;
                lblNumeroMesa.Width = 55;

                TableLayoutPanel barraLeds = new TableLayoutPanel();
                barraLeds.ColumnCount = 3;
                barraLeds.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                barraLeds.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                barraLeds.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                barraLeds.RowCount = 1;
                barraLeds.Dock = DockStyle.Top;
                barraLeds.Height = 26;

                TableLayoutPanel mesaAlargada = new TableLayoutPanel();
                mesaAlargada.BackColor = Color.FromArgb(81, 10, 50);
                mesaAlargada.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                mesaAlargada.ColumnCount = 3;
                mesaAlargada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                mesaAlargada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                mesaAlargada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                mesaAlargada.RowCount = 1;
                mesaAlargada.Dock = DockStyle.Fill;
                mesaAlargada.Padding = new Padding(8);

                for (int col = 0; col < 3; col++)
                {
                    string codigoEstacion = numMesa + letrasFuente[col];

                    Panel celdaLed = new Panel();
                    celdaLed.Dock = DockStyle.Fill;

                    Panel ledCircular = new Panel();
                    ledCircular.Size = new Size(18, 18);
                    ledCircular.Location = new Point(95, 3);
                    GraphicsPath rutaCirculo = new GraphicsPath();
                    rutaCirculo.AddEllipse(0, 0, 18, 18);
                    ledCircular.Region = new Region(rutaCirculo);
                    celdaLed.Controls.Add(ledCircular);
                    barraLeds.Controls.Add(celdaLed, col, 0);
                    ledsPorEstacion.Add(codigoEstacion, ledCircular);

                    Panel moduloFuente = new Panel();
                    moduloFuente.Dock = DockStyle.Fill;
                    moduloFuente.Padding = new Padding(18, 10, 18, 10);

                    Label lblBornesIzq = new Label();
                    lblBornesIzq.Dock = DockStyle.Left;
                    lblBornesIzq.Font = new Font("Consolas", 11F, FontStyle.Bold);
                    lblBornesIzq.ForeColor = Color.FromArgb(200, 180, 195);
                    lblBornesIzq.Text = "○\n○";
                    lblBornesIzq.TextAlign = ContentAlignment.MiddleCenter;
                    lblBornesIzq.Width = 22;

                    Label lblBornesDer = new Label();
                    lblBornesDer.Dock = DockStyle.Right;
                    lblBornesDer.Font = new Font("Consolas", 11F, FontStyle.Bold);
                    lblBornesDer.ForeColor = Color.FromArgb(200, 180, 195);
                    lblBornesDer.Text = "○\n○";
                    lblBornesDer.TextAlign = ContentAlignment.MiddleCenter;
                    lblBornesDer.Width = 22;

                    Button btnFuente = new Button();
                    btnFuente.BackColor = Color.FromArgb(45, 20, 44);
                    btnFuente.Cursor = Cursors.Hand;
                    btnFuente.Dock = DockStyle.Fill;
                    btnFuente.FlatAppearance.BorderColor = Color.FromArgb(46, 204, 113);
                    btnFuente.FlatAppearance.BorderSize = 2;
                    btnFuente.FlatStyle = FlatStyle.Flat;
                    btnFuente.Font = new Font("Consolas", 18F, FontStyle.Bold);
                    btnFuente.ForeColor = Color.White;
                    btnFuente.Tag = codigoEstacion;
                    btnFuente.Text = letrasFuente[col];

                    btnFuente.MouseEnter += BtnFuente_MouseEnter;
                    btnFuente.Click += BtnFuente_Click;

                    moduloFuente.Controls.Add(btnFuente);
                    moduloFuente.Controls.Add(lblBornesIzq);
                    moduloFuente.Controls.Add(lblBornesDer);

                    mesaAlargada.Controls.Add(moduloFuente, col, 0);
                    botonesPorEstacion.Add(codigoEstacion, btnFuente);
                }

                contenedorFila.Controls.Add(mesaAlargada);
                contenedorFila.Controls.Add(barraLeds);
                contenedorFila.Controls.Add(lblNumeroMesa);

                gridTresMesas.Controls.Add(contenedorFila, 0, fila);
            }
        }

        public void RefrescarPlanoMesas()
        {
            if (lugaresFuentes == null) return;

            foreach (var par in lugaresFuentes)
            {
                string estacion = par.Key;
                int lugaresLibres = par.Value;
                bool disponible = lugaresLibres > 0;

                if (ledsPorEstacion.ContainsKey(estacion))
                {
                    ledsPorEstacion[estacion].BackColor = disponible
                        ? Color.FromArgb(46, 204, 113)
                        : Color.FromArgb(231, 76, 60);
                }

                if (botonesPorEstacion.ContainsKey(estacion))
                {
                    Button btn = botonesPorEstacion[estacion];
                    btn.FlatAppearance.BorderColor = disponible
                        ? Color.FromArgb(46, 204, 113)
                        : Color.FromArgb(231, 76, 60);
                    btn.BackColor = disponible
                        ? Color.FromArgb(45, 20, 44)
                        : Color.FromArgb(95, 18, 36);
                }
            }

            RefrescarListaOcupados();
        }

        private void ActualizarMonitorHover(string estacion)
        {
            if (!lugaresFuentes.ContainsKey(estacion)) return;

            int libres = lugaresFuentes[estacion];
            string numMesa = estacion.Substring(0, 1);
            string fuente = estacion.Substring(1, 1);

            lblEstacionHover.Text = "ESTACIÓN " + estacion + " (Mesa " + numMesa + " - Fuente " + fuente + ")";
            lblLugaresHover.Text = "(lugares disponibles: " + libres + ")";

            if (libres > 0)
            {
                lblLugaresHover.ForeColor = Color.FromArgb(46, 204, 113);
                lblEstadoHover.Text = "Estado: DISPONIBLE (" + (4 - libres) + "/4 asientos ocupados).\nHaz clic para elegir asiento (1 a 4).";
            }
            else
            {
                lblLugaresHover.ForeColor = Color.FromArgb(231, 76, 60);
                lblEstadoHover.Text = "Estado: OCUPADA (4/4 asientos llenos).\nSelecciona otra fuente con LED verde.";
            }
        }

        private void CargarAsientosDisponiblesEnCombo(string estacionBase)
        {
            cmbAsientoLibre.Items.Clear();
            for (int asiento = 1; asiento <= 4; asiento++)
            {
                string codigoCompleto = estacionBase + asiento.ToString();
                if (!asientosOcupadosDetalle.ContainsKey(codigoCompleto))
                {
                    cmbAsientoLibre.Items.Add(codigoCompleto);
                }
            }

            if (cmbAsientoLibre.Items.Count > 0)
            {
                cmbAsientoLibre.SelectedIndex = 0;
            }
        }

        private string ObtenerTextoTiempoTotal()
        {
            int totalHoras = 2;
            if (chkExtensionTiempo.Checked)
            {
                totalHoras += (int)numHorasExtra.Value;
                return totalHoras + " horas (2h base + " + (int)numHorasExtra.Value + "h extensión)";
            }
            return "2 horas (Tiempo mínimo)";
        }

        private void RefrescarListaOcupados()
        {
            lstAsientosOcupados.Items.Clear();
            foreach (var item in asientosOcupadosDetalle)
            {
                lstAsientosOcupados.Items.Add(item.Value);
            }
        }
        #endregion

        #region Eventos de Controles
        private void BtnFuente_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActualizarMonitorHover(btn.Tag.ToString());
        }

        private void BtnFuente_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string estacion = btn.Tag.ToString();
            int libres = lugaresFuentes[estacion];

            if (libres <= 0)
            {
                MessageBox.Show("La estación " + estacion + " ya tiene sus 4 lugares ocupados.", "Fuente llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fuenteSeleccionadaActual = estacion;
            lblEstacionSeleccionada.Text = "Fuente seleccionada: " + estacion + " (Mesa " + estacion[0] + " Fuente " + estacion[1] + ")";
            CargarAsientosDisponiblesEnCombo(estacion);

            chkExtensionTiempo.Checked = false;
            numHorasExtra.Value = 1;
            numHorasExtra.Enabled = false;
            lblTotalHoras.Text = "Total tiempo de uso: 2 horas";

            pnlListaOcupados.Visible = false;
            MostrarControlesAsignacion(true);
        }

        private void chkExtensionTiempo_CheckedChanged(object sender, EventArgs e)
        {
            numHorasExtra.Enabled = chkExtensionTiempo.Checked;
            int total = chkExtensionTiempo.Checked ? 2 + (int)numHorasExtra.Value : 2;
            lblTotalHoras.Text = "Total tiempo de uso: " + total + " horas";
        }

        private void numHorasExtra_ValueChanged(object sender, EventArgs e)
        {
            int total = chkExtensionTiempo.Checked ? 2 + (int)numHorasExtra.Value : 2;
            lblTotalHoras.Text = "Total tiempo de uso: " + total + " horas";
        }

        private void btnConfirmarAsignacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fuenteSeleccionadaActual) || cmbAsientoLibre.SelectedItem == null) return;

            string codigoAsiento = cmbAsientoLibre.SelectedItem.ToString();
            string tiempoTexto = ObtenerTextoTiempoTotal();

            if (carritoCompartido != null && carritoCompartido.Items.Count > 0)
            {
                if (asientosOcupadosDetalle.ContainsKey(carritoCompartido.MesaAsignada))
                {
                    string fuenteAnterior = carritoCompartido.MesaAsignada.Substring(0, 2);
                    asientosOcupadosDetalle.Remove(carritoCompartido.MesaAsignada);
                    if (lugaresFuentes.ContainsKey(fuenteAnterior))
                    {
                        lugaresFuentes[fuenteAnterior]++;
                    }
                }

                lugaresFuentes[fuenteSeleccionadaActual]--;
                asientosOcupadosDetalle[codigoAsiento] = codigoAsiento + " | Pedido en curso (" + tiempoTexto + ")";
                carritoCompartido.MesaAsignada = codigoAsiento;

                MostrarControlesAsignacion(false);
                RefrescarPlanoMesas();
                ActualizarMonitorHover(fuenteSeleccionadaActual);

                MessageBox.Show("Asiento " + codigoAsiento + " vinculado a tu préstamo de material.\nDuración: " + tiempoTexto, "Asiento Asignado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MesaSeleccionadaParaCarrito != null)
                {
                    MesaSeleccionadaParaCarrito(this, EventArgs.Empty);
                }
            }
            else
            {
                FormDatosAlumno modal = new FormDatosAlumno();
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Alumno alumno = modal.AlumnoRegistrado;

                    lugaresFuentes[fuenteSeleccionadaActual]--;
                    asientosOcupadosDetalle[codigoAsiento] = codigoAsiento + " | " + alumno.NombreCompleto + " (" + alumno.NumeroCuenta + ")";

                    Carrito carritoSoloMesa = new Carrito();
                    carritoSoloMesa.MesaAsignada = codigoAsiento + " - " + tiempoTexto;
                    gestorExcel.GuardarPrestamo(laboratorista, alumno, carritoSoloMesa);

                    MostrarControlesAsignacion(false);
                    RefrescarPlanoMesas();
                    ActualizarMonitorHover(fuenteSeleccionadaActual);

                    MessageBox.Show("Lugar " + codigoAsiento + " asignado a " + alumno.NombreCompleto + ".\nDuración: " + tiempoTexto + "\nRegistro guardado en Excel.", "Asignación Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fuenteSeleccionadaActual = "";
                }
            }
        }

        private void btnCancelarAsignacion_Click(object sender, EventArgs e)
        {
            MostrarControlesAsignacion(false);
            fuenteSeleccionadaActual = "";
        }

        private void btnAbrirDesocupar_Click(object sender, EventArgs e)
        {
            RefrescarListaOcupados();
            if (asientosOcupadosDetalle.Count == 0)
            {
                MessageBox.Show("Actualmente todos los lugares del laboratorio están libres.", "Sin lugares ocupados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MostrarControlesAsignacion(false);
            pnlListaOcupados.Visible = true;
        }

        private void btnLiberarSeleccionado_Click(object sender, EventArgs e)
        {
            if (lstAsientosOcupados.SelectedItem == null)
            {
                MessageBox.Show("Selecciona de la lista el lugar que deseas desocupar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lineaSeleccionada = lstAsientosOcupados.SelectedItem.ToString();
            string codigoAsiento = lineaSeleccionada.Substring(0, 3);
            string estacionBase = codigoAsiento.Substring(0, 2);

            if (asientosOcupadosDetalle.ContainsKey(codigoAsiento))
            {
                asientosOcupadosDetalle.Remove(codigoAsiento);
                if (lugaresFuentes.ContainsKey(estacionBase) && lugaresFuentes[estacionBase] < 4)
                {
                    lugaresFuentes[estacionBase]++;
                }

                if (carritoCompartido != null && carritoCompartido.MesaAsignada == codigoAsiento)
                {
                    carritoCompartido.MesaAsignada = "Sin mesa asignada";
                }

                RefrescarPlanoMesas();
                ActualizarMonitorHover(estacionBase);
                MessageBox.Show("El lugar " + codigoAsiento + " ha sido desocupado y vuelve a estar disponible.", "Lugar Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (asientosOcupadosDetalle.Count == 0)
                {
                    pnlListaOcupados.Visible = false;
                }
            }
        }

        private void btnCerrarListaOcupados_Click(object sender, EventArgs e)
        {
            pnlListaOcupados.Visible = false;
        }
        #endregion
    }
}