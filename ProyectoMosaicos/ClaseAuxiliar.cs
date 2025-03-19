using System;
using System.Windows;

namespace ProyectoMosaicos
{
    public class ClaseAuxiliar
    {

        // Calcula la cantidad máxima de productos que pueden caber en un palet,
        // organizándolos de manera óptima, con la posibilidad de girar los productos
        // en filas alternas para maximizar el espacio disponible.
        // El número máximo de productos que caben en el palet sin exceder sus dimensiones.
        // Si algún valor es 0 o negativo, o si el producto no cabe en ninguna orientación, devuelve -1.

        public int cantidadProductos(int altoPale, int anchoPale, int altoProducto, int anchoProducto)
        {
            if (altoProducto <= 0 || anchoProducto <= 0 || altoPale <= 0 || anchoPale <= 0)
            {
                MostrarMensajeError("Ningún valor puede ser 0 o negativo", "Error");
                return -1;
            }

            if ((altoProducto > altoPale && anchoProducto > anchoPale) || (anchoProducto > altoPale && altoProducto > anchoPale))
            {
                MostrarMensajeError("El Producto no cabe en el Palet", "Error");
                return -1;
            }

            int filas = altoPale / altoProducto; // Número de filas en orientación normal
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

        // Muestra un MessageBox con el mensaje y título proporcionados.
        // </summary>

        private void MostrarMensajeError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
