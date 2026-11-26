using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public class RegistroPrestamoExcel
    {
        #region Atributos
        public int IndiceLinea { get; set; }
        public string FechaHora { get; set; }
        public string CuentaAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string Mesa { get; set; }
        public string Material { get; set; }
        public int Cantidad { get; set; }

        #endregion
        #region Metodos
        public override string ToString()
        {
            return "[" + FechaHora + "] " + NombreAlumno + " (" + CuentaAlumno + ") | Mesa: " + Mesa + " | " + Cantidad + "x " + Material;
        }

        #endregion
    }

    public class GestorExcel
    {
        #region Atributos
        private string rutaArchivo;
        #endregion

        #region Constructores
        public GestorExcel()
        {
            rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RegistroPrestamos_VoltTrack.csv");
        }
        #endregion

        #region Métodos
        public void GuardarPrestamo(Laboratorista laboratorista, Alumno alumno, Carrito carrito)
        {
            bool archivoNuevo = !File.Exists(rutaArchivo);

            using (StreamWriter sw = new StreamWriter(rutaArchivo, true, Encoding.UTF8))
            {
                if (archivoNuevo)
                {
                    sw.WriteLine("Fecha_Hora,Cuenta_Laboratorista,Nombre_Laboratorista,Cuenta_Alumno,Nombre_Alumno,Grupo_Alumno,Mesa_Asignada,Categoria,Material,Cantidad,Estado");
                }

                string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                if (carrito.Items.Count == 0)
                {
                    sw.WriteLine($"{fecha},{laboratorista.NumeroCuenta},{laboratorista.Nombre},{alumno.NumeroCuenta},{alumno.NombreCompleto},{alumno.Grupo},{carrito.MesaAsignada},N/A,Solo uso de mesa,0,SOLO MESA");
                }
                else
                {
                    for (int i = 0; i < carrito.Items.Count; i++)
                    {
                        ItemCarrito item = carrito.Items[i];
                        sw.WriteLine($"{fecha},{laboratorista.NumeroCuenta},{laboratorista.Nombre},{alumno.NumeroCuenta},{alumno.NombreCompleto},{alumno.Grupo},{carrito.MesaAsignada},{item.Producto.Categoria},{item.Producto.Nombre},{item.Cantidad},ACTIVO");
                    }
                }
            }
        }

        public List<RegistroPrestamoExcel> ObtenerPrestamosActivos()
        {
            List<RegistroPrestamoExcel> activos = new List<RegistroPrestamoExcel>();
            if (!File.Exists(rutaArchivo)) return activos;

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);
            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] cols = lineas[i].Split(',');

                if (cols.Length >= 10)
                {
                    int cant = 0;
                    int.TryParse(cols[9].Trim(), out cant);
                    string estado = cols.Length >= 11 ? cols[10].Trim() : "ACTIVO";

                    if (cant > 0 && estado == "ACTIVO")
                    {
                        RegistroPrestamoExcel reg = new RegistroPrestamoExcel();
                        reg.IndiceLinea = i;
                        reg.FechaHora = cols[0].Trim();
                        reg.CuentaAlumno = cols[3].Trim();
                        reg.NombreAlumno = cols[4].Trim();
                        reg.Mesa = cols[6].Trim();
                        reg.Material = cols[8].Trim();
                        reg.Cantidad = cant;
                        activos.Add(reg);
                    }
                }
            }
            return activos;
        }

        public void RegistrarDevolucionEnExcel(int indiceLinea, List<Material> inventarioGlobal)
        {
            if (!File.Exists(rutaArchivo)) return;

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);
            if (indiceLinea <= 0 || indiceLinea >= lineas.Length) return;

            string[] cols = lineas[indiceLinea].Split(',');
            if (cols.Length < 10) return;

            string nombreMaterial = cols[8].Trim();
            int cantDevuelta = 0;
            int.TryParse(cols[9].Trim(), out cantDevuelta);

            for (int j = 0; j < inventarioGlobal.Count; j++)
            {
                if (inventarioGlobal[j].Nombre == nombreMaterial)
                {
                    inventarioGlobal[j].StockDisponible += cantDevuelta;
                    break;
                }
            }

            string estadoNuevo = "DEVUELTO (" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ")";
            if (cols.Length >= 11)
            {
                cols[10] = estadoNuevo;
                lineas[indiceLinea] = string.Join(",", cols);
            }
            else
            {
                lineas[indiceLinea] = lineas[indiceLinea] + "," + estadoNuevo;
            }

            File.WriteAllLines(rutaArchivo, lineas, Encoding.UTF8);
        }
        #endregion
    }

    public class FormDevolucion : Form
    {
        private List<Material> inventarioGlobal;
        private GestorExcel gestorExcel = new GestorExcel();
        private List<RegistroPrestamoExcel> prestamosActivos = new List<RegistroPrestamoExcel>();

        private Label lblTitulo;
        private Label lblSubtitulo;
        private ListBox lstPrestamosActivos;
        private Button btnConfirmarDevolucion;
        private Button btnCerrar;

        public FormDevolucion(List<Material> inventario)
        {
            inventarioGlobal = inventario;
            InicializarUI();
            CargarActivos();
        }

        private void InicializarUI()
        {
            this.Text = "Devolución de Material — Volt Track";
            this.Size = new Size(780, 460);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(45, 20, 44);
            this.Padding = new Padding(20);

            lblTitulo = new Label();
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(238, 69, 64);
            lblTitulo.Height = 32;
            lblTitulo.Text = "↩ DEVOLUCIÓN DE MATERIAL PRESTADO";

            lblSubtitulo = new Label();
            lblSubtitulo.Dock = DockStyle.Top;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(225, 210, 220);
            lblSubtitulo.Height = 28;
            lblSubtitulo.Text = "Selecciona un registro activo de Excel para reintegrar el material al inventario:";

            lstPrestamosActivos = new ListBox();
            lstPrestamosActivos.BackColor = Color.FromArgb(81, 10, 50);
            lstPrestamosActivos.BorderStyle = BorderStyle.FixedSingle;
            lstPrestamosActivos.Dock = DockStyle.Fill;
            lstPrestamosActivos.Font = new Font("Consolas", 9.5F);
            lstPrestamosActivos.ForeColor = Color.White;

            Panel pnlBotones = new Panel();
            pnlBotones.Dock = DockStyle.Bottom;
            pnlBotones.Height = 52;
            pnlBotones.Padding = new Padding(0, 10, 0, 0);

            btnConfirmarDevolucion = new Button();
            btnConfirmarDevolucion.BackColor = Color.FromArgb(46, 204, 113);
            btnConfirmarDevolucion.Cursor = Cursors.Hand;
            btnConfirmarDevolucion.Dock = DockStyle.Left;
            btnConfirmarDevolucion.FlatAppearance.BorderSize = 0;
            btnConfirmarDevolucion.FlatStyle = FlatStyle.Flat;
            btnConfirmarDevolucion.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            btnConfirmarDevolucion.ForeColor = Color.FromArgb(20, 20, 25);
            btnConfirmarDevolucion.Width = 370;
            btnConfirmarDevolucion.Text = "✔ REGISTRAR DEVOLUCIÓN Y REPONER STOCK";
            btnConfirmarDevolucion.Click += BtnConfirmarDevolucion_Click;

            btnCerrar = new Button();
            btnCerrar.BackColor = Color.FromArgb(128, 19, 54);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Width = 150;
            btnCerrar.Text = "CERRAR";
            btnCerrar.Click += (s, e) => this.Close();

            pnlBotones.Controls.Add(btnConfirmarDevolucion);
            pnlBotones.Controls.Add(btnCerrar);

            this.Controls.Add(lstPrestamosActivos);
            this.Controls.Add(lblSubtitulo);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(pnlBotones);
        }

        private void CargarActivos()
        {
            lstPrestamosActivos.Items.Clear();
            prestamosActivos = gestorExcel.ObtenerPrestamosActivos();

            if (prestamosActivos.Count == 0)
            {
                lstPrestamosActivos.Items.Add("No hay préstamos pendientes de devolución en el registro de Excel.");
                btnConfirmarDevolucion.Enabled = false;
                return;
            }

            btnConfirmarDevolucion.Enabled = true;
            for (int i = 0; i < prestamosActivos.Count; i++)
            {
                lstPrestamosActivos.Items.Add(prestamosActivos[i].ToString());
            }
        }

        private void BtnConfirmarDevolucion_Click(object sender, EventArgs e)
        {
            if (lstPrestamosActivos.SelectedIndex < 0 || prestamosActivos.Count == 0)
            {
                MessageBox.Show("Selecciona un préstamo de la lista para marcar su devolución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegistroPrestamoExcel seleccionado = prestamosActivos[lstPrestamosActivos.SelectedIndex];
            gestorExcel.RegistrarDevolucionEnExcel(seleccionado.IndiceLinea, inventarioGlobal);

            MessageBox.Show("Devolución registrada con éxito (" + seleccionado.Cantidad + "x " + seleccionado.Material + ").\nEl stock ha sido repuesto en el sistema y actualizado en Excel.", "Material Devuelto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarActivos();
        }
    }
}