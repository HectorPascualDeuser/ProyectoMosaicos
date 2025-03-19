using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoMosaicos
{
    public class ClaseAuxiliar
    {
        public int cantidadProductos(int altoPale, int anchoPale, int altoProducto, int anchoProducto)
        {
            if (altoProducto <= 0 || anchoProducto <= 0 || altoPale <= 0 || anchoPale <= 0)
            {
                MessageBox.Show("Ningún valor puede ser 0 o negativo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return -1;
            }

            if ((altoProducto > altoPale && anchoProducto > anchoPale) || (anchoProducto > altoPale && altoProducto > anchoPale))
            {
                MessageBox.Show("El Producto no cabe en el Palet", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return -1;
            }

            // Opción 1: Mantener la orientación original del producto
            int productosOpcion1 = (altoPale / altoProducto) * (anchoPale / anchoProducto);

            // Opción 2: Rotar el producto
            int productosOpcion2 = (altoPale / anchoProducto) * (anchoPale / altoProducto);

            // Devolvemos el máximo entre ambas opciones
            return Math.Max(productosOpcion1, productosOpcion2);
        }


        public int division(int distanciaPale, int distanciaProducto)
        {
            return distanciaPale / distanciaProducto;
        }
}
}

