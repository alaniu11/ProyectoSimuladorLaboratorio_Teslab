namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public class Material
    {
        #region Atributos
        private string id;
        private string categoria;
        private string nombre;
        private int stockDisponible;
        private int tiempoLimiteHoras;
        #endregion

        #region Propiedades
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int StockDisponible
        {
            get { return stockDisponible; }
            set { stockDisponible = value; }
        }

        public int TiempoLimiteHoras
        {
            get { return tiempoLimiteHoras; }
            set { tiempoLimiteHoras = value; }
        }
        #endregion

        #region Constructores
        public Material(string idMat, string catMat, string nomMat, int stock, int horas)
        {
            id = idMat;
            categoria = catMat;
            nombre = nomMat;
            stockDisponible = stock;
            tiempoLimiteHoras = horas;
        }
        #endregion
    }
}