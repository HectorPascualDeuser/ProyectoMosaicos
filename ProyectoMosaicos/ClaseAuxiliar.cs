using System;
using System.Windows;

namespace ProyectoMosaicos
{
    public class ClaseAuxiliar
    {

        // Genera una matriz bidimensional que representa cómo se organizan los productos en el palet.
        // Los productos se organizan en filas normales y, si hay espacio, se rota la última fila para optimizar el espacio.
        // Una matriz `int[,]` representando el palet, donde cada número indica un producto colocado.
       
        public int[,] GenerarMosaico(int altoPale, int anchoPale, int altoProducto, int anchoProducto)
        {
            if (altoProducto <= 0 || anchoProducto <= 0 || altoPale <= 0 || anchoPale <= 0)
            {
                MostrarMensajeError("Ningún valor puede ser 0 o negativo", "Error");
                return null;
            }

            if ((altoProducto > altoPale && anchoProducto > anchoPale) || (anchoProducto > altoPale && altoProducto > anchoPale))
            {
                MostrarMensajeError("El Producto no cabe en el Palet", "Error");
                return null;
            }

            int[,] palet = new int[altoPale, anchoPale]; // Matriz para representar el palet (inicialmente llena de ceros)
            int productoId = 1; // Identificador de cada producto colocado

            int filasNormales = altoPale / altoProducto; // Filas completas en orientación normal
            int columnasNormales = anchoPale / anchoProducto; // Columnas por fila normal

            // Colocar las filas normales con productos sin girar
            for (int fila = 0; fila < filasNormales; fila++)
            {
                for (int col = 0; col < columnasNormales; col++)
                {
                    // Llenar la matriz con el producto
                    for (int i = 0; i < altoProducto; i++)
                    {
                        for (int j = 0; j < anchoProducto; j++)
                        {
                            palet[fila * altoProducto + i, col * anchoProducto + j] = productoId;
                        }
                    }
                    productoId++; // Pasamos al siguiente producto
                }
            }

            // Verificamos si queda espacio para una fila extra rotada
            int espacioRestante = altoPale - (filasNormales * altoProducto);

            if (espacioRestante >= anchoProducto) // Si hay espacio para rotar productos
            {
                int columnasFilaExtra = anchoPale / altoProducto; // Columnas en la fila rotada

                for (int col = 0; col < columnasFilaExtra; col++)
                {
                    // Llenar la fila extra con productos girados
                    for (int i = 0; i < anchoProducto; i++)
                    {
                        for (int j = 0; j < altoProducto; j++)
                        {
                            palet[filasNormales * altoProducto + i, col * altoProducto + j] = productoId;
                        }
                    }
                    productoId++;
                }
            }

            return palet;
        }


        // Muestra un MessageBox con el mensaje y título proporcionados.
        // </summary>

        private void MostrarMensajeError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
