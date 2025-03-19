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
        public bool cantidadProductos(int altoPale, int anchoPale, int altoProducto, int anchoProducto)
        {
//Opa
            int numeroProductos;
            int distanciaReducida;
            int anchoRestante;
            int altoRestante;
            if (0 >= altoProducto || 0 >= altoPale || 0 >= anchoPale || 0 >= anchoProducto) {
                MessageBox.Show("Ningún valor puede ser 0", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }else if (altoProducto > altoPale && altoProducto > anchoPale || anchoProducto > altoPale && anchoProducto > anchoPale)
            {
                MessageBox.Show("El Producto no cabe en el Palet", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if(altoProducto> anchoProducto && anchoPale > altoPale)
            {
                 numeroProductos = division(anchoPale, anchoProducto);
                 distanciaReducida = numeroProductos * anchoProducto;
                 anchoRestante = anchoPale - distanciaReducida;
                 altoRestante = altoPale - altoProducto;

                if (altoRestante < altoProducto)
                {

                }

                
            }else if (altoProducto < anchoProducto && anchoPale < altoPale)
            {
                numeroProductos = division(altoPale, altoProducto);
                distanciaReducida = numeroProductos * anchoProducto;
                anchoRestante = altoPale - distanciaReducida;
            }



                return true;
        }

        public int division(int distanciaPale, int distanciaProducto)
        {
            return distanciaPale / distanciaProducto;
        }
}
}

