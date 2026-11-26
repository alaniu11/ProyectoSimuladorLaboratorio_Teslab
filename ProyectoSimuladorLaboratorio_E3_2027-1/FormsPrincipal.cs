using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public partial class FormsPrincipal : Form
    {
        #region Atributos
        private Laboratorista laboratoristaActual;
        private Carrito carritoActual = new Carrito();
        private List<Material> inventarioGlobal = new List<Material>();
        private Dictionary<string, int> lugaresDisponiblesFuentes = new Dictionary<string, int>();

        private UcInicio vistaInicio;
        private UcPrestamo vistaPrestamo;
        private UcMesas vistaMesas;
        #endregion

        #region Constructores
        public FormsPrincipal()
        {
            InitializeComponent();
        }

        public FormsPrincipal(Laboratorista lab)
        {
            InitializeComponent();
            laboratoristaActual = lab;

            MostrarDatosLaboratoristaEnBarra();
            CargarInventarioYMesas();
            InicializarVistas();
            MostrarVista(vistaInicio);
        }
        #endregion

        #region Métodos
        public void ActualizarLaboratorista(Laboratorista nuevoLab)
        {
            laboratoristaActual = nuevoLab;
            MostrarDatosLaboratoristaEnBarra();
            MostrarVista(vistaInicio);
        }

        private void MostrarDatosLaboratoristaEnBarra()
        {
            foreach (Control ctrl in pnlBarraSuperior.Controls)
            {
                if (ctrl is Label lbl && lbl.Text.Contains("Laboratorista"))
                {
                    lbl.Text = "Laboratorista: " + laboratoristaActual.Nombre + " (Cta: " + laboratoristaActual.NumeroCuenta + ")";
                    break;
                }
            }
        }

        private void CargarInventarioYMesas()
        {
            inventarioGlobal.Clear();
            lugaresDisponiblesFuentes.Clear();

            // 1. MULTÍMETROS (6 modelos)
            inventarioGlobal.Add(new Material("MUL-01", "Multímetros", "Multímetro Digital Fluke 117 True-RMS", 5, 2));
            inventarioGlobal.Add(new Material("MUL-02", "Multímetros", "Multímetro Digital Fluke 179", 4, 2));
            inventarioGlobal.Add(new Material("MUL-03", "Multímetros", "Multímetro Extech EX330 Autorango", 4, 2));
            inventarioGlobal.Add(new Material("MUL-04", "Multímetros", "Multímetro Klein Tools MM400", 5, 2));
            inventarioGlobal.Add(new Material("MUL-05", "Multímetros", "Multímetro Steren MUL-285", 8, 2));
            inventarioGlobal.Add(new Material("MUL-06", "Multímetros", "Multímetro de Banco Agilent 34401A", 2, 2));

            // 2. RESISTENCIAS (15 valores comerciales más usados a 1/4 W)
            inventarioGlobal.Add(new Material("RES-01", "Resistencias", "Resistencia 10 Ω (1/4 W - 5%)", 100, 4));
            inventarioGlobal.Add(new Material("RES-02", "Resistencias", "Resistencia 47 Ω (1/4 W - 5%)", 100, 4));
            inventarioGlobal.Add(new Material("RES-03", "Resistencias", "Resistencia 100 Ω (1/4 W - 5%)", 150, 4));
            inventarioGlobal.Add(new Material("RES-04", "Resistencias", "Resistencia 220 Ω (1/4 W - 5%)", 200, 4));
            inventarioGlobal.Add(new Material("RES-05", "Resistencias", "Resistencia 330 Ω (1/4 W - 5%)", 200, 4));
            inventarioGlobal.Add(new Material("RES-06", "Resistencias", "Resistencia 470 Ω (1/4 W - 5%)", 150, 4));
            inventarioGlobal.Add(new Material("RES-07", "Resistencias", "Resistencia 680 Ω (1/4 W - 5%)", 100, 4));
            inventarioGlobal.Add(new Material("RES-08", "Resistencias", "Resistencia 1 kΩ (1/4 W - 5%)", 250, 4));
            inventarioGlobal.Add(new Material("RES-09", "Resistencias", "Resistencia 2.2 kΩ (1/4 W - 5%)", 150, 4));
            inventarioGlobal.Add(new Material("RES-10", "Resistencias", "Resistencia 3.3 kΩ (1/4 W - 5%)", 120, 4));
            inventarioGlobal.Add(new Material("RES-11", "Resistencias", "Resistencia 4.7 kΩ (1/4 W - 5%)", 180, 4));
            inventarioGlobal.Add(new Material("RES-12", "Resistencias", "Resistencia 10 kΩ (1/4 W - 5%)", 250, 4));
            inventarioGlobal.Add(new Material("RES-13", "Resistencias", "Resistencia 47 kΩ (1/4 W - 5%)", 120, 4));
            inventarioGlobal.Add(new Material("RES-14", "Resistencias", "Resistencia 100 kΩ (1/4 W - 5%)", 150, 4));
            inventarioGlobal.Add(new Material("RES-15", "Resistencias", "Resistencia 1 MΩ (1/4 W - 5%)", 100, 4));

            // 3. CAPACITORES (8 modelos comerciales)
            inventarioGlobal.Add(new Material("CAP-01", "Capacitores", "Capacitor Cerámico 22 pF (50V)", 100, 4));
            inventarioGlobal.Add(new Material("CAP-02", "Capacitores", "Capacitor Cerámico 10 nF / 103 (50V)", 100, 4));
            inventarioGlobal.Add(new Material("CAP-03", "Capacitores", "Capacitor Cerámico 100 nF / 104 (50V)", 150, 4));
            inventarioGlobal.Add(new Material("CAP-04", "Capacitores", "Capacitor Electrolítico 1 µF (50V)", 80, 4));
            inventarioGlobal.Add(new Material("CAP-05", "Capacitores", "Capacitor Electrolítico 10 µF (50V)", 120, 4));
            inventarioGlobal.Add(new Material("CAP-06", "Capacitores", "Capacitor Electrolítico 47 µF (25V)", 90, 4));
            inventarioGlobal.Add(new Material("CAP-07", "Capacitores", "Capacitor Electrolítico 100 µF (25V)", 100, 4));
            inventarioGlobal.Add(new Material("CAP-08", "Capacitores", "Capacitor Electrolítico 1000 µF (25V)", 50, 4));

            // 4. CABLES (7 modelos)
            inventarioGlobal.Add(new Material("CAB-01", "Cables", "Par Caimán - Caimán (Rojo/Negro)", 35, 2));
            inventarioGlobal.Add(new Material("CAB-02", "Cables", "Par Banana - Caimán (Rojo/Negro)", 30, 2));
            inventarioGlobal.Add(new Material("CAB-03", "Cables", "Par Banana - Banana Apilable", 25, 2));
            inventarioGlobal.Add(new Material("CAB-04", "Cables", "Sonda para Osciloscopio 100 MHz (1x/10x)", 15, 2));
            inventarioGlobal.Add(new Material("CAB-05", "Cables", "Cable BNC - Caimán para Generador", 15, 2));
            inventarioGlobal.Add(new Material("CAB-06", "Cables", "Kit Jumpers Macho-Macho (20 pzas)", 25, 2));
            inventarioGlobal.Add(new Material("CAB-07", "Cables", "Kit Jumpers Macho-Hembra (20 pzas)", 20, 2));

            // 5. PROTOBOARD (5 modelos)
            inventarioGlobal.Add(new Material("PRO-01", "Protoboard", "Protoboard Estándar 830 Puntos", 30, 2));
            inventarioGlobal.Add(new Material("PRO-02", "Protoboard", "Protoboard Mini 400 Puntos", 20, 2));
            inventarioGlobal.Add(new Material("PRO-03", "Protoboard", "Protoboard Doble 1660 Puntos con Base", 10, 2));
            inventarioGlobal.Add(new Material("PRO-04", "Protoboard", "Protoboard Triple 2490 Puntos con Bornes", 6, 2));
            inventarioGlobal.Add(new Material("PRO-05", "Protoboard", "Módulo Fuente 3.3V/5V para Protoboard", 15, 2));

            // 6. PINZAS Y HERRAMIENTA (6 modelos)
            inventarioGlobal.Add(new Material("PIN-01", "Pinzas", "Pinzas de Punta Fina ESD", 20, 2));
            inventarioGlobal.Add(new Material("PIN-02", "Pinzas", "Pinzas de Corte Diagonal", 20, 2));
            inventarioGlobal.Add(new Material("PIN-03", "Pinzas", "Pelacables Automático Calibre 10-24 AWG", 12, 2));
            inventarioGlobal.Add(new Material("PIN-04", "Pinzas", "Pinzas de Precisión Antiestáticas (Curvas)", 15, 2));
            inventarioGlobal.Add(new Material("PIN-05", "Pinzas", "Extractor de Circuitos Integrados (DIP)", 10, 2));
            inventarioGlobal.Add(new Material("PIN-06", "Pinzas", "Desarmador de Precisión Perillero", 15, 2));

            // 3 Mesas alargadas (3, 2, 1) x 3 Fuentes de poder (A, B, C) = 9 estaciones de 4 lugares cada una
            string[] nivelesMesa = { "3", "2", "1" };
            string[] fuentes = { "A", "B", "C" };
            for (int m = 0; m < nivelesMesa.Length; m++)
            {
                for (int f = 0; f < fuentes.Length; f++)
                {
                    lugaresDisponiblesFuentes.Add(nivelesMesa[m] + fuentes[f], 4);
                }
            }
        }

        private void InicializarVistas()
        {
            vistaInicio = new UcInicio();
            vistaInicio.Dock = DockStyle.Fill;
            vistaInicio.SeleccionarPrestamo += (s, e) =>
            {
                vistaPrestamo.ActualizarVistaDesdeExterior();
                MostrarVista(vistaPrestamo);
            };
            vistaInicio.SeleccionarMesas += (s, e) =>
            {
                vistaMesas.RefrescarPlanoMesas();
                MostrarVista(vistaMesas);
            };
            vistaInicio.SeleccionarDevolucion += (s, e) =>
            {
                FormDevolucion modalDev = new FormDevolucion(inventarioGlobal);
                modalDev.ShowDialog();
                vistaPrestamo.ActualizarVistaDesdeExterior();
            };
            vistaInicio.CerrarSesionSolicitado += (s, e) =>
            {
                DialogResult resp = MessageBox.Show("¿Deseas cerrar la sesión actual? El inventario y las mesas asignadas se conservarán.", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    this.Hide();
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm is FormsLog)
                        {
                            frm.Show();
                            return;
                        }
                    }
                    FormsLog nuevoLogin = new FormsLog();
                    nuevoLogin.Show();
                }
            };

            vistaPrestamo = new UcPrestamo(laboratoristaActual, carritoActual, inventarioGlobal);
            vistaPrestamo.Dock = DockStyle.Fill;
            vistaPrestamo.SolicitarIrMesas += (s, e) =>
            {
                vistaMesas.RefrescarPlanoMesas();
                MostrarVista(vistaMesas);
            };
            vistaPrestamo.PrestamoFinalizado += (s, e) =>
            {
                vistaMesas.RefrescarPlanoMesas();
                MostrarVista(vistaInicio);
            };

            vistaMesas = new UcMesas(laboratoristaActual, carritoActual, lugaresDisponiblesFuentes);
            vistaMesas.Dock = DockStyle.Fill;
            vistaMesas.MesaSeleccionadaParaCarrito += (s, e) =>
            {
                vistaPrestamo.ActualizarVistaDesdeExterior();
                MostrarVista(vistaPrestamo);
            };

            pnlContenido.Controls.Add(vistaInicio);
            pnlContenido.Controls.Add(vistaPrestamo);
            pnlContenido.Controls.Add(vistaMesas);
        }

        private void MostrarVista(UserControl vistaActiva)
        {
            vistaInicio.Visible = (vistaActiva == vistaInicio);
            vistaPrestamo.Visible = (vistaActiva == vistaPrestamo);
            vistaMesas.Visible = (vistaActiva == vistaMesas);
            vistaActiva.BringToFront();
        }
        #endregion

        #region Eventos de Controles
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            MostrarVista(vistaInicio);
        }

        private void FormsPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}