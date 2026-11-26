using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    partial class UcPrestamo
    {
        #region Atributos del Diseñador
        private System.ComponentModel.IContainer components = null;

        private Panel pnlSelectorCategorias;
        private TableLayoutPanel layoutCatalogoCompleto;
        private Panel pnlZonaTarjetas;
        private Label lblTituloCategorias;
        private TableLayoutPanel gridCategorias;

        private Panel pnlPanelLateralInfo;
        public PictureBox picDecoracionOsciloscopio;
        private Label lblTituloGuia;
        private Panel pnlSeparadorGuia;
        private Label lblResumenRapidoCarrito;
        private Label lblReglasLaboratorio;
        private Button btnIrAPedidoDesdeCat;

        private Panel cardMultimetros;
        public PictureBox picMultimetros;
        private Button btnCatMultimetros;

        private Panel cardResistencias;
        public PictureBox picResistencias;
        private Button btnCatResistencias;

        private Panel cardCapacitores;
        public PictureBox picCapacitores;
        private Button btnCatCapacitores;

        private Panel cardCables;
        public PictureBox picCables;
        private Button btnCatCables;

        private Panel cardProtoboard;
        public PictureBox picProtoboard;
        private Button btnCatProtoboard;

        private Panel cardPinzas;
        public PictureBox picPinzas;
        private Button btnCatPinzas;

        private Panel pnlOperacionPrestamo;
        private TableLayoutPanel layoutTablaCarrito;
        private Panel pnlIzquierdoTabla;
        private Panel pnlHeaderTabla;
        private Button btnVolverCategorias;
        private PictureBox picIconoCategoriaActual;
        private Label lblNombreCategoriaActual;
        private TextBox txtBuscarMaterial;

        private Panel pnlBannerInstruccion;
        public PictureBox picLaboratoristaGuia;
        private Label lblTextoInstruccionTabla;

        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colDisponible;
        private DataGridViewTextBoxColumn colCantidad;
        private Button btnAgregarCarrito;

        private Panel pnlDerechoCarrito;
        private Label lblTituloCarrito;
        private Label lblMesaActualBadge;
        private ListBox lstCarritoVivo;
        private Panel pnlCupoCategoria;
        private Label lblCupoCategoria;
        private ProgressBar pbCupoCategoria;
        private Button btnIrAsignarMesa;
        private Button btnVaciarCarrito;
        private Button btnConfirmarYRegistrar;

        private Panel pnlTicketFinal;
        private TableLayoutPanel layoutCentradorTicket;
        private Panel pnlTarjetaTicket;
        private Label lblTituloTicket;
        private ListBox lstTicketImpreso;
        private Button btnFinalizarSiguienteAlumno;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPrestamo));
            pnlSelectorCategorias = new Panel();
            layoutCatalogoCompleto = new TableLayoutPanel();
            pnlZonaTarjetas = new Panel();
            gridCategorias = new TableLayoutPanel();
            cardMultimetros = new Panel();
            picMultimetros = new PictureBox();
            btnCatMultimetros = new Button();
            cardResistencias = new Panel();
            picResistencias = new PictureBox();
            btnCatResistencias = new Button();
            cardCapacitores = new Panel();
            picCapacitores = new PictureBox();
            btnCatCapacitores = new Button();
            cardCables = new Panel();
            picCables = new PictureBox();
            btnCatCables = new Button();
            cardProtoboard = new Panel();
            picProtoboard = new PictureBox();
            btnCatProtoboard = new Button();
            cardPinzas = new Panel();
            picPinzas = new PictureBox();
            btnCatPinzas = new Button();
            lblTituloCategorias = new Label();
            pnlPanelLateralInfo = new Panel();
            lblReglasLaboratorio = new Label();
            lblResumenRapidoCarrito = new Label();
            pnlSeparadorGuia = new Panel();
            lblTituloGuia = new Label();
            picDecoracionOsciloscopio = new PictureBox();
            btnIrAPedidoDesdeCat = new Button();
            pnlOperacionPrestamo = new Panel();
            layoutTablaCarrito = new TableLayoutPanel();
            pnlIzquierdoTabla = new Panel();
            dgvInventario = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colMaterial = new DataGridViewTextBoxColumn();
            colDisponible = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            pnlBannerInstruccion = new Panel();
            lblTextoInstruccionTabla = new Label();
            picLaboratoristaGuia = new PictureBox();
            pnlHeaderTabla = new Panel();
            txtBuscarMaterial = new TextBox();
            lblNombreCategoriaActual = new Label();
            picIconoCategoriaActual = new PictureBox();
            btnVolverCategorias = new Button();
            btnAgregarCarrito = new Button();
            pnlDerechoCarrito = new Panel();
            lstCarritoVivo = new ListBox();
            lblMesaActualBadge = new Label();
            lblTituloCarrito = new Label();
            pnlCupoCategoria = new Panel();
            pbCupoCategoria = new ProgressBar();
            lblCupoCategoria = new Label();
            btnIrAsignarMesa = new Button();
            btnVaciarCarrito = new Button();
            btnConfirmarYRegistrar = new Button();
            pnlTicketFinal = new Panel();
            layoutCentradorTicket = new TableLayoutPanel();
            pnlTarjetaTicket = new Panel();
            lstTicketImpreso = new ListBox();
            lblTituloTicket = new Label();
            btnFinalizarSiguienteAlumno = new Button();
            pnlSelectorCategorias.SuspendLayout();
            layoutCatalogoCompleto.SuspendLayout();
            pnlZonaTarjetas.SuspendLayout();
            gridCategorias.SuspendLayout();
            cardMultimetros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMultimetros).BeginInit();
            cardResistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picResistencias).BeginInit();
            cardCapacitores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCapacitores).BeginInit();
            cardCables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCables).BeginInit();
            cardProtoboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProtoboard).BeginInit();
            cardPinzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPinzas).BeginInit();
            pnlPanelLateralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDecoracionOsciloscopio).BeginInit();
            pnlOperacionPrestamo.SuspendLayout();
            layoutTablaCarrito.SuspendLayout();
            pnlIzquierdoTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            pnlBannerInstruccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLaboratoristaGuia).BeginInit();
            pnlHeaderTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconoCategoriaActual).BeginInit();
            pnlDerechoCarrito.SuspendLayout();
            pnlCupoCategoria.SuspendLayout();
            pnlTicketFinal.SuspendLayout();
            layoutCentradorTicket.SuspendLayout();
            pnlTarjetaTicket.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSelectorCategorias
            // 
            pnlSelectorCategorias.Controls.Add(layoutCatalogoCompleto);
            pnlSelectorCategorias.Dock = DockStyle.Fill;
            pnlSelectorCategorias.Location = new Point(0, 0);
            pnlSelectorCategorias.Name = "pnlSelectorCategorias";
            pnlSelectorCategorias.Padding = new Padding(25, 20, 25, 20);
            pnlSelectorCategorias.Size = new Size(1280, 655);
            pnlSelectorCategorias.TabIndex = 0;
            // 
            // layoutCatalogoCompleto
            // 
            layoutCatalogoCompleto.ColumnCount = 2;
            layoutCatalogoCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72F));
            layoutCatalogoCompleto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            layoutCatalogoCompleto.Controls.Add(pnlZonaTarjetas, 0, 0);
            layoutCatalogoCompleto.Controls.Add(pnlPanelLateralInfo, 1, 0);
            layoutCatalogoCompleto.Dock = DockStyle.Fill;
            layoutCatalogoCompleto.Location = new Point(25, 20);
            layoutCatalogoCompleto.Name = "layoutCatalogoCompleto";
            layoutCatalogoCompleto.RowCount = 1;
            layoutCatalogoCompleto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutCatalogoCompleto.Size = new Size(1230, 615);
            layoutCatalogoCompleto.TabIndex = 0;
            // 
            // pnlZonaTarjetas
            // 
            pnlZonaTarjetas.Controls.Add(gridCategorias);
            pnlZonaTarjetas.Controls.Add(lblTituloCategorias);
            pnlZonaTarjetas.Dock = DockStyle.Fill;
            pnlZonaTarjetas.Location = new Point(3, 3);
            pnlZonaTarjetas.Name = "pnlZonaTarjetas";
            pnlZonaTarjetas.Padding = new Padding(0, 0, 15, 0);
            pnlZonaTarjetas.Size = new Size(879, 609);
            pnlZonaTarjetas.TabIndex = 0;
            // 
            // gridCategorias
            // 
            gridCategorias.ColumnCount = 3;
            gridCategorias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            gridCategorias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            gridCategorias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            gridCategorias.Controls.Add(cardMultimetros, 0, 0);
            gridCategorias.Controls.Add(cardResistencias, 1, 0);
            gridCategorias.Controls.Add(cardCapacitores, 2, 0);
            gridCategorias.Controls.Add(cardCables, 0, 1);
            gridCategorias.Controls.Add(cardProtoboard, 1, 1);
            gridCategorias.Controls.Add(cardPinzas, 2, 1);
            gridCategorias.Dock = DockStyle.Fill;
            gridCategorias.Location = new Point(0, 42);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.RowCount = 2;
            gridCategorias.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridCategorias.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridCategorias.Size = new Size(864, 567);
            gridCategorias.TabIndex = 0;
            // 
            // cardMultimetros
            // 
            cardMultimetros.BackColor = Color.FromArgb(81, 10, 50);
            cardMultimetros.Controls.Add(picMultimetros);
            cardMultimetros.Controls.Add(btnCatMultimetros);
            cardMultimetros.Dock = DockStyle.Fill;
            cardMultimetros.Location = new Point(10, 10);
            cardMultimetros.Margin = new Padding(10);
            cardMultimetros.Name = "cardMultimetros";
            cardMultimetros.Padding = new Padding(12);
            cardMultimetros.Size = new Size(268, 263);
            cardMultimetros.TabIndex = 0;
            // 
            // picMultimetros
            // 
            picMultimetros.BackColor = Color.FromArgb(45, 20, 44);
            picMultimetros.BorderStyle = BorderStyle.FixedSingle;
            picMultimetros.Dock = DockStyle.Fill;
            picMultimetros.Location = new Point(12, 12);
            picMultimetros.Name = "picMultimetros";
            picMultimetros.Size = new Size(244, 197);
            picMultimetros.SizeMode = PictureBoxSizeMode.Zoom;
            picMultimetros.TabIndex = 0;
            picMultimetros.TabStop = false;
            // 
            // btnCatMultimetros
            // 
            btnCatMultimetros.BackColor = Color.FromArgb(199, 44, 65);
            btnCatMultimetros.Cursor = Cursors.Hand;
            btnCatMultimetros.Dock = DockStyle.Bottom;
            btnCatMultimetros.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnCatMultimetros.FlatStyle = FlatStyle.Flat;
            btnCatMultimetros.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnCatMultimetros.ForeColor = Color.White;
            btnCatMultimetros.Location = new Point(12, 209);
            btnCatMultimetros.Name = "btnCatMultimetros";
            btnCatMultimetros.Size = new Size(244, 42);
            btnCatMultimetros.TabIndex = 1;
            btnCatMultimetros.Tag = "Multímetros";
            btnCatMultimetros.Text = "MULTÍMETROS";
            btnCatMultimetros.UseVisualStyleBackColor = false;
            btnCatMultimetros.Click += BtnCategoria_Click;
            // 
            // cardResistencias
            // 
            cardResistencias.BackColor = Color.FromArgb(81, 10, 50);
            cardResistencias.Controls.Add(picResistencias);
            cardResistencias.Controls.Add(btnCatResistencias);
            cardResistencias.Dock = DockStyle.Fill;
            cardResistencias.Location = new Point(298, 10);
            cardResistencias.Margin = new Padding(10);
            cardResistencias.Name = "cardResistencias";
            cardResistencias.Padding = new Padding(12);
            cardResistencias.Size = new Size(268, 263);
            cardResistencias.TabIndex = 1;
            // 
            // picResistencias
            // 
            picResistencias.BackColor = Color.FromArgb(45, 20, 44);
            picResistencias.BorderStyle = BorderStyle.FixedSingle;
            picResistencias.Dock = DockStyle.Fill;
            picResistencias.Location = new Point(12, 12);
            picResistencias.Name = "picResistencias";
            picResistencias.Size = new Size(244, 197);
            picResistencias.SizeMode = PictureBoxSizeMode.Zoom;
            picResistencias.TabIndex = 0;
            picResistencias.TabStop = false;
            // 
            // btnCatResistencias
            // 
            btnCatResistencias.BackColor = Color.FromArgb(199, 44, 65);
            btnCatResistencias.Cursor = Cursors.Hand;
            btnCatResistencias.Dock = DockStyle.Bottom;
            btnCatResistencias.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnCatResistencias.FlatStyle = FlatStyle.Flat;
            btnCatResistencias.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnCatResistencias.ForeColor = Color.White;
            btnCatResistencias.Location = new Point(12, 209);
            btnCatResistencias.Name = "btnCatResistencias";
            btnCatResistencias.Size = new Size(244, 42);
            btnCatResistencias.TabIndex = 1;
            btnCatResistencias.Tag = "Resistencias";
            btnCatResistencias.Text = "RESISTENCIAS";
            btnCatResistencias.UseVisualStyleBackColor = false;
            btnCatResistencias.Click += BtnCategoria_Click;
            // 
            // cardCapacitores
            // 
            cardCapacitores.BackColor = Color.FromArgb(81, 10, 50);
            cardCapacitores.Controls.Add(picCapacitores);
            cardCapacitores.Controls.Add(btnCatCapacitores);
            cardCapacitores.Dock = DockStyle.Fill;
            cardCapacitores.Location = new Point(586, 10);
            cardCapacitores.Margin = new Padding(10);
            cardCapacitores.Name = "cardCapacitores";
            cardCapacitores.Padding = new Padding(12);
            cardCapacitores.Size = new Size(268, 263);
            cardCapacitores.TabIndex = 2;
            // 
            // picCapacitores
            // 
            picCapacitores.BackColor = Color.FromArgb(45, 20, 44);
            picCapacitores.BorderStyle = BorderStyle.FixedSingle;
            picCapacitores.Dock = DockStyle.Fill;
            picCapacitores.Location = new Point(12, 12);
            picCapacitores.Name = "picCapacitores";
            picCapacitores.Size = new Size(244, 197);
            picCapacitores.SizeMode = PictureBoxSizeMode.Zoom;
            picCapacitores.TabIndex = 0;
            picCapacitores.TabStop = false;
            // 
            // btnCatCapacitores
            // 
            btnCatCapacitores.BackColor = Color.FromArgb(199, 44, 65);
            btnCatCapacitores.Cursor = Cursors.Hand;
            btnCatCapacitores.Dock = DockStyle.Bottom;
            btnCatCapacitores.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnCatCapacitores.FlatStyle = FlatStyle.Flat;
            btnCatCapacitores.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnCatCapacitores.ForeColor = Color.White;
            btnCatCapacitores.Location = new Point(12, 209);
            btnCatCapacitores.Name = "btnCatCapacitores";
            btnCatCapacitores.Size = new Size(244, 42);
            btnCatCapacitores.TabIndex = 1;
            btnCatCapacitores.Tag = "Capacitores";
            btnCatCapacitores.Text = "CAPACITORES";
            btnCatCapacitores.UseVisualStyleBackColor = false;
            btnCatCapacitores.Click += BtnCategoria_Click;
            // 
            // cardCables
            // 
            cardCables.BackColor = Color.FromArgb(81, 10, 50);
            cardCables.Controls.Add(picCables);
            cardCables.Controls.Add(btnCatCables);
            cardCables.Dock = DockStyle.Fill;
            cardCables.Location = new Point(10, 293);
            cardCables.Margin = new Padding(10);
            cardCables.Name = "cardCables";
            cardCables.Padding = new Padding(12);
            cardCables.Size = new Size(268, 264);
            cardCables.TabIndex = 3;
            // 
            // picCables
            // 
            picCables.BackColor = Color.FromArgb(45, 20, 44);
            picCables.BorderStyle = BorderStyle.FixedSingle;
            picCables.Dock = DockStyle.Fill;
            picCables.Location = new Point(12, 12);
            picCables.Name = "picCables";
            picCables.Size = new Size(244, 198);
            picCables.SizeMode = PictureBoxSizeMode.Zoom;
            picCables.TabIndex = 0;
            picCables.TabStop = false;
            // 
            // btnCatCables
            // 
            btnCatCables.BackColor = Color.FromArgb(199, 44, 65);
            btnCatCables.Cursor = Cursors.Hand;
            btnCatCables.Dock = DockStyle.Bottom;
            btnCatCables.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnCatCables.FlatStyle = FlatStyle.Flat;
            btnCatCables.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnCatCables.ForeColor = Color.White;
            btnCatCables.Location = new Point(12, 210);
            btnCatCables.Name = "btnCatCables";
            btnCatCables.Size = new Size(244, 42);
            btnCatCables.TabIndex = 1;
            btnCatCables.Tag = "Cables";
            btnCatCables.Text = "CABLES";
            btnCatCables.UseVisualStyleBackColor = false;
            btnCatCables.Click += BtnCategoria_Click;
            // 
            // cardProtoboard
            // 
            cardProtoboard.BackColor = Color.FromArgb(81, 10, 50);
            cardProtoboard.Controls.Add(picProtoboard);
            cardProtoboard.Controls.Add(btnCatProtoboard);
            cardProtoboard.Dock = DockStyle.Fill;
            cardProtoboard.Location = new Point(298, 293);
            cardProtoboard.Margin = new Padding(10);
            cardProtoboard.Name = "cardProtoboard";
            cardProtoboard.Padding = new Padding(12);
            cardProtoboard.Size = new Size(268, 264);
            cardProtoboard.TabIndex = 4;
            // 
            // picProtoboard
            // 
            picProtoboard.BackColor = Color.FromArgb(45, 20, 44);
            picProtoboard.BorderStyle = BorderStyle.FixedSingle;
            picProtoboard.Dock = DockStyle.Fill;
            picProtoboard.Location = new Point(12, 12);
            picProtoboard.Name = "picProtoboard";
            picProtoboard.Size = new Size(244, 198);
            picProtoboard.SizeMode = PictureBoxSizeMode.Zoom;
            picProtoboard.TabIndex = 0;
            picProtoboard.TabStop = false;
            // 
            // btnCatProtoboard
            // 
            btnCatProtoboard.BackColor = Color.FromArgb(199, 44, 65);
            btnCatProtoboard.Cursor = Cursors.Hand;
            btnCatProtoboard.Dock = DockStyle.Bottom;
            btnCatProtoboard.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnCatProtoboard.FlatStyle = FlatStyle.Flat;
            btnCatProtoboard.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnCatProtoboard.ForeColor = Color.White;
            btnCatProtoboard.Location = new Point(12, 210);
            btnCatProtoboard.Name = "btnCatProtoboard";
            btnCatProtoboard.Size = new Size(244, 42);
            btnCatProtoboard.TabIndex = 1;
            btnCatProtoboard.Tag = "Protoboard";
            btnCatProtoboard.Text = "PROTOBOARD";
            btnCatProtoboard.UseVisualStyleBackColor = false;
            btnCatProtoboard.Click += BtnCategoria_Click;
            // 
            // cardPinzas
            // 
            cardPinzas.BackColor = Color.FromArgb(81, 10, 50);
            cardPinzas.Controls.Add(picPinzas);
            cardPinzas.Controls.Add(btnCatPinzas);
            cardPinzas.Dock = DockStyle.Fill;
            cardPinzas.Location = new Point(586, 293);
            cardPinzas.Margin = new Padding(10);
            cardPinzas.Name = "cardPinzas";
            cardPinzas.Padding = new Padding(12);
            cardPinzas.Size = new Size(268, 264);
            cardPinzas.TabIndex = 5;
            // 
            // picPinzas
            // 
            picPinzas.BackColor = Color.FromArgb(45, 20, 44);
            picPinzas.BorderStyle = BorderStyle.FixedSingle;
            picPinzas.Dock = DockStyle.Fill;
            picPinzas.Location = new Point(12, 12);
            picPinzas.Name = "picPinzas";
            picPinzas.Size = new Size(244, 198);
            picPinzas.SizeMode = PictureBoxSizeMode.Zoom;
            picPinzas.TabIndex = 0;
            picPinzas.TabStop = false;
            // 
            // btnCatPinzas
            // 
            btnCatPinzas.BackColor = Color.FromArgb(199, 44, 65);
            btnCatPinzas.Cursor = Cursors.Hand;
            btnCatPinzas.Dock = DockStyle.Bottom;
            btnCatPinzas.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnCatPinzas.FlatStyle = FlatStyle.Flat;
            btnCatPinzas.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnCatPinzas.ForeColor = Color.White;
            btnCatPinzas.Location = new Point(12, 210);
            btnCatPinzas.Name = "btnCatPinzas";
            btnCatPinzas.Size = new Size(244, 42);
            btnCatPinzas.TabIndex = 1;
            btnCatPinzas.Tag = "Pinzas";
            btnCatPinzas.Text = "PINZAS";
            btnCatPinzas.UseVisualStyleBackColor = false;
            btnCatPinzas.Click += BtnCategoria_Click;
            // 
            // lblTituloCategorias
            // 
            lblTituloCategorias.Dock = DockStyle.Top;
            lblTituloCategorias.Font = new Font("Consolas", 13.5F, FontStyle.Bold);
            lblTituloCategorias.ForeColor = Color.FromArgb(238, 69, 64);
            lblTituloCategorias.Location = new Point(0, 0);
            lblTituloCategorias.Name = "lblTituloCategorias";
            lblTituloCategorias.Size = new Size(864, 42);
            lblTituloCategorias.TabIndex = 1;
            lblTituloCategorias.Text = "SELECCIONA UNA CATEGORÍA DE MATERIAL";
            lblTituloCategorias.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPanelLateralInfo
            // 
            pnlPanelLateralInfo.BackColor = Color.FromArgb(81, 10, 50);
            pnlPanelLateralInfo.Controls.Add(lblReglasLaboratorio);
            pnlPanelLateralInfo.Controls.Add(lblResumenRapidoCarrito);
            pnlPanelLateralInfo.Controls.Add(pnlSeparadorGuia);
            pnlPanelLateralInfo.Controls.Add(lblTituloGuia);
            pnlPanelLateralInfo.Controls.Add(picDecoracionOsciloscopio);
            pnlPanelLateralInfo.Controls.Add(btnIrAPedidoDesdeCat);
            pnlPanelLateralInfo.Dock = DockStyle.Fill;
            pnlPanelLateralInfo.Location = new Point(895, 42);
            pnlPanelLateralInfo.Margin = new Padding(10, 42, 0, 10);
            pnlPanelLateralInfo.Name = "pnlPanelLateralInfo";
            pnlPanelLateralInfo.Padding = new Padding(20);
            pnlPanelLateralInfo.Size = new Size(335, 563);
            pnlPanelLateralInfo.TabIndex = 1;
            // 
            // lblReglasLaboratorio
            // 
            lblReglasLaboratorio.Dock = DockStyle.Fill;
            lblReglasLaboratorio.Font = new Font("Segoe UI", 10F);
            lblReglasLaboratorio.ForeColor = Color.FromArgb(225, 210, 218);
            lblReglasLaboratorio.Location = new Point(20, 252);
            lblReglasLaboratorio.Name = "lblReglasLaboratorio";
            lblReglasLaboratorio.Padding = new Padding(0, 12, 0, 10);
            lblReglasLaboratorio.Size = new Size(295, 243);
            lblReglasLaboratorio.TabIndex = 0;
            lblReglasLaboratorio.Text = "Explora las categorías y dinos qué necesitas para tu práctica.\n\nPuedes seleccionar piezas de distintas categorías en un mismo pedido y asignar tu mesa de trabajo.";
            // 
            // lblResumenRapidoCarrito
            // 
            lblResumenRapidoCarrito.Dock = DockStyle.Top;
            lblResumenRapidoCarrito.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblResumenRapidoCarrito.ForeColor = Color.FromArgb(255, 210, 120);
            lblResumenRapidoCarrito.Location = new Point(20, 197);
            lblResumenRapidoCarrito.Name = "lblResumenRapidoCarrito";
            lblResumenRapidoCarrito.Padding = new Padding(0, 10, 0, 0);
            lblResumenRapidoCarrito.Size = new Size(295, 55);
            lblResumenRapidoCarrito.TabIndex = 1;
            lblResumenRapidoCarrito.Text = "• Piezas en carrito: 0\n• Mesa: Sin mesa asignada";
            // 
            // pnlSeparadorGuia
            // 
            pnlSeparadorGuia.BackColor = Color.FromArgb(128, 19, 54);
            pnlSeparadorGuia.Dock = DockStyle.Top;
            pnlSeparadorGuia.Location = new Point(20, 195);
            pnlSeparadorGuia.Name = "pnlSeparadorGuia";
            pnlSeparadorGuia.Size = new Size(295, 2);
            pnlSeparadorGuia.TabIndex = 2;
            // 
            // lblTituloGuia
            // 
            lblTituloGuia.Dock = DockStyle.Top;
            lblTituloGuia.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblTituloGuia.ForeColor = Color.FromArgb(238, 69, 64);
            lblTituloGuia.Location = new Point(20, 160);
            lblTituloGuia.Name = "lblTituloGuia";
            lblTituloGuia.Size = new Size(295, 35);
            lblTituloGuia.TabIndex = 3;
            lblTituloGuia.Text = "MONITOR DE VENTANILLA";
            lblTituloGuia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picDecoracionOsciloscopio
            // 
            picDecoracionOsciloscopio.BackColor = Color.FromArgb(81, 10, 50);
            picDecoracionOsciloscopio.Dock = DockStyle.Top;
            picDecoracionOsciloscopio.Location = new Point(20, 20);
            picDecoracionOsciloscopio.Name = "picDecoracionOsciloscopio";
            picDecoracionOsciloscopio.Size = new Size(295, 140);
            picDecoracionOsciloscopio.SizeMode = PictureBoxSizeMode.Zoom;
            picDecoracionOsciloscopio.TabIndex = 4;
            picDecoracionOsciloscopio.TabStop = false;
            // 
            // btnIrAPedidoDesdeCat
            // 
            btnIrAPedidoDesdeCat.BackColor = Color.FromArgb(199, 44, 65);
            btnIrAPedidoDesdeCat.Cursor = Cursors.Hand;
            btnIrAPedidoDesdeCat.Dock = DockStyle.Bottom;
            btnIrAPedidoDesdeCat.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnIrAPedidoDesdeCat.FlatStyle = FlatStyle.Flat;
            btnIrAPedidoDesdeCat.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            btnIrAPedidoDesdeCat.ForeColor = Color.White;
            btnIrAPedidoDesdeCat.Location = new Point(20, 495);
            btnIrAPedidoDesdeCat.Name = "btnIrAPedidoDesdeCat";
            btnIrAPedidoDesdeCat.Size = new Size(295, 48);
            btnIrAPedidoDesdeCat.TabIndex = 5;
            btnIrAPedidoDesdeCat.Text = "\U0001f6d2 IR AL CARRITO ACTUAL →";
            btnIrAPedidoDesdeCat.UseVisualStyleBackColor = false;
            btnIrAPedidoDesdeCat.Click += btnIrAPedidoDesdeCat_Click;
            // 
            // pnlOperacionPrestamo
            // 
            pnlOperacionPrestamo.Controls.Add(layoutTablaCarrito);
            pnlOperacionPrestamo.Dock = DockStyle.Fill;
            pnlOperacionPrestamo.Location = new Point(0, 0);
            pnlOperacionPrestamo.Name = "pnlOperacionPrestamo";
            pnlOperacionPrestamo.Padding = new Padding(25);
            pnlOperacionPrestamo.Size = new Size(1280, 655);
            pnlOperacionPrestamo.TabIndex = 1;
            pnlOperacionPrestamo.Visible = false;
            // 
            // layoutTablaCarrito
            // 
            layoutTablaCarrito.ColumnCount = 2;
            layoutTablaCarrito.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            layoutTablaCarrito.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            layoutTablaCarrito.Controls.Add(pnlIzquierdoTabla, 0, 0);
            layoutTablaCarrito.Controls.Add(pnlDerechoCarrito, 1, 0);
            layoutTablaCarrito.Dock = DockStyle.Fill;
            layoutTablaCarrito.Location = new Point(25, 25);
            layoutTablaCarrito.Name = "layoutTablaCarrito";
            layoutTablaCarrito.RowCount = 1;
            layoutTablaCarrito.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTablaCarrito.Size = new Size(1230, 605);
            layoutTablaCarrito.TabIndex = 0;
            // 
            // pnlIzquierdoTabla
            // 
            pnlIzquierdoTabla.Controls.Add(dgvInventario);
            pnlIzquierdoTabla.Controls.Add(pnlBannerInstruccion);
            pnlIzquierdoTabla.Controls.Add(pnlHeaderTabla);
            pnlIzquierdoTabla.Controls.Add(btnAgregarCarrito);
            pnlIzquierdoTabla.Dock = DockStyle.Fill;
            pnlIzquierdoTabla.Location = new Point(3, 3);
            pnlIzquierdoTabla.Name = "pnlIzquierdoTabla";
            pnlIzquierdoTabla.Padding = new Padding(0, 0, 15, 0);
            pnlIzquierdoTabla.Size = new Size(781, 599);
            pnlIzquierdoTabla.TabIndex = 0;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.FromArgb(81, 10, 50);
            dgvInventario.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 19, 54);
            dataGridViewCellStyle1.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colId, colMaterial, colDisponible, colCantidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 10, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(199, 44, 65);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.Font = new Font("Segoe UI", 11F);
            dgvInventario.GridColor = Color.FromArgb(45, 20, 44);
            dgvInventario.Location = new Point(0, 155);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowTemplate.Height = 36;
            dgvInventario.Size = new Size(766, 396);
            dgvInventario.TabIndex = 0;
            // 
            // colId
            // 
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colMaterial
            // 
            colMaterial.FillWeight = 55F;
            colMaterial.HeaderText = "Material / Instrumento";
            colMaterial.Name = "colMaterial";
            colMaterial.ReadOnly = true;
            // 
            // colDisponible
            // 
            colDisponible.FillWeight = 20F;
            colDisponible.HeaderText = "Disponible";
            colDisponible.Name = "colDisponible";
            colDisponible.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.FillWeight = 25F;
            colCantidad.HeaderText = "Cantidad a pedir";
            colCantidad.Name = "colCantidad";
            // 
            // pnlBannerInstruccion
            // 
            pnlBannerInstruccion.BackColor = Color.FromArgb(81, 10, 50);
            pnlBannerInstruccion.Controls.Add(lblTextoInstruccionTabla);
            pnlBannerInstruccion.Controls.Add(picLaboratoristaGuia);
            pnlBannerInstruccion.Dock = DockStyle.Top;
            pnlBannerInstruccion.Location = new Point(0, 60);
            pnlBannerInstruccion.Name = "pnlBannerInstruccion";
            pnlBannerInstruccion.Padding = new Padding(10, 6, 15, 6);
            pnlBannerInstruccion.Size = new Size(766, 95);
            pnlBannerInstruccion.TabIndex = 1;
            // 
            // lblTextoInstruccionTabla
            // 
            lblTextoInstruccionTabla.Dock = DockStyle.Fill;
            lblTextoInstruccionTabla.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            lblTextoInstruccionTabla.ForeColor = Color.FromArgb(255, 225, 160);
            lblTextoInstruccionTabla.Location = new Point(95, 6);
            lblTextoInstruccionTabla.Name = "lblTextoInstruccionTabla";
            lblTextoInstruccionTabla.Padding = new Padding(12, 0, 0, 0);
            lblTextoInstruccionTabla.Size = new Size(656, 83);
            lblTextoInstruccionTabla.TabIndex = 0;
            lblTextoInstruccionTabla.Text = resources.GetString("lblTextoInstruccionTabla.Text");
            lblTextoInstruccionTabla.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picLaboratoristaGuia
            // 
            picLaboratoristaGuia.BackColor = Color.FromArgb(81, 10, 50);
            picLaboratoristaGuia.Dock = DockStyle.Left;
            picLaboratoristaGuia.Location = new Point(10, 6);
            picLaboratoristaGuia.Name = "picLaboratoristaGuia";
            picLaboratoristaGuia.Size = new Size(85, 83);
            picLaboratoristaGuia.SizeMode = PictureBoxSizeMode.Zoom;
            picLaboratoristaGuia.TabIndex = 1;
            picLaboratoristaGuia.TabStop = false;
            // 
            // pnlHeaderTabla
            // 
            pnlHeaderTabla.Controls.Add(txtBuscarMaterial);
            pnlHeaderTabla.Controls.Add(lblNombreCategoriaActual);
            pnlHeaderTabla.Controls.Add(picIconoCategoriaActual);
            pnlHeaderTabla.Controls.Add(btnVolverCategorias);
            pnlHeaderTabla.Dock = DockStyle.Top;
            pnlHeaderTabla.Location = new Point(0, 0);
            pnlHeaderTabla.Name = "pnlHeaderTabla";
            pnlHeaderTabla.Size = new Size(766, 60);
            pnlHeaderTabla.TabIndex = 2;
            // 
            // txtBuscarMaterial
            // 
            txtBuscarMaterial.BackColor = Color.FromArgb(81, 10, 50);
            txtBuscarMaterial.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarMaterial.Dock = DockStyle.Right;
            txtBuscarMaterial.Font = new Font("Segoe UI", 11F);
            txtBuscarMaterial.ForeColor = Color.White;
            txtBuscarMaterial.Location = new Point(546, 0);
            txtBuscarMaterial.Name = "txtBuscarMaterial";
            txtBuscarMaterial.PlaceholderText = "🔍 Buscar material...";
            txtBuscarMaterial.Size = new Size(220, 27);
            txtBuscarMaterial.TabIndex = 0;
            txtBuscarMaterial.TextChanged += txtBuscarMaterial_TextChanged;
            // 
            // lblNombreCategoriaActual
            // 
            lblNombreCategoriaActual.AutoSize = true;
            lblNombreCategoriaActual.Dock = DockStyle.Left;
            lblNombreCategoriaActual.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblNombreCategoriaActual.ForeColor = Color.FromArgb(238, 69, 64);
            lblNombreCategoriaActual.Location = new Point(200, 0);
            lblNombreCategoriaActual.Name = "lblNombreCategoriaActual";
            lblNombreCategoriaActual.Padding = new Padding(10, 14, 0, 0);
            lblNombreCategoriaActual.Size = new Size(154, 40);
            lblNombreCategoriaActual.TabIndex = 1;
            lblNombreCategoriaActual.Text = "MULTÍMETROS";
            // 
            // picIconoCategoriaActual
            // 
            picIconoCategoriaActual.Dock = DockStyle.Left;
            picIconoCategoriaActual.Location = new Point(145, 0);
            picIconoCategoriaActual.Name = "picIconoCategoriaActual";
            picIconoCategoriaActual.Size = new Size(55, 60);
            picIconoCategoriaActual.SizeMode = PictureBoxSizeMode.Zoom;
            picIconoCategoriaActual.TabIndex = 2;
            picIconoCategoriaActual.TabStop = false;
            // 
            // btnVolverCategorias
            // 
            btnVolverCategorias.BackColor = Color.FromArgb(128, 19, 54);
            btnVolverCategorias.Cursor = Cursors.Hand;
            btnVolverCategorias.Dock = DockStyle.Left;
            btnVolverCategorias.FlatAppearance.BorderColor = Color.FromArgb(199, 44, 65);
            btnVolverCategorias.FlatStyle = FlatStyle.Flat;
            btnVolverCategorias.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnVolverCategorias.ForeColor = Color.White;
            btnVolverCategorias.Location = new Point(0, 0);
            btnVolverCategorias.Name = "btnVolverCategorias";
            btnVolverCategorias.Size = new Size(145, 60);
            btnVolverCategorias.TabIndex = 3;
            btnVolverCategorias.Text = "← CATEGORÍAS";
            btnVolverCategorias.UseVisualStyleBackColor = false;
            btnVolverCategorias.Click += btnVolverCategorias_Click;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.BackColor = Color.FromArgb(199, 44, 65);
            btnAgregarCarrito.Cursor = Cursors.Hand;
            btnAgregarCarrito.Dock = DockStyle.Bottom;
            btnAgregarCarrito.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnAgregarCarrito.FlatStyle = FlatStyle.Flat;
            btnAgregarCarrito.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnAgregarCarrito.ForeColor = Color.White;
            btnAgregarCarrito.Location = new Point(0, 551);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(766, 48);
            btnAgregarCarrito.TabIndex = 3;
            btnAgregarCarrito.Text = "➕ AGREGAR CANTIDADES AL CARRITO";
            btnAgregarCarrito.UseVisualStyleBackColor = false;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // pnlDerechoCarrito
            // 
            pnlDerechoCarrito.BackColor = Color.FromArgb(81, 10, 50);
            pnlDerechoCarrito.Controls.Add(lstCarritoVivo);
            pnlDerechoCarrito.Controls.Add(lblMesaActualBadge);
            pnlDerechoCarrito.Controls.Add(lblTituloCarrito);
            pnlDerechoCarrito.Controls.Add(pnlCupoCategoria);
            pnlDerechoCarrito.Controls.Add(btnIrAsignarMesa);
            pnlDerechoCarrito.Controls.Add(btnVaciarCarrito);
            pnlDerechoCarrito.Controls.Add(btnConfirmarYRegistrar);
            pnlDerechoCarrito.Dock = DockStyle.Fill;
            pnlDerechoCarrito.Location = new Point(790, 3);
            pnlDerechoCarrito.Name = "pnlDerechoCarrito";
            pnlDerechoCarrito.Padding = new Padding(15);
            pnlDerechoCarrito.Size = new Size(437, 599);
            pnlDerechoCarrito.TabIndex = 1;
            // 
            // lstCarritoVivo
            // 
            lstCarritoVivo.BackColor = Color.FromArgb(45, 20, 44);
            lstCarritoVivo.BorderStyle = BorderStyle.FixedSingle;
            lstCarritoVivo.Dock = DockStyle.Fill;
            lstCarritoVivo.Font = new Font("Consolas", 10F);
            lstCarritoVivo.ForeColor = Color.White;
            lstCarritoVivo.Location = new Point(15, 75);
            lstCarritoVivo.Name = "lstCarritoVivo";
            lstCarritoVivo.Size = new Size(407, 321);
            lstCarritoVivo.TabIndex = 0;
            // 
            // lblMesaActualBadge
            // 
            lblMesaActualBadge.Dock = DockStyle.Top;
            lblMesaActualBadge.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMesaActualBadge.ForeColor = Color.FromArgb(255, 210, 120);
            lblMesaActualBadge.Location = new Point(15, 47);
            lblMesaActualBadge.Name = "lblMesaActualBadge";
            lblMesaActualBadge.Size = new Size(407, 28);
            lblMesaActualBadge.TabIndex = 1;
            lblMesaActualBadge.Text = "Mesa asignada: Sin mesa asignada";
            // 
            // lblTituloCarrito
            // 
            lblTituloCarrito.Dock = DockStyle.Top;
            lblTituloCarrito.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblTituloCarrito.ForeColor = Color.FromArgb(238, 69, 64);
            lblTituloCarrito.Location = new Point(15, 15);
            lblTituloCarrito.Name = "lblTituloCarrito";
            lblTituloCarrito.Size = new Size(407, 32);
            lblTituloCarrito.TabIndex = 2;
            lblTituloCarrito.Text = "\U0001f6d2 PEDIDO ACUMULADO";
            // 
            // pnlCupoCategoria
            // 
            pnlCupoCategoria.BackColor = Color.FromArgb(62, 14, 45);
            pnlCupoCategoria.Controls.Add(pbCupoCategoria);
            pnlCupoCategoria.Controls.Add(lblCupoCategoria);
            pnlCupoCategoria.Dock = DockStyle.Bottom;
            pnlCupoCategoria.Location = new Point(15, 396);
            pnlCupoCategoria.Name = "pnlCupoCategoria";
            pnlCupoCategoria.Padding = new Padding(6, 4, 6, 6);
            pnlCupoCategoria.Size = new Size(407, 56);
            pnlCupoCategoria.TabIndex = 3;
            // 
            // pbCupoCategoria
            // 
            pbCupoCategoria.Dock = DockStyle.Fill;
            pbCupoCategoria.Location = new Point(6, 26);
            pbCupoCategoria.Maximum = 1;
            pbCupoCategoria.Name = "pbCupoCategoria";
            pbCupoCategoria.Size = new Size(395, 24);
            pbCupoCategoria.TabIndex = 0;
            // 
            // lblCupoCategoria
            // 
            lblCupoCategoria.Dock = DockStyle.Top;
            lblCupoCategoria.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblCupoCategoria.ForeColor = Color.FromArgb(255, 210, 120);
            lblCupoCategoria.Location = new Point(6, 4);
            lblCupoCategoria.Name = "lblCupoCategoria";
            lblCupoCategoria.Size = new Size(395, 22);
            lblCupoCategoria.TabIndex = 1;
            lblCupoCategoria.Text = "Cupo Multímetros: 0 / 1";
            // 
            // btnIrAsignarMesa
            // 
            btnIrAsignarMesa.BackColor = Color.FromArgb(128, 19, 54);
            btnIrAsignarMesa.Cursor = Cursors.Hand;
            btnIrAsignarMesa.Dock = DockStyle.Bottom;
            btnIrAsignarMesa.FlatAppearance.BorderColor = Color.FromArgb(199, 44, 65);
            btnIrAsignarMesa.FlatStyle = FlatStyle.Flat;
            btnIrAsignarMesa.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnIrAsignarMesa.ForeColor = Color.White;
            btnIrAsignarMesa.Location = new Point(15, 452);
            btnIrAsignarMesa.Name = "btnIrAsignarMesa";
            btnIrAsignarMesa.Size = new Size(407, 42);
            btnIrAsignarMesa.TabIndex = 4;
            btnIrAsignarMesa.Text = "🖥️ ASIGNAR / CAMBIAR MESA";
            btnIrAsignarMesa.UseVisualStyleBackColor = false;
            btnIrAsignarMesa.Click += btnIrAsignarMesa_Click;
            // 
            // btnVaciarCarrito
            // 
            btnVaciarCarrito.BackColor = Color.FromArgb(95, 15, 38);
            btnVaciarCarrito.Cursor = Cursors.Hand;
            btnVaciarCarrito.Dock = DockStyle.Bottom;
            btnVaciarCarrito.FlatAppearance.BorderColor = Color.FromArgb(199, 44, 65);
            btnVaciarCarrito.FlatStyle = FlatStyle.Flat;
            btnVaciarCarrito.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnVaciarCarrito.ForeColor = Color.FromArgb(255, 180, 180);
            btnVaciarCarrito.Location = new Point(15, 494);
            btnVaciarCarrito.Name = "btnVaciarCarrito";
            btnVaciarCarrito.Size = new Size(407, 40);
            btnVaciarCarrito.TabIndex = 5;
            btnVaciarCarrito.Text = "🗑️ VACIAR PEDIDO";
            btnVaciarCarrito.UseVisualStyleBackColor = false;
            btnVaciarCarrito.Click += btnVaciarCarrito_Click;
            // 
            // btnConfirmarYRegistrar
            // 
            btnConfirmarYRegistrar.BackColor = Color.FromArgb(238, 69, 64);
            btnConfirmarYRegistrar.Cursor = Cursors.Hand;
            btnConfirmarYRegistrar.Dock = DockStyle.Bottom;
            btnConfirmarYRegistrar.FlatAppearance.BorderSize = 0;
            btnConfirmarYRegistrar.FlatStyle = FlatStyle.Flat;
            btnConfirmarYRegistrar.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            btnConfirmarYRegistrar.ForeColor = Color.White;
            btnConfirmarYRegistrar.Location = new Point(15, 534);
            btnConfirmarYRegistrar.Name = "btnConfirmarYRegistrar";
            btnConfirmarYRegistrar.Size = new Size(407, 50);
            btnConfirmarYRegistrar.TabIndex = 6;
            btnConfirmarYRegistrar.Text = "✅ REGISTRAR ALUMNO Y TICKET";
            btnConfirmarYRegistrar.UseVisualStyleBackColor = false;
            btnConfirmarYRegistrar.Click += btnConfirmarYRegistrar_Click;
            // 
            // pnlTicketFinal
            // 
            pnlTicketFinal.Controls.Add(layoutCentradorTicket);
            pnlTicketFinal.Dock = DockStyle.Fill;
            pnlTicketFinal.Location = new Point(0, 0);
            pnlTicketFinal.Name = "pnlTicketFinal";
            pnlTicketFinal.Size = new Size(1280, 655);
            pnlTicketFinal.TabIndex = 2;
            pnlTicketFinal.Visible = false;
            // 
            // layoutCentradorTicket
            // 
            layoutCentradorTicket.ColumnCount = 3;
            layoutCentradorTicket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutCentradorTicket.ColumnStyles.Add(new ColumnStyle());
            layoutCentradorTicket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutCentradorTicket.Controls.Add(pnlTarjetaTicket, 1, 1);
            layoutCentradorTicket.Dock = DockStyle.Fill;
            layoutCentradorTicket.Location = new Point(0, 0);
            layoutCentradorTicket.Name = "layoutCentradorTicket";
            layoutCentradorTicket.RowCount = 3;
            layoutCentradorTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutCentradorTicket.RowStyles.Add(new RowStyle());
            layoutCentradorTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutCentradorTicket.Size = new Size(1280, 655);
            layoutCentradorTicket.TabIndex = 0;
            // 
            // pnlTarjetaTicket
            // 
            pnlTarjetaTicket.BackColor = Color.FromArgb(81, 10, 50);
            pnlTarjetaTicket.Controls.Add(lstTicketImpreso);
            pnlTarjetaTicket.Controls.Add(lblTituloTicket);
            pnlTarjetaTicket.Controls.Add(btnFinalizarSiguienteAlumno);
            pnlTarjetaTicket.Location = new Point(350, 57);
            pnlTarjetaTicket.Name = "pnlTarjetaTicket";
            pnlTarjetaTicket.Padding = new Padding(25);
            pnlTarjetaTicket.Size = new Size(580, 540);
            pnlTarjetaTicket.TabIndex = 0;
            // 
            // lstTicketImpreso
            // 
            lstTicketImpreso.BackColor = Color.FromArgb(45, 20, 44);
            lstTicketImpreso.BorderStyle = BorderStyle.FixedSingle;
            lstTicketImpreso.Dock = DockStyle.Fill;
            lstTicketImpreso.Font = new Font("Consolas", 10.5F);
            lstTicketImpreso.ForeColor = Color.White;
            lstTicketImpreso.Location = new Point(25, 60);
            lstTicketImpreso.Name = "lstTicketImpreso";
            lstTicketImpreso.Size = new Size(530, 407);
            lstTicketImpreso.TabIndex = 0;
            // 
            // lblTituloTicket
            // 
            lblTituloTicket.Dock = DockStyle.Top;
            lblTituloTicket.Font = new Font("Consolas", 13F, FontStyle.Bold);
            lblTituloTicket.ForeColor = Color.FromArgb(238, 69, 64);
            lblTituloTicket.Location = new Point(25, 25);
            lblTituloTicket.Name = "lblTituloTicket";
            lblTituloTicket.Size = new Size(530, 35);
            lblTituloTicket.TabIndex = 1;
            lblTituloTicket.Text = "COMPROBANTE GENERADO Y GUARDADO EN EXCEL";
            lblTituloTicket.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFinalizarSiguienteAlumno
            // 
            btnFinalizarSiguienteAlumno.BackColor = Color.FromArgb(199, 44, 65);
            btnFinalizarSiguienteAlumno.Cursor = Cursors.Hand;
            btnFinalizarSiguienteAlumno.Dock = DockStyle.Bottom;
            btnFinalizarSiguienteAlumno.FlatAppearance.BorderColor = Color.FromArgb(238, 69, 64);
            btnFinalizarSiguienteAlumno.FlatStyle = FlatStyle.Flat;
            btnFinalizarSiguienteAlumno.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnFinalizarSiguienteAlumno.ForeColor = Color.White;
            btnFinalizarSiguienteAlumno.Location = new Point(25, 467);
            btnFinalizarSiguienteAlumno.Name = "btnFinalizarSiguienteAlumno";
            btnFinalizarSiguienteAlumno.Size = new Size(530, 48);
            btnFinalizarSiguienteAlumno.TabIndex = 2;
            btnFinalizarSiguienteAlumno.Text = "✔ FINALIZAR Y VOLVER AL INICIO";
            btnFinalizarSiguienteAlumno.UseVisualStyleBackColor = false;
            btnFinalizarSiguienteAlumno.Click += btnFinalizarSiguienteAlumno_Click;
            // 
            // UcPrestamo
            // 
            BackColor = Color.FromArgb(45, 20, 44);
            Controls.Add(pnlSelectorCategorias);
            Controls.Add(pnlOperacionPrestamo);
            Controls.Add(pnlTicketFinal);
            Name = "UcPrestamo";
            Size = new Size(1280, 655);
            pnlSelectorCategorias.ResumeLayout(false);
            layoutCatalogoCompleto.ResumeLayout(false);
            pnlZonaTarjetas.ResumeLayout(false);
            gridCategorias.ResumeLayout(false);
            cardMultimetros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMultimetros).EndInit();
            cardResistencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picResistencias).EndInit();
            cardCapacitores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCapacitores).EndInit();
            cardCables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCables).EndInit();
            cardProtoboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProtoboard).EndInit();
            cardPinzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPinzas).EndInit();
            pnlPanelLateralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDecoracionOsciloscopio).EndInit();
            pnlOperacionPrestamo.ResumeLayout(false);
            layoutTablaCarrito.ResumeLayout(false);
            pnlIzquierdoTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            pnlBannerInstruccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLaboratoristaGuia).EndInit();
            pnlHeaderTabla.ResumeLayout(false);
            pnlHeaderTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconoCategoriaActual).EndInit();
            pnlDerechoCarrito.ResumeLayout(false);
            pnlCupoCategoria.ResumeLayout(false);
            pnlTicketFinal.ResumeLayout(false);
            layoutCentradorTicket.ResumeLayout(false);
            pnlTarjetaTicket.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
    }
}