using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Tecnologias
{
    class Persona
    {

        public enum Productos { Computadoras, Celulares }
        public enum TipoDeComputadoras { Mac, Dell, Lenovo }
        public enum TipoDeCelulares { Samsung, Apple, Motorola }
        public string nombres;
        public string apellidos;
        public int dinero;
        public int ContinuarComprando;
        public int ProductosComprados = 0;
       
        public Persona() { }

    }
}
