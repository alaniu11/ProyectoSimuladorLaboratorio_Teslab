using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    partial class FormDatosAlumno
    {
        #region Atributos del Diseñador
        private System.ComponentModel.IContainer components = null;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Panel pnlLineaEncabezado;
        private Panel pnlCuerpo;
        private Panel pnlCampos;
        private Label lblCuenta;
        private TextBox txtbCuenta;
        private Label lblNombre;
        private TextBox txtbNombre;
        private Label lblGrupo;
        private TextBox txtbGrupo;
        private Button btnConfirmar;
        private Panel pnlTarjetaCredencial;
        private Label lblTituloCredencial;
        private PictureBox picCredencialUnam;
        private Label lblPieCredencial;
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            pnlLineaEncabezado = new Panel();
            pnlCuerpo = new Panel();
            pnlTarjetaCredencial = new Panel();
            picCredencialUnam = new PictureBox();
            lblPieCredencial = new Label();
            lblTituloCredencial = new Label();
            pnlCampos = new Panel();
            btnConfirmar = new Button();
            txtbGrupo = new TextBox();
            lblGrupo = new Label();
            txtbNombre = new TextBox();
            lblNombre = new Label();
            txtbCuenta = new TextBox();
            lblCuenta = new Label();
            pnlEncabezado.SuspendLayout();
            pnlCuerpo.SuspendLayout();
            pnlTarjetaCredencial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCredencialUnam).BeginInit();
            pnlCampos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(81, 10, 50);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(790, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Consolas", 13.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(238, 69, 64);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(790, 56);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DATOS DEL ALUMNO SOLICITANTE — TESLAB";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLineaEncabezado
            // 
            pnlLineaEncabezado.BackColor = Color.FromArgb(199, 44, 65);
            pnlLineaEncabezado.Dock = DockStyle.Top;
            pnlLineaEncabezado.Location = new Point(0, 56);
            pnlLineaEncabezado.Name = "pnlLineaEncabezado";
            pnlLineaEncabezado.Size = new Size(790, 2);
            pnlLineaEncabezado.TabIndex = 1;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(45, 20, 44);
            pnlCuerpo.Controls.Add(pnlTarjetaCredencial);
            pnlCuerpo.Controls.Add(pnlCampos);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 58);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Padding = new Padding(22, 18, 22, 18);
            pnlCuerpo.Size = new Size(790, 325);
            pnlCuerpo.TabIndex = 2;
            // 
            // pnlTarjetaCredencial
            // 
            pnlTarjetaCredencial.BackColor = Color.FromArgb(81, 10, 50);
            pnlTarjetaCredencial.Controls.Add(picCredencialUnam);
            pnlTarjetaCredencial.Controls.Add(lblPieCredencial);
            pnlTarjetaCredencial.Controls.Add(lblTituloCredencial);
            pnlTarjetaCredencial.Location = new Point(455, 18);
            pnlTarjetaCredencial.Name = "pnlTarjetaCredencial";
            pnlTarjetaCredencial.Padding = new Padding(14, 10, 14, 10);
            pnlTarjetaCredencial.Size = new Size(313, 286);
            pnlTarjetaCredencial.TabIndex = 1;
            // 
            // picCredencialUnam
            // 
            picCredencialUnam.BackColor = Color.FromArgb(45, 20, 44);
            picCredencialUnam.BorderStyle = BorderStyle.FixedSingle;
            picCredencialUnam.Dock = DockStyle.Fill;
            picCredencialUnam.Location = new Point(14, 38);
            picCredencialUnam.Name = "picCredencialUnam";
            picCredencialUnam.Size = new Size(285, 202);
            picCredencialUnam.SizeMode = PictureBoxSizeMode.Zoom;
            picCredencialUnam.TabIndex = 0;
            picCredencialUnam.TabStop = false;
            // 
            // lblPieCredencial
            // 
            lblPieCredencial.Dock = DockStyle.Bottom;
            lblPieCredencial.Font = new Font("Segoe UI", 8.5F);
            lblPieCredencial.ForeColor = Color.FromArgb(225, 210, 218);
            lblPieCredencial.Location = new Point(14, 240);
            lblPieCredencial.Name = "lblPieCredencial";
            lblPieCredencial.Size = new Size(285, 36);
            lblPieCredencial.TabIndex = 1;
            lblPieCredencial.Text = "Identificación recibida en ventanilla\npara validación de préstamo.";
            lblPieCredencial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCredencial
            // 
            lblTituloCredencial.Dock = DockStyle.Top;
            lblTituloCredencial.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblTituloCredencial.ForeColor = Color.FromArgb(255, 210, 120);
            lblTituloCredencial.Location = new Point(14, 10);
            lblTituloCredencial.Name = "lblTituloCredencial";
            lblTituloCredencial.Size = new Size(285, 28);
            lblTituloCredencial.TabIndex = 2;
            lblTituloCredencial.Text = "[ CREDENCIAL UNAM DEL ALUMNO/ALUMNA ]";
            lblTituloCredencial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCampos
            // 
            pnlCampos.BackColor = Color.FromArgb(81, 10, 50);
            pnlCampos.Controls.Add(btnConfirmar);
            pnlCampos.Controls.Add(txtbGrupo);
            pnlCampos.Controls.Add(lblGrupo);
            pnlCampos.Controls.Add(txtbNombre);
            pnlCampos.Controls.Add(lblNombre);
            pnlCampos.Controls.Add(txtbCuenta);
            pnlCampos.Controls.Add(lblCuenta);
            pnlCampos.Location = new Point(22, 18);
            pnlCampos.Name = "pnlCampos";
            pnlCampos.Size = new Size(415, 286);
            pnlCampos.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(199, 44, 65);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(24, 210);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(367, 46);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "EMITIR TICKET DE PRÉSTAMO";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // txtbGrupo
            // 
            txtbGrupo.BackColor = Color.FromArgb(45, 20, 44);
            txtbGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtbGrupo.Font = new Font("Consolas", 11F);
            txtbGrupo.ForeColor = Color.White;
            txtbGrupo.Location = new Point(24, 156);
            txtbGrupo.Name = "txtbGrupo";
            txtbGrupo.Size = new Size(367, 25);
            txtbGrupo.TabIndex = 2;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblGrupo.ForeColor = Color.FromArgb(245, 240, 242);
            lblGrupo.Location = new Point(24, 136);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(224, 15);
            lblGrupo.TabIndex = 4;
            lblGrupo.Text = "Brigada / Grupo de Laboratorio:";
            // 
            // txtbNombre
            // 
            txtbNombre.BackColor = Color.FromArgb(45, 20, 44);
            txtbNombre.BorderStyle = BorderStyle.FixedSingle;
            txtbNombre.Font = new Font("Consolas", 11F);
            txtbNombre.ForeColor = Color.White;
            txtbNombre.Location = new Point(24, 96);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(367, 25);
            txtbNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(245, 240, 242);
            lblNombre.Location = new Point(24, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(196, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre Completo del Alumno:";
            // 
            // txtbCuenta
            // 
            txtbCuenta.BackColor = Color.FromArgb(45, 20, 44);
            txtbCuenta.BorderStyle = BorderStyle.FixedSingle;
            txtbCuenta.Font = new Font("Consolas", 11F);
            txtbCuenta.ForeColor = Color.White;
            txtbCuenta.Location = new Point(24, 36);
            txtbCuenta.MaxLength = 9;
            txtbCuenta.Name = "txtbCuenta";
            txtbCuenta.Size = new Size(367, 25);
            txtbCuenta.TabIndex = 0;
            txtbCuenta.KeyPress += txtCuenta_KeyPress;
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblCuenta.ForeColor = Color.FromArgb(245, 240, 242);
            lblCuenta.Location = new Point(24, 16);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(161, 15);
            lblCuenta.TabIndex = 6;
            lblCuenta.Text = "Número de Cuenta UNAM:";
            // 
            // FormDatosAlumno
            // 
            BackColor = Color.FromArgb(45, 20, 44);
            ClientSize = new Size(790, 383);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlLineaEncabezado);
            Controls.Add(pnlEncabezado);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDatosAlumno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Alumno - TESLAB";
            pnlEncabezado.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            pnlTarjetaCredencial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCredencialUnam).EndInit();
            pnlCampos.ResumeLayout(false);
            pnlCampos.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
    }
}