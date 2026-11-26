using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    partial class FormsPrincipal
    {
        #region Atributos del Diseñador
        private System.ComponentModel.IContainer components = null;
        private Panel pnlBarraSuperior;
        private Label lblTituloApp;
        private Label lblInfoLaboratorista;
        private Button btnVolverInicio;
        private Panel pnlLineaSuperior;
        private Panel pnlContenido;
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
            pnlBarraSuperior = new Panel();
            lblTituloApp = new Label();
            lblInfoLaboratorista = new Label();
            btnVolverInicio = new Button();
            pnlLineaSuperior = new Panel();
            pnlContenido = new Panel();
            pnlBarraSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            pnlBarraSuperior.BackColor = Color.FromArgb(81, 10, 50);
            pnlBarraSuperior.Controls.Add(lblTituloApp);
            pnlBarraSuperior.Controls.Add(lblInfoLaboratorista);
            pnlBarraSuperior.Controls.Add(btnVolverInicio);
            pnlBarraSuperior.Dock = DockStyle.Top;
            pnlBarraSuperior.Location = new Point(0, 0);
            pnlBarraSuperior.Name = "pnlBarraSuperior";
            pnlBarraSuperior.Padding = new Padding(25, 10, 25, 10);
            pnlBarraSuperior.Size = new Size(862, 65);
            pnlBarraSuperior.TabIndex = 2;
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Dock = DockStyle.Left;
            lblTituloApp.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblTituloApp.ForeColor = Color.FromArgb(238, 69, 64);
            lblTituloApp.Location = new Point(25, 10);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(290, 22);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Text = "TESLAB | LAB. DE ELECTRÓNICA";
            lblTituloApp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfoLaboratorista
            // 
            lblInfoLaboratorista.AutoSize = true;
            lblInfoLaboratorista.Dock = DockStyle.Right;
            lblInfoLaboratorista.Font = new Font("Segoe UI", 10F);
            lblInfoLaboratorista.ForeColor = Color.FromArgb(245, 240, 242);
            lblInfoLaboratorista.Location = new Point(513, 10);
            lblInfoLaboratorista.Name = "lblInfoLaboratorista";
            lblInfoLaboratorista.Padding = new Padding(0, 0, 20, 0);
            lblInfoLaboratorista.Size = new Size(169, 19);
            lblInfoLaboratorista.TabIndex = 1;
            lblInfoLaboratorista.Text = "Laboratorista en Turno";
            lblInfoLaboratorista.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = Color.FromArgb(128, 19, 54);
            btnVolverInicio.Cursor = Cursors.Hand;
            btnVolverInicio.Dock = DockStyle.Right;
            btnVolverInicio.FlatAppearance.BorderColor = Color.FromArgb(199, 44, 65);
            btnVolverInicio.FlatStyle = FlatStyle.Flat;
            btnVolverInicio.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnVolverInicio.ForeColor = Color.White;
            btnVolverInicio.Location = new Point(682, 10);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(155, 45);
            btnVolverInicio.TabIndex = 2;
            btnVolverInicio.Text = "⌂ INICIO";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // pnlLineaSuperior
            // 
            pnlLineaSuperior.BackColor = Color.FromArgb(199, 44, 65);
            pnlLineaSuperior.Dock = DockStyle.Top;
            pnlLineaSuperior.Location = new Point(0, 65);
            pnlLineaSuperior.Name = "pnlLineaSuperior";
            pnlLineaSuperior.Size = new Size(862, 2);
            pnlLineaSuperior.TabIndex = 1;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(45, 20, 44);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 67);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(862, 442);
            pnlContenido.TabIndex = 0;
            // 
            // FormsPrincipal
            // 
            BackColor = Color.FromArgb(45, 20, 44);
            ClientSize = new Size(862, 509);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLineaSuperior);
            Controls.Add(pnlBarraSuperior);
            Name = "FormsPrincipal";
            Text = "Volt Track - Estación del Laboratorista";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormsPrincipal_FormClosed;
            pnlBarraSuperior.ResumeLayout(false);
            pnlBarraSuperior.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
    }
}