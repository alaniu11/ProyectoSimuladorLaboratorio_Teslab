using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    partial class UcMesas
    {
        #region Atributos del Diseñador
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutPrincipalMesas;

        // Columna Izquierda: Área de Diseño + Pochacco con Fuente + Leyenda LED
        private Panel pnlIzquierdoDecoracion;
        private Label lblTituloZonaIzq;
        private Label lblInfoZonaIzq;
        public PictureBox picPochaccoFuente;
        private Panel pnlLeyendaLed;
        private Panel ledMuestraVerde;
        private Label lblLeyendaVerde;
        private Panel ledMuestraRojo;
        private Label lblLeyendaRojo;

        // Columna Central: Las 3 Mesas Alargadas (3, 2, 1) con sus fuentes A, B, C
        private Panel pnlCentroPlano;
        private Label lblTituloPlano;
        private TableLayoutPanel gridTresMesas;

        // Columna Derecha: Monitor de Hover + Configuración Asiento + Botones Abajo
        private Panel pnlDerechoMonitor;
        private Label lblTituloMonitor;
        private Panel pnlTarjetaHover;
        private Label lblEstacionHover;
        private Label lblLugaresHover;
        private Label lblEstadoHover;

        // Panel Central: Configuración de Asiento (1-4) y Tiempo (2h base + extensión)
        private Panel pnlAsignacionDirecta;
        private Label lblTituloAsignacion;
        private Label lblEstacionSeleccionada;
        private Label lblAsientoPrompt;
        private ComboBox cmbAsientoLibre;
        private Label lblTiempoBase;
        private CheckBox chkExtensionTiempo;
        private NumericUpDown numHorasExtra;
        private Label lblTotalHoras;

        // Zona Inferior Derecha: Botón Confirmar Asiento arriba de Desocupar Lugar + Lista Ocupados
        private Panel pnlZonaInferiorBotones;
        private Button btnConfirmarAsignacion;
        private Button btnCancelarAsignacion;
        private Button btnAbrirDesocupar;

        private Panel pnlListaOcupados;
        private Label lblTituloOcupados;
        private ListBox lstAsientosOcupados;
        private Button btnLiberarSeleccionado;
        private Button btnCerrarListaOcupados;
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
            this.layoutPrincipalMesas = new TableLayoutPanel();
            this.pnlIzquierdoDecoracion = new Panel();
            this.lblTituloZonaIzq = new Label();
            this.lblInfoZonaIzq = new Label();
            this.picPochaccoFuente = new PictureBox();
            this.pnlLeyendaLed = new Panel();
            this.ledMuestraVerde = new Panel();
            this.lblLeyendaVerde = new Label();
            this.ledMuestraRojo = new Panel();
            this.lblLeyendaRojo = new Label();

            this.pnlCentroPlano = new Panel();
            this.lblTituloPlano = new Label();
            this.gridTresMesas = new TableLayoutPanel();

            this.pnlDerechoMonitor = new Panel();
            this.lblTituloMonitor = new Label();
            this.pnlTarjetaHover = new Panel();
            this.lblEstacionHover = new Label();
            this.lblLugaresHover = new Label();
            this.lblEstadoHover = new Label();

            this.pnlAsignacionDirecta = new Panel();
            this.lblTituloAsignacion = new Label();
            this.lblEstacionSeleccionada = new Label();
            this.lblAsientoPrompt = new Label();
            this.cmbAsientoLibre = new ComboBox();
            this.lblTiempoBase = new Label();
            this.chkExtensionTiempo = new CheckBox();
            this.numHorasExtra = new NumericUpDown();
            this.lblTotalHoras = new Label();

            this.pnlZonaInferiorBotones = new Panel();
            this.btnConfirmarAsignacion = new Button();
            this.btnCancelarAsignacion = new Button();
            this.btnAbrirDesocupar = new Button();

            this.pnlListaOcupados = new Panel();
            this.lblTituloOcupados = new Label();
            this.lstAsientosOcupados = new ListBox();
            this.btnLiberarSeleccionado = new Button();
            this.btnCerrarListaOcupados = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.picPochaccoFuente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtra)).BeginInit();
            this.SuspendLayout();

            // Layout de 3 columnas (19% izq | 52% plano mesas | 29% monitor y control)
            this.layoutPrincipalMesas.ColumnCount = 3;
            this.layoutPrincipalMesas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            this.layoutPrincipalMesas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
            this.layoutPrincipalMesas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29F));
            this.layoutPrincipalMesas.RowCount = 1;
            this.layoutPrincipalMesas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.layoutPrincipalMesas.Controls.Add(this.pnlIzquierdoDecoracion, 0, 0);
            this.layoutPrincipalMesas.Controls.Add(this.pnlCentroPlano, 1, 0);
            this.layoutPrincipalMesas.Controls.Add(this.pnlDerechoMonitor, 2, 0);
            this.layoutPrincipalMesas.Dock = DockStyle.Fill;
            this.layoutPrincipalMesas.Padding = new Padding(20, 15, 20, 15);

            // ==================== COLUMNA IZQUIERDA ====================
            this.pnlIzquierdoDecoracion.BackColor = Color.FromArgb(81, 10, 50);
            this.pnlIzquierdoDecoracion.Controls.Add(this.picPochaccoFuente);
            this.pnlIzquierdoDecoracion.Controls.Add(this.pnlLeyendaLed);
            this.pnlIzquierdoDecoracion.Controls.Add(this.lblInfoZonaIzq);
            this.pnlIzquierdoDecoracion.Controls.Add(this.lblTituloZonaIzq);
            this.pnlIzquierdoDecoracion.Dock = DockStyle.Fill;
            this.pnlIzquierdoDecoracion.Margin = new Padding(0, 0, 12, 0);
            this.pnlIzquierdoDecoracion.Padding = new Padding(14);

            this.lblTituloZonaIzq.Dock = DockStyle.Top;
            this.lblTituloZonaIzq.Font = new Font("Consolas", 11F, FontStyle.Bold);
            this.lblTituloZonaIzq.ForeColor = Color.FromArgb(238, 69, 64);
            this.lblTituloZonaIzq.Height = 32;
            this.lblTituloZonaIzq.Text = "ÁREA DE DISEÑO";

            this.lblInfoZonaIzq.Dock = DockStyle.Top;
            this.lblInfoZonaIzq.Font = new Font("Segoe UI", 9F);
            this.lblInfoZonaIzq.ForeColor = Color.FromArgb(220, 205, 215);
            this.lblInfoZonaIzq.Height = 115;
            this.lblInfoZonaIzq.Text = "DISTRIBUCIÓN FÍSICA:\n" +
                                       "• 3 Mesas centrales (1 a 3)\n" +
                                       "• 3 Fuentes por mesa (A, B, C)\n" +
                                       "• 4 Asientos por fuente (1 a 4)\n" +
                                       "• Código: 1A1, 2B3, 3C4";

            this.pnlLeyendaLed.BackColor = Color.FromArgb(45, 20, 44);
            this.pnlLeyendaLed.Controls.Add(this.lblLeyendaRojo);
            this.pnlLeyendaLed.Controls.Add(this.ledMuestraRojo);
            this.pnlLeyendaLed.Controls.Add(this.lblLeyendaVerde);
            this.pnlLeyendaLed.Controls.Add(this.ledMuestraVerde);
            this.pnlLeyendaLed.Dock = DockStyle.Bottom;
            this.pnlLeyendaLed.Height = 82;
            this.pnlLeyendaLed.Padding = new Padding(10);

            this.ledMuestraVerde.BackColor = Color.FromArgb(46, 204, 113);
            this.ledMuestraVerde.Location = new Point(12, 14);
            this.ledMuestraVerde.Size = new Size(15, 15);

            this.lblLeyendaVerde.AutoSize = true;
            this.lblLeyendaVerde.Font = new Font("Consolas", 9F, FontStyle.Bold);
            this.lblLeyendaVerde.ForeColor = Color.White;
            this.lblLeyendaVerde.Location = new Point(35, 14);
            this.lblLeyendaVerde.Text = "Lugares libres";

            this.ledMuestraRojo.BackColor = Color.FromArgb(231, 76, 60);
            this.ledMuestraRojo.Location = new Point(12, 48);
            this.ledMuestraRojo.Size = new Size(15, 15);

            this.lblLeyendaRojo.AutoSize = true;
            this.lblLeyendaRojo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            this.lblLeyendaRojo.ForeColor = Color.White;
            this.lblLeyendaRojo.Location = new Point(35, 48);
            this.lblLeyendaRojo.Text = "Fuente llena (4/4)";

            this.picPochaccoFuente.BackColor = Color.FromArgb(81, 10, 50);
            this.picPochaccoFuente.Dock = DockStyle.Fill;
            this.picPochaccoFuente.Name = "picPochaccoFuente";
            this.picPochaccoFuente.Padding = new Padding(4, 8, 4, 8);
            this.picPochaccoFuente.SizeMode = PictureBoxSizeMode.Zoom;

            // ==================== COLUMNA CENTRAL ====================
            this.pnlCentroPlano.Controls.Add(this.gridTresMesas);
            this.pnlCentroPlano.Controls.Add(this.lblTituloPlano);
            this.pnlCentroPlano.Dock = DockStyle.Fill;

            this.lblTituloPlano.Dock = DockStyle.Top;
            this.lblTituloPlano.Font = new Font("Consolas", 12.5F, FontStyle.Bold);
            this.lblTituloPlano.ForeColor = Color.FromArgb(238, 69, 64);
            this.lblTituloPlano.Height = 38;
            this.lblTituloPlano.Text = "LABORATORIO DE ELECTRÓNICA — MAPA DE CONTROL DE MESAS";
            this.lblTituloPlano.TextAlign = ContentAlignment.MiddleCenter;

            this.gridTresMesas.ColumnCount = 1;
            this.gridTresMesas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.gridTresMesas.RowCount = 3;
            this.gridTresMesas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.gridTresMesas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.gridTresMesas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.gridTresMesas.Dock = DockStyle.Fill;

            // ==================== COLUMNA DERECHA ====================
            this.pnlDerechoMonitor.BackColor = Color.FromArgb(81, 10, 50);
            this.pnlDerechoMonitor.Controls.Add(this.pnlListaOcupados);
            this.pnlDerechoMonitor.Controls.Add(this.pnlAsignacionDirecta);
            this.pnlDerechoMonitor.Controls.Add(this.pnlTarjetaHover);
            this.pnlDerechoMonitor.Controls.Add(this.lblTituloMonitor);
            this.pnlDerechoMonitor.Controls.Add(this.pnlZonaInferiorBotones);
            this.pnlDerechoMonitor.Dock = DockStyle.Fill;
            this.pnlDerechoMonitor.Margin = new Padding(12, 0, 0, 0);
            this.pnlDerechoMonitor.Padding = new Padding(15);

            this.lblTituloMonitor.Dock = DockStyle.Top;
            this.lblTituloMonitor.Font = new Font("Consolas", 11.5F, FontStyle.Bold);
            this.lblTituloMonitor.ForeColor = Color.FromArgb(238, 69, 64);
            this.lblTituloMonitor.Height = 32;
            this.lblTituloMonitor.Text = "MONITOR DE ESTACIÓN";

            this.pnlTarjetaHover.BackColor = Color.FromArgb(45, 20, 44);
            this.pnlTarjetaHover.BorderStyle = BorderStyle.FixedSingle;
            this.pnlTarjetaHover.Controls.Add(this.lblEstadoHover);
            this.pnlTarjetaHover.Controls.Add(this.lblLugaresHover);
            this.pnlTarjetaHover.Controls.Add(this.lblEstacionHover);
            this.pnlTarjetaHover.Dock = DockStyle.Top;
            this.pnlTarjetaHover.Height = 115;
            this.pnlTarjetaHover.Padding = new Padding(10);

            this.lblEstacionHover.Dock = DockStyle.Top;
            this.lblEstacionHover.Font = new Font("Consolas", 12F, FontStyle.Bold);
            this.lblEstacionHover.ForeColor = Color.White;
            this.lblEstacionHover.Height = 28;
            this.lblEstacionHover.Text = "Pasa el mouse sobre A, B o C";

            this.lblLugaresHover.Dock = DockStyle.Top;
            this.lblLugaresHover.Font = new Font("Consolas", 11F, FontStyle.Bold);
            this.lblLugaresHover.ForeColor = Color.FromArgb(255, 210, 120);
            this.lblLugaresHover.Height = 26;
            this.lblLugaresHover.Text = "(lugares disponibles: --)";

            this.lblEstadoHover.Dock = DockStyle.Fill;
            this.lblEstadoHover.Font = new Font("Segoe UI", 9F);
            this.lblEstadoHover.ForeColor = Color.FromArgb(200, 190, 205);
            this.lblEstadoHover.Text = "Haz clic en una fuente verde para elegir asiento (1-4).";

            // Panel Central de Configuración (Asiento 1-4 + Tiempo base 2h + Extensión)
            this.pnlAsignacionDirecta.BackColor = Color.FromArgb(62, 14, 45);
            this.pnlAsignacionDirecta.BorderStyle = BorderStyle.FixedSingle;
            this.pnlAsignacionDirecta.Controls.Add(this.lblTotalHoras);
            this.pnlAsignacionDirecta.Controls.Add(this.numHorasExtra);
            this.pnlAsignacionDirecta.Controls.Add(this.chkExtensionTiempo);
            this.pnlAsignacionDirecta.Controls.Add(this.lblTiempoBase);
            this.pnlAsignacionDirecta.Controls.Add(this.cmbAsientoLibre);
            this.pnlAsignacionDirecta.Controls.Add(this.lblAsientoPrompt);
            this.pnlAsignacionDirecta.Controls.Add(this.lblEstacionSeleccionada);
            this.pnlAsignacionDirecta.Controls.Add(this.lblTituloAsignacion);
            this.pnlAsignacionDirecta.Dock = DockStyle.Top;
            this.pnlAsignacionDirecta.Height = 230;
            this.pnlAsignacionDirecta.Padding = new Padding(12);
            this.pnlAsignacionDirecta.Visible = false;

            this.lblTituloAsignacion.Dock = DockStyle.Top;
            this.lblTituloAsignacion.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            this.lblTituloAsignacion.ForeColor = Color.FromArgb(238, 69, 64);
            this.lblTituloAsignacion.Height = 24;
            this.lblTituloAsignacion.Text = "CONFIGURAR ASIENTO Y TIEMPO";

            this.lblEstacionSeleccionada.Dock = DockStyle.Top;
            this.lblEstacionSeleccionada.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblEstacionSeleccionada.ForeColor = Color.White;
            this.lblEstacionSeleccionada.Height = 24;
            this.lblEstacionSeleccionada.Text = "Fuente: --";

            this.lblAsientoPrompt.Dock = DockStyle.Top;
            this.lblAsientoPrompt.Font = new Font("Segoe UI", 9F);
            this.lblAsientoPrompt.ForeColor = Color.FromArgb(225, 210, 220);
            this.lblAsientoPrompt.Height = 20;
            this.lblAsientoPrompt.Text = "Selecciona el asiento disponible (1 a 4):";

            this.cmbAsientoLibre.BackColor = Color.FromArgb(45, 20, 44);
            this.cmbAsientoLibre.Dock = DockStyle.Top;
            this.cmbAsientoLibre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAsientoLibre.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            this.cmbAsientoLibre.ForeColor = Color.White;

            this.lblTiempoBase.Dock = DockStyle.Top;
            this.lblTiempoBase.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblTiempoBase.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblTiempoBase.Height = 26;
            this.lblTiempoBase.Padding = new Padding(0, 5, 0, 0);
            this.lblTiempoBase.Text = "Tiempo mínimo asignado: 2 horas";

            this.chkExtensionTiempo.AutoSize = true;
            this.chkExtensionTiempo.Dock = DockStyle.Top;
            this.chkExtensionTiempo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.chkExtensionTiempo.ForeColor = Color.FromArgb(255, 210, 120);
            this.chkExtensionTiempo.Text = "+ Extensión de tiempo (horas extra)";
            this.chkExtensionTiempo.CheckedChanged += new System.EventHandler(this.chkExtensionTiempo_CheckedChanged);

            this.numHorasExtra.BackColor = Color.FromArgb(45, 20, 44);
            this.numHorasExtra.Dock = DockStyle.Top;
            this.numHorasExtra.Enabled = false;
            this.numHorasExtra.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            this.numHorasExtra.ForeColor = Color.White;
            this.numHorasExtra.Maximum = 4;
            this.numHorasExtra.Minimum = 1;
            this.numHorasExtra.Value = 1;
            this.numHorasExtra.ValueChanged += new System.EventHandler(this.numHorasExtra_ValueChanged);

            this.lblTotalHoras.Dock = DockStyle.Top;
            this.lblTotalHoras.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            this.lblTotalHoras.ForeColor = Color.White;
            this.lblTotalHoras.Height = 24;
            this.lblTotalHoras.Text = "Total tiempo de uso: 2 horas";

            // Panel Lista Ocupados (se muestra cuando se presiona Desocupar Lugar)
            this.pnlListaOcupados.BackColor = Color.FromArgb(45, 20, 44);
            this.pnlListaOcupados.BorderStyle = BorderStyle.FixedSingle;
            this.pnlListaOcupados.Controls.Add(this.lstAsientosOcupados);
            this.pnlListaOcupados.Controls.Add(this.lblTituloOcupados);
            this.pnlListaOcupados.Controls.Add(this.btnLiberarSeleccionado);
            this.pnlListaOcupados.Controls.Add(this.btnCerrarListaOcupados);
            this.pnlListaOcupados.Dock = DockStyle.Fill;
            this.pnlListaOcupados.Padding = new Padding(8);
            this.pnlListaOcupados.Visible = false;

            this.lblTituloOcupados.Dock = DockStyle.Top;
            this.lblTituloOcupados.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            this.lblTituloOcupados.ForeColor = Color.FromArgb(255, 210, 120);
            this.lblTituloOcupados.Height = 22;
            this.lblTituloOcupados.Text = "LUGARES OCUPADOS ACTUALES:";

            this.lstAsientosOcupados.BackColor = Color.FromArgb(62, 14, 45);
            this.lstAsientosOcupados.BorderStyle = BorderStyle.None;
            this.lstAsientosOcupados.Dock = DockStyle.Fill;
            this.lstAsientosOcupados.Font = new Font("Consolas", 9.5F);
            this.lstAsientosOcupados.ForeColor = Color.White;

            this.btnLiberarSeleccionado.BackColor = Color.FromArgb(46, 204, 113);
            this.btnLiberarSeleccionado.Cursor = Cursors.Hand;
            this.btnLiberarSeleccionado.Dock = DockStyle.Bottom;
            this.btnLiberarSeleccionado.FlatAppearance.BorderSize = 0;
            this.btnLiberarSeleccionado.FlatStyle = FlatStyle.Flat;
            this.btnLiberarSeleccionado.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            this.btnLiberarSeleccionado.ForeColor = Color.FromArgb(25, 20, 30);
            this.btnLiberarSeleccionado.Height = 32;
            this.btnLiberarSeleccionado.Text = "✔ LIBERAR SELECCIONADO";
            this.btnLiberarSeleccionado.Click += new System.EventHandler(this.btnLiberarSeleccionado_Click);

            this.btnCerrarListaOcupados.BackColor = Color.FromArgb(95, 15, 38);
            this.btnCerrarListaOcupados.Cursor = Cursors.Hand;
            this.btnCerrarListaOcupados.Dock = DockStyle.Bottom;
            this.btnCerrarListaOcupados.FlatAppearance.BorderSize = 0;
            this.btnCerrarListaOcupados.FlatStyle = FlatStyle.Flat;
            this.btnCerrarListaOcupados.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            this.btnCerrarListaOcupados.ForeColor = Color.White;
            this.btnCerrarListaOcupados.Height = 26;
            this.btnCerrarListaOcupados.Text = "CERRAR LISTA";
            this.btnCerrarListaOcupados.Click += new System.EventHandler(this.btnCerrarListaOcupados_Click);

            // ZONA INFERIOR DERECHA: Botones grandes y siempre visibles arriba de Desocupar Lugar
            this.pnlZonaInferiorBotones.Controls.Add(this.btnConfirmarAsignacion);
            this.pnlZonaInferiorBotones.Controls.Add(this.btnCancelarAsignacion);
            this.pnlZonaInferiorBotones.Controls.Add(this.btnAbrirDesocupar);
            this.pnlZonaInferiorBotones.Dock = DockStyle.Bottom;
            this.pnlZonaInferiorBotones.Height = 138;

            this.btnConfirmarAsignacion.BackColor = Color.FromArgb(46, 204, 113);
            this.btnConfirmarAsignacion.Cursor = Cursors.Hand;
            this.btnConfirmarAsignacion.Dock = DockStyle.Top;
            this.btnConfirmarAsignacion.FlatAppearance.BorderSize = 0;
            this.btnConfirmarAsignacion.FlatStyle = FlatStyle.Flat;
            this.btnConfirmarAsignacion.Font = new Font("Consolas", 11F, FontStyle.Bold);
            this.btnConfirmarAsignacion.ForeColor = Color.FromArgb(20, 20, 25);
            this.btnConfirmarAsignacion.Height = 46;
            this.btnConfirmarAsignacion.Text = "✔ ASIGNAR ASIENTO";
            this.btnConfirmarAsignacion.Visible = false;
            this.btnConfirmarAsignacion.Click += new System.EventHandler(this.btnConfirmarAsignacion_Click);

            this.btnCancelarAsignacion.BackColor = Color.FromArgb(95, 15, 38);
            this.btnCancelarAsignacion.Cursor = Cursors.Hand;
            this.btnCancelarAsignacion.Dock = DockStyle.Top;
            this.btnCancelarAsignacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarAsignacion.FlatStyle = FlatStyle.Flat;
            this.btnCancelarAsignacion.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            this.btnCancelarAsignacion.ForeColor = Color.FromArgb(255, 180, 180);
            this.btnCancelarAsignacion.Height = 30;
            this.btnCancelarAsignacion.Text = "CANCELAR ASIGNACIÓN";
            this.btnCancelarAsignacion.Visible = false;
            this.btnCancelarAsignacion.Click += new System.EventHandler(this.btnCancelarAsignacion_Click);

            this.btnAbrirDesocupar.BackColor = Color.FromArgb(199, 44, 65);
            this.btnAbrirDesocupar.Cursor = Cursors.Hand;
            this.btnAbrirDesocupar.Dock = DockStyle.Bottom;
            this.btnAbrirDesocupar.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            this.btnAbrirDesocupar.FlatAppearance.BorderSize = 1;
            this.btnAbrirDesocupar.FlatStyle = FlatStyle.Flat;
            this.btnAbrirDesocupar.Font = new Font("Consolas", 11F, FontStyle.Bold);
            this.btnAbrirDesocupar.ForeColor = Color.White;
            this.btnAbrirDesocupar.Height = 48;
            this.btnAbrirDesocupar.Text = "DESOCUPAR LUGAR";
            this.btnAbrirDesocupar.Click += new System.EventHandler(this.btnAbrirDesocupar_Click);

            // UCMESAS
            this.BackColor = Color.FromArgb(45, 20, 44);
            this.Controls.Add(this.layoutPrincipalMesas);
            this.Name = "UcMesas";
            this.Size = new Size(1280, 655);

            ((System.ComponentModel.ISupportInitialize)(this.picPochaccoFuente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtra)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}