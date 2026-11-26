using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public partial class UcInicio : UserControl
    {
        #region Eventos Personalizados
        public event EventHandler SeleccionarPrestamo;
        public event EventHandler SeleccionarMesas;
        public event EventHandler SeleccionarDevolucion;
        public event EventHandler CerrarSesionSolicitado;
        #endregion

        #region Constructores
        public UcInicio()
        {
            InitializeComponent();
            CargarImagenRecepcion();
        }
        #endregion

        #region Métodos
        private void CargarImagenRecepcion()
        {
            try
            {
                if (Properties.Resources.pochacco_recepcion != null)
                {
                    picLaboratorista.Image = Properties.Resources.pochacco_recepcion;
                    return;
                }
            }
            catch
            {
                // Si el recurso no está disponible, intenta cargar desde la carpeta Imagenes
            }

            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "pochacco_recepcion.jpeg");
            if (File.Exists(ruta))
            {
                picLaboratorista.Image = Image.FromFile(ruta);
            }
        }
        #endregion

        #region Eventos de Controles
        private void btnModuloPrestamo_Click(object sender, EventArgs e)
        {
            if (SeleccionarPrestamo != null)
            {
                SeleccionarPrestamo(this, EventArgs.Empty);
            }
        }

        private void btnModuloMesas_Click(object sender, EventArgs e)
        {
            if (SeleccionarMesas != null)
            {
                SeleccionarMesas(this, EventArgs.Empty);
            }
        }

        private void btnDevolucionMaterial_Click(object sender, EventArgs e)
        {
            if (SeleccionarDevolucion != null)
            {
                SeleccionarDevolucion(this, EventArgs.Empty);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (CerrarSesionSolicitado != null)
            {
                CerrarSesionSolicitado(this, EventArgs.Empty);
            }
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(238, 69, 64);
        }

        private void BtnPrestamo_MouseLeave(object sender, EventArgs e)
        {
            btnModuloPrestamo.BackColor = Color.FromArgb(199, 44, 65);
        }

        private void BtnMesas_MouseLeave(object sender, EventArgs e)
        {
            btnModuloMesas.BackColor = Color.FromArgb(128, 19, 54);
        }
        #endregion
    }
}