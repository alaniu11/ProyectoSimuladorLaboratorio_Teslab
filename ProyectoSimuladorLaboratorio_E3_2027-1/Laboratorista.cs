namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public class Laboratorista
    {
        #region Atributos
        private string numeroCuenta;
        private string nombre;
        private string password;
        private string turno;
        #endregion

        #region Propiedades
        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        #endregion

        #region Constructores
        public Laboratorista()
        {
            numeroCuenta = "";
            nombre = "Laboratorista";
            password = "";
            turno = "Matutino";
        }

        public Laboratorista(string cuenta, string nombreLab, string turnoLab)
        {
            numeroCuenta = cuenta;
            nombre = nombreLab;
            turno = turnoLab;
        }
        #endregion
    }
}