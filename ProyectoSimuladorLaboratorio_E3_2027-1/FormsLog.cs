using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public partial class FormsLog : Form
    {
        #region Constructores
        public FormsLog()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos de Validación
        private bool ValidarCuenta()
        {
            if (txtbCuenta.Text == "Numero de Cuenta" || txtbCuenta.Text.Length != 9)
            {
                errorProvider1.SetError(txtbCuenta, "Número de cuenta inválido, debe ser de 9 dígitos");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtbCuenta, "");
                return true;
            }
        }

        private bool ValidarPassword()
        {
            if (txtbPassword.Text == "Contraseña" || txtbPassword.Text.Length < 6 || txtbPassword.Text.Length > 10)
            {
                errorProvider1.SetError(txtbPassword, "Contraseña inválida, debe ser de 6 a 10 caracteres");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtbPassword, "");
                return true;
            }
        }
        #endregion

        #region Eventos
        private void FormsLog_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FormsLog_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txtbCuenta.SelectionLength = 0;
        }

        private void txtbCuenta_Enter(object sender, EventArgs e)
        {
            if (txtbCuenta.Text == "Numero de Cuenta")
            {
                txtbCuenta.Text = "";
                txtbCuenta.ForeColor = Color.White;
            }
        }

        private void txtbCuenta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCuenta.Text))
            {
                txtbCuenta.Text = "Numero de Cuenta";
                txtbCuenta.ForeColor = Color.Gray;
            }
        }

        private void txtbCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (ValidarCuenta())
                {
                    txtbPassword.Focus();
                }
            }
        }

        private void txtbPassword_Enter(object sender, EventArgs e)
        {
            if (txtbPassword.Text == "Contraseña")
            {
                txtbPassword.Text = "";
                txtbPassword.ForeColor = Color.White;
                txtbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbPassword.Text))
            {
                txtbPassword.UseSystemPasswordChar = false;
                txtbPassword.Text = "Contraseña";
                txtbPassword.ForeColor = Color.Gray;
            }
        }

        private void txtbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (ValidarPassword())
                {
                    btnAcceder.PerformClick();
                }
            }
        }

        private void btnAcceder_MouseEnter(object sender, EventArgs e)
        {
            btnAcceder.BackColor = Color.FromArgb(238, 69, 64);
        }

        private void btnAcceder_MouseLeave(object sender, EventArgs e)
        {
            btnAcceder.BackColor = Color.FromArgb(199, 44, 65);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            bool cuentaOk = ValidarCuenta();
            bool passOk = ValidarPassword();

            if (!cuentaOk || !passOk)
            {
                MessageBox.Show("Usuario y/o contraseña inválidos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Laboratorista laboratoristaTurno = new Laboratorista(txtbCuenta.Text.Trim(), "Ing. Laboratorista", "Matutino");

            MessageBox.Show("Inicio de sesión completo.", "Volt Track", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtbPassword.UseSystemPasswordChar = false;
            txtbPassword.Text = "Contraseña";
            txtbPassword.ForeColor = Color.Gray;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormsPrincipal)
                {
                    FormsPrincipal existente = (FormsPrincipal)frm;
                    existente.ActualizarLaboratorista(laboratoristaTurno);
                    existente.Show();
                    this.Hide();
                    return;
                }
            }

            FormsPrincipal ventanaPrincipal = new FormsPrincipal(laboratoristaTurno);
            ventanaPrincipal.Show();
            this.Hide();
        }
        #endregion
    }
}