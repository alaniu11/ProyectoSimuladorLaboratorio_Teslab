namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public class Alumno
    {
        #region Atributos
        private string numeroCuenta;
        private string nombreCompleto;
        private string grupo;
        #endregion

        #region Propiedades
        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        #endregion

        #region Constructores
        public Alumno()
        {
            numeroCuenta = "";
            nombreCompleto = "";
            grupo = "";
        }

        public Alumno(string cuenta, string nombre, string grupoLab)
        {
            numeroCuenta = cuenta;
            nombreCompleto = nombre;
            grupo = grupoLab;
        }
        #endregion
    }
}