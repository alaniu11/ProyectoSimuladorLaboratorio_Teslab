using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    partial class UcInicio
    {
        #region Atributos del Diseñador
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutPrincipal;
        private Panel pnlIzquierdoPersonaje;
        public PictureBox picLaboratorista;
        private Label lblSaludoLab;
        private TableLayoutPanel pnlDerechoOpciones;
        private Panel pnlTarjetaOpciones;
        private Label lblTituloModulo;
        private Label lblDescripcion;
        private Panel pnlSeparador;
        private Button btnModuloPrestamo;
        private Button btnModuloMesas;
        private Panel pnlAccionesInferiores;
        private Button btnDevolucionMaterial;
        private Button btnCerrarSesion;
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
            layoutPrincipal = new TableLayoutPanel();
            pnlIzquierdoPersonaje = new Panel();
            picLaboratorista = new PictureBox();
            lblSaludoLab = new Label();
            pnlDerechoOpciones = new TableLayoutPanel();
            pnlTarjetaOpciones = new Panel();
            btnModuloMesas = new Button();
            btnModuloPrestamo = new Button();
            pnlSeparador = new Panel();
            lblDescripcion = new Label();
            lblTituloModulo = new Label();
            pnlAccionesInferiores = new Panel();
            btnDevolucionMaterial = new Button();
            btnCerrarSesion = new Button();
            layoutPrincipal.SuspendLayout();
            pnlIzquierdoPersonaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLaboratorista).BeginInit();
            pnlDerechoOpciones.SuspendLayout();
            pnlTarjetaOpciones.SuspendLayout();
            pnlAccionesInferiores.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPrincipal
            // 
            layoutPrincipal.ColumnCount = 2;
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            layoutPrincipal.Controls.Add(pnlIzquierdoPersonaje, 0, 0);
            layoutPrincipal.Controls.Add(pnlDerechoOpciones, 1, 0);
            layoutPrincipal.Dock = DockStyle.Fill;
            layoutPrincipal.Location = new Point(0, 0);
            layoutPrincipal.Name = "layoutPrincipal";
            layoutPrincipal.RowCount = 1;
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPrincipal.Size = new Size(1280, 655);
            layoutPrincipal.TabIndex = 0;
            // 
            // pnlIzquierdoPersonaje
            // 
            pnlIzquierdoPersonaje.Controls.Add(picLaboratorista);
            pnlIzquierdoPersonaje.Controls.Add(lblSaludoLab);
            pnlIzquierdoPersonaje.Dock = DockStyle.Fill;
            pnlIzquierdoPersonaje.Location = new Point(3, 3);
            pnlIzquierdoPersonaje.Name = "pnlIzquierdoPersonaje";
            pnlIzquierdoPersonaje.Padding = new Padding(40, 30, 20, 30);
            pnlIzquierdoPersonaje.Size = new Size(570, 649);
            pnlIzquierdoPersonaje.TabIndex = 0;
            // 
            // picLaboratorista
            // 
            picLaboratorista.BackColor = Color.FromArgb(45, 20, 44);
            picLaboratorista.Dock = DockStyle.Fill;
            picLaboratorista.Location = new Point(40, 30);
            picLaboratorista.Name = "picLaboratorista";
            picLaboratorista.Size = new Size(510, 544);
            picLaboratorista.SizeMode = PictureBoxSizeMode.Zoom;
            picLaboratorista.TabIndex = 0;
            picLaboratorista.TabStop = false;
            // 
            // lblSaludoLab
            // 
            lblSaludoLab.Dock = DockStyle.Bottom;
            lblSaludoLab.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblSaludoLab.ForeColor = Color.FromArgb(238, 69, 64);
            lblSaludoLab.Location = new Point(40, 574);
            lblSaludoLab.Name = "lblSaludoLab";
            lblSaludoLab.Size = new Size(510, 45);
            lblSaludoLab.TabIndex = 1;
            lblSaludoLab.Text = "[ SISTEMA LISTO PARA ATENDER ALUMNOS ]";
            lblSaludoLab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDerechoOpciones
            // 
            pnlDerechoOpciones.ColumnCount = 3;
            pnlDerechoOpciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlDerechoOpciones.ColumnStyles.Add(new ColumnStyle());
            pnlDerechoOpciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlDerechoOpciones.Controls.Add(pnlTarjetaOpciones, 1, 1);
            pnlDerechoOpciones.Controls.Add(pnlAccionesInferiores, 1, 2);
            pnlDerechoOpciones.Dock = DockStyle.Fill;
            pnlDerechoOpciones.Location = new Point(579, 3);
            pnlDerechoOpciones.Name = "pnlDerechoOpciones";
            pnlDerechoOpciones.RowCount = 3;
            pnlDerechoOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlDerechoOpciones.RowStyles.Add(new RowStyle());
            pnlDerechoOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlDerechoOpciones.Size = new Size(698, 649);
            pnlDerechoOpciones.TabIndex = 1;
            // 
            // pnlTarjetaOpciones
            // 
            pnlTarjetaOpciones.BackColor = Color.FromArgb(81, 10, 50);
            pnlTarjetaOpciones.Controls.Add(btnModuloMesas);
            pnlTarjetaOpciones.Controls.Add(btnModuloPrestamo);
            pnlTarjetaOpciones.Controls.Add(pnlSeparador);
            pnlTarjetaOpciones.Controls.Add(lblDescripcion);
            pnlTarjetaOpciones.Controls.Add(lblTituloModulo);
            pnlTarjetaOpciones.Location = new Point(89, 104);
            pnlTarjetaOpciones.Margin = new Padding(0);
            pnlTarjetaOpciones.Name = "pnlTarjetaOpciones";
            pnlTarjetaOpciones.Size = new Size(520, 440);
            pnlTarjetaOpciones.TabIndex = 0;
            // 
            // btnModuloMesas
            // 
            btnModuloMesas.BackColor = Color.FromArgb(128, 19, 54);
            btnModuloMesas.Cursor = Cursors.Hand;
            btnModuloMesas.FlatAppearance.BorderColor = Color.FromArgb(199, 44, 65);
            btnModuloMesas.FlatAppearance.BorderSize = 2;
            btnModuloMesas.FlatStyle = FlatStyle.Flat;
            btnModuloMesas.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnModuloMesas.ForeColor = Color.White;
            btnModuloMesas.Location = new Point(75, 280);
            btnModuloMesas.Name = "btnModuloMesas";
            btnModuloMesas.Size = new Size(370, 90);
            btnModuloMesas.TabIndex = 0;
            btnModuloMesas.Text = "🖥️ ESPACIO DE TRABAJO\nAsignación y estado de mesas";
            btnModuloMesas.UseVisualStyleBackColor = false;
            btnModuloMesas.Click += btnModuloMesas_Click;
            btnModuloMesas.MouseEnter += Btn_MouseEnter;
            btnModuloMesas.MouseLeave += BtnMesas_MouseLeave;
            // 
            // btnModuloPrestamo
            // 
            btnModuloPrestamo.BackColor = Color.FromArgb(199, 44, 65);
            btnModuloPrestamo.Cursor = Cursors.Hand;
            btnModuloPrestamo.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnModuloPrestamo.FlatAppearance.BorderSize = 2;
            btnModuloPrestamo.FlatStyle = FlatStyle.Flat;
            btnModuloPrestamo.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnModuloPrestamo.ForeColor = Color.White;
            btnModuloPrestamo.Location = new Point(75, 160);
            btnModuloPrestamo.Name = "btnModuloPrestamo";
            btnModuloPrestamo.Size = new Size(370, 90);
            btnModuloPrestamo.TabIndex = 1;
            btnModuloPrestamo.Text = "⚡ PRÉSTAMO DE MATERIAL\nComponentes electrónicos y herramientas de utilidad";
            btnModuloPrestamo.UseVisualStyleBackColor = false;
            btnModuloPrestamo.Click += btnModuloPrestamo_Click;
            btnModuloPrestamo.MouseEnter += Btn_MouseEnter;
            btnModuloPrestamo.MouseLeave += BtnPrestamo_MouseLeave;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.FromArgb(128, 19, 54);
            pnlSeparador.Location = new Point(60, 122);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(400, 2);
            pnlSeparador.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(225, 210, 218);
            lblDescripcion.Location = new Point(25, 70);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(470, 40);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Selecciona la operación que deseas realizar para el alumno en ventanilla:";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblTituloModulo.ForeColor = Color.FromArgb(238, 69, 64);
            lblTituloModulo.Location = new Point(25, 30);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(470, 35);
            lblTituloModulo.TabIndex = 4;
            lblTituloModulo.Text = "ESTACIÓN DE CONTROL";
            lblTituloModulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAccionesInferiores
            // 
            pnlAccionesInferiores.Anchor = AnchorStyles.Top;
            pnlAccionesInferiores.BackColor = Color.Transparent;
            pnlAccionesInferiores.Controls.Add(btnDevolucionMaterial);
            pnlAccionesInferiores.Controls.Add(btnCerrarSesion);
            pnlAccionesInferiores.Location = new Point(89, 558);
            pnlAccionesInferiores.Margin = new Padding(0, 14, 0, 0);
            pnlAccionesInferiores.Name = "pnlAccionesInferiores";
            pnlAccionesInferiores.Size = new Size(520, 44);
            pnlAccionesInferiores.TabIndex = 1;
            // 
            // btnDevolucionMaterial
            // 
            btnDevolucionMaterial.BackColor = Color.FromArgb(81, 10, 50);
            btnDevolucionMaterial.Cursor = Cursors.Hand;
            btnDevolucionMaterial.FlatAppearance.BorderColor = Color.FromArgb(46, 204, 113);
            btnDevolucionMaterial.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnDevolucionMaterial.ForeColor = Color.White;
            btnDevolucionMaterial.Location = new Point(0, 0);
            btnDevolucionMaterial.Name = "btnDevolucionMaterial";
            btnDevolucionMaterial.Size = new Size(215, 42);
            btnDevolucionMaterial.TabIndex = 0;
            btnDevolucionMaterial.Text = "DEVOLUCIÓN MATERIAL";
            btnDevolucionMaterial.UseVisualStyleBackColor = false;
            btnDevolucionMaterial.Click += btnDevolucionMaterial_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(95, 15, 38);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(199, 44, 65);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.FromArgb(255, 190, 190);
            btnCerrarSesion.Location = new Point(345, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(175, 42);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // UcInicio
            // 
            BackColor = Color.FromArgb(45, 20, 44);
            Controls.Add(layoutPrincipal);
            Name = "UcInicio";
            Size = new Size(1280, 655);
            layoutPrincipal.ResumeLayout(false);
            pnlIzquierdoPersonaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLaboratorista).EndInit();
            pnlDerechoOpciones.ResumeLayout(false);
            pnlTarjetaOpciones.ResumeLayout(false);
            pnlAccionesInferiores.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
    }
}