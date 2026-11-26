using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    partial class FormsLog
    {
        #region Atributos del Diseñador
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTarjetaCentral;
        private Label lblTitulo;
        private Label lblUnam;
        private Label lblFacultad;
        private Label lblSubtitulo;
        private Panel pnlLineaDecorativa;
        private TextBox txtbCuenta;
        private TextBox txtbPassword;
        private Button btnAcceder;
        private ErrorProvider errorProvider1;
        #endregion

        #region Métodos del Diseñador
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsLog));
            pnlTarjetaCentral = new Panel();
            picLogoLogin = new PictureBox();
            btnAcceder = new Button();
            txtbPassword = new TextBox();
            txtbCuenta = new TextBox();
            lblSubtitulo = new Label();
            pnlLineaDecorativa = new Panel();
            lblFacultad = new Label();
            lblUnam = new Label();
            lblTitulo = new Label();
            errorProvider1 = new ErrorProvider(components);
            pnlTarjetaCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlTarjetaCentral
            // 
            pnlTarjetaCentral.Anchor = AnchorStyles.None;
            pnlTarjetaCentral.BackColor = Color.FromArgb(81, 10, 50);
            pnlTarjetaCentral.Controls.Add(picLogoLogin);
            pnlTarjetaCentral.Controls.Add(btnAcceder);
            pnlTarjetaCentral.Controls.Add(txtbPassword);
            pnlTarjetaCentral.Controls.Add(txtbCuenta);
            pnlTarjetaCentral.Controls.Add(lblSubtitulo);
            pnlTarjetaCentral.Controls.Add(pnlLineaDecorativa);
            pnlTarjetaCentral.Controls.Add(lblFacultad);
            pnlTarjetaCentral.Controls.Add(lblUnam);
            pnlTarjetaCentral.Controls.Add(lblTitulo);
            pnlTarjetaCentral.Location = new Point(410, 125);
            pnlTarjetaCentral.Name = "pnlTarjetaCentral";
            pnlTarjetaCentral.Size = new Size(460, 549);
            pnlTarjetaCentral.TabIndex = 0;
            // 
            // picLogoLogin
            // 
            picLogoLogin.Image = (Image)resources.GetObject("picLogoLogin.Image");
            picLogoLogin.Location = new Point(133, 373);
            picLogoLogin.Name = "picLogoLogin";
            picLogoLogin.Size = new Size(201, 163);
            picLogoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoLogin.TabIndex = 8;
            picLogoLogin.TabStop = false;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(199, 44, 65);
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(100, 321);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(260, 46);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            btnAcceder.MouseEnter += btnAcceder_MouseEnter;
            btnAcceder.MouseLeave += btnAcceder_MouseLeave;
            // 
            // txtbPassword
            // 
            txtbPassword.BackColor = Color.FromArgb(45, 20, 44);
            txtbPassword.BorderStyle = BorderStyle.FixedSingle;
            txtbPassword.Font = new Font("Segoe UI", 11F);
            txtbPassword.ForeColor = Color.Gray;
            txtbPassword.Location = new Point(75, 272);
            txtbPassword.MaxLength = 10;
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(310, 27);
            txtbPassword.TabIndex = 6;
            txtbPassword.Text = "Contraseña";
            txtbPassword.TextAlign = HorizontalAlignment.Center;
            txtbPassword.Enter += txtbPassword_Enter;
            txtbPassword.KeyDown += txtbPassword_KeyDown;
            txtbPassword.Leave += txtbPassword_Leave;
            // 
            // txtbCuenta
            // 
            txtbCuenta.BackColor = Color.FromArgb(45, 20, 44);
            txtbCuenta.BorderStyle = BorderStyle.FixedSingle;
            txtbCuenta.Font = new Font("Segoe UI", 11F);
            txtbCuenta.ForeColor = Color.Gray;
            txtbCuenta.Location = new Point(75, 217);
            txtbCuenta.MaxLength = 9;
            txtbCuenta.Name = "txtbCuenta";
            txtbCuenta.Size = new Size(310, 27);
            txtbCuenta.TabIndex = 5;
            txtbCuenta.Text = "Numero de Cuenta";
            txtbCuenta.TextAlign = HorizontalAlignment.Center;
            txtbCuenta.Enter += txtbCuenta_Enter;
            txtbCuenta.KeyDown += txtbCuenta_KeyDown;
            txtbCuenta.KeyPress += txtbCuenta_KeyPress;
            txtbCuenta.Leave += txtbCuenta_Leave;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(245, 240, 242);
            lblSubtitulo.Location = new Point(20, 169);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(420, 25);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "ACCESO DE LABORATORISTA EN TURNO";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLineaDecorativa
            // 
            pnlLineaDecorativa.BackColor = Color.FromArgb(128, 19, 54);
            pnlLineaDecorativa.Location = new Point(75, 146);
            pnlLineaDecorativa.Name = "pnlLineaDecorativa";
            pnlLineaDecorativa.Size = new Size(300, 2);
            pnlLineaDecorativa.TabIndex = 3;
            // 
            // lblFacultad
            // 
            lblFacultad.Font = new Font("Segoe UI", 9F);
            lblFacultad.ForeColor = Color.FromArgb(215, 195, 205);
            lblFacultad.Location = new Point(20, 113);
            lblFacultad.Name = "lblFacultad";
            lblFacultad.Size = new Size(420, 20);
            lblFacultad.TabIndex = 2;
            lblFacultad.Text = "FACULTAD DE INGENIERÍA";
            lblFacultad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnam
            // 
            lblUnam.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUnam.ForeColor = Color.FromArgb(245, 240, 242);
            lblUnam.Location = new Point(20, 91);
            lblUnam.Name = "lblUnam";
            lblUnam.Size = new Size(420, 22);
            lblUnam.TabIndex = 1;
            lblUnam.Text = "UNIVERSIDAD NACIONAL AUTÓNOMA DE MÉXICO";
            lblUnam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(254, 194, 192);
            lblTitulo.Location = new Point(20, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(420, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "TESLAB";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormsLog
            // 
            BackColor = Color.FromArgb(45, 20, 44);
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlTarjetaCentral);
            Name = "FormsLog";
            Text = "Volt Track - Inicio de Sesión";
            WindowState = FormWindowState.Maximized;
            Load += FormsLog_Load;
            Shown += FormsLog_Shown;
            pnlTarjetaCentral.ResumeLayout(false);
            pnlTarjetaCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private PictureBox picLogoLogin;
    }
}