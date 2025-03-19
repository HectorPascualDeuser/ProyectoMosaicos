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

  
        //Calcula la cantidad máxima de productos que pueden caber en un palet,
        // organizándolos de manera óptima, con la posibilidad de girar los productos
        // en filas alternas para maximizar el espacio disponible.
  
       
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

            int filas = altoPale / altoProducto; // Número de filas si se coloca normal
            int columnas = anchoPale / anchoProducto; // Número de columnas en una fila normal

            int totalProductos = filas * columnas; // Cantidad de productos sin rotaciones

            // Espacio restante en altura después de colocar las filas normales
            int espacioRestante = altoPale - (filas * altoProducto);

            // Si hay espacio restante, intentamos colocar una fila rotada
            if (espacioRestante >= anchoProducto)
            {
                int columnasFilaExtra = anchoPale / altoProducto; // Rotamos los productos en esta fila
                totalProductos += columnasFilaExtra; // Agregamos la fila extra con productos rotados
            }

            return totalProductos;
        }



        public int division(int distanciaPale, int distanciaProducto)
        {
            return distanciaPale / distanciaProducto;
        }
}
}

