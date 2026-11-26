namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public class ItemCarrito
    {
        #region Atributos
        private Material producto;
        private int cantidad;
        #endregion

        #region Propiedades
        public Material Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        #endregion

        #region Constructores
        public ItemCarrito(Material prod, int cant)
        {
            producto = prod;
            cantidad = cant;
        }
        #endregion
    }
}