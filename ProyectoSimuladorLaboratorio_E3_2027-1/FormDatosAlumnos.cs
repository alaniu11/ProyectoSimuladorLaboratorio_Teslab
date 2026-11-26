using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public partial class FormDatosAlumno : Form
    {
        #region Atributos
        private Alumno alumnoRegistrado;
        #endregion

        #region Propiedades
        public Alumno AlumnoRegistrado
        {
            get { return alumnoRegistrado; }
        }
        #endregion

        #region Constructores
        public FormDatosAlumno()
        {
            InitializeComponent();
            CargarImagenCredencial();
        }
        #endregion

        #region Métodos
        private void CargarImagenCredencial()
        {
            string[] posiblesNombres = { "credencial_unam_pixel.png", "credencial_unam_pixel.jpg", "credencial_unam_pixel.jpeg" };
            for (int i = 0; i < posiblesNombres.Length; i++)
            {
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", posiblesNombres[i]);
                if (File.Exists(ruta))
                {
                    picCredencialUnam.Image = Image.FromFile(ruta);
                    return;
                }
            }
        }
        #endregion

        #region Eventos
        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtbCuenta.Text.Length < 9 || string.IsNullOrWhiteSpace(txtbNombre.Text))
            {
                MessageBox.Show("Ingresa un número de cuenta válido (9 dígitos) y el nombre del alumno.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string grupoTexto = txtbGrupo.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(grupoTexto))
            {
                grupoTexto = "GENERAL";
            }

            alumnoRegistrado = new Alumno(txtbCuenta.Text.Trim(), txtbNombre.Text.Trim().ToUpper(), grupoTexto);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}