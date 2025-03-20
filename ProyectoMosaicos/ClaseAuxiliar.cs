using System;
using System.Windows;
using ProyectoMosaicos.Models;

namespace ProyectoMosaicos
{
    public class ClaseAuxiliar
    {

        // Genera una matriz bidimensional que representa cómo se organizan los productos en el palet.
        // Los productos se organizan en filas normales y, si hay espacio, se rota la última fila para optimizar el espacio.
        // Una matriz `int[,]` representando el palet, donde cada número indica un producto colocado.
       
        public bool GenerarMosaico(List<Producto> productos, Pale pale)
        {



            return true;
        }


        // Muestra un MessageBox con el mensaje y título proporcionados.
        // </summary>

        private void MostrarMensajeError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
