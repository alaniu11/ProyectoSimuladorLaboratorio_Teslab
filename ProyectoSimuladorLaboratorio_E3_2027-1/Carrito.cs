using System.Collections.Generic;

namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    public class Carrito
    {
        #region Atributos
        private List<ItemCarrito> items;
        private string mesaAsignada;
        #endregion

        #region Propiedades
        public List<ItemCarrito> Items
        {
            get { return items; }
            set { items = value; }
        }

        public string MesaAsignada
        {
            get { return mesaAsignada; }
            set { mesaAsignada = value; }
        }
        #endregion

        #region Constructores
        public Carrito()
        {
            items = new List<ItemCarrito>();
            mesaAsignada = "Sin mesa asignada";
        }
        #endregion

        #region Métodos
        // Esta función hace la búsqueda del material en la lista del carrito; si ya existe le suma la cantidad y si no existe lo agrega como nuevo elemento, y me ayudó a realizarla la IA
        public void AgregarProducto(Material material, int cantidad)
        {
            bool encontrado = false;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Producto.Id == material.Id)
                {
                    items[i].Cantidad = items[i].Cantidad + cantidad;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                ItemCarrito nuevoItem = new ItemCarrito(material, cantidad);
                items.Add(nuevoItem);
            }
        }

        public List<string> MostrarProductos()
        {
            List<string> listaTexto = new List<string>();

            for (int i = 0; i < items.Count; i++)
            {
                string linea = items[i].Cantidad + "x " + items[i].Producto.Nombre +
                               " [" + items[i].Producto.Categoria + "] (Límite: " +
                               items[i].Producto.TiempoLimiteHoras + "h)";
                listaTexto.Add(linea);
            }

            return listaTexto;
        }

        public void Vaciar(bool restaurarStock)
        {
            if (restaurarStock == true)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    items[i].Producto.StockDisponible = items[i].Producto.StockDisponible + items[i].Cantidad;
                }
            }

            items.Clear();
            mesaAsignada = "Sin mesa asignada";
        }
        #endregion
    }
}