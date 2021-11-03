using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Tecnologias
{
    class Program 
    {
        static void Main(string[] args)
        {
            int pobre; //este int nos ayudara definir si nuestro cliente tiene plata o no

            Tienda T = new Tienda();
            T.Saludar();    //llamamos a la clase tienda --> Saludar
            Console.WriteLine("Presione [1] para ingresar a la tienda, sino presione cualquier numero para salir");

            int Pregunta = int.Parse(Console.ReadLine()); //si pregunta es 1, entonces el while corre

            while (Pregunta == 1)
            {
                T.Dinero(out pobre); //le mandamos pobres aca para depues determinar si el comprador es pobre o no
                if (pobre == 0)      //si el cliente es pobre, lamentablemente el cleinte es expulsado de la tienda :(
                {
                    Pregunta = 0;
                    break;
                }
                else //si no es pobre, ¡El cliente puede comprar todo lo que quiere!
                {
                    T.productos();
                    break;
                }
            }
            Console.WriteLine("¡Gracias Por Visitar la Tienda!");
            Console.ReadKey();
        }
    }





}
