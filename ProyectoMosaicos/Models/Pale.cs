using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMosaicos.Models
{
    public enum Tipo{
    Americano, Europeo, Libre
    }
    public class Pale
    {    
        public int Id {get; set;}
        public int Alto {get; set;}
        public Tipo Tipo {get; set;}
        public int Ancho {get; set;}
    }
}
