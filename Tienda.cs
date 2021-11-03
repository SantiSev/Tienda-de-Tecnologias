using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Tecnologias
{
    class Tienda : Persona  //TECNOLOGIAS HEREDA DE PERSONA, TODO DATO DE PERSONA PUEDE SER LLAMADO POR TECNOLOGIAS
    {
        public Tienda() //preguntar como llamar la clase al main sin tener que crear el public
        {

            Console.WriteLine("Ingrese su nombre");
            this.nombres = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            this.apellidos = Console.ReadLine();

        }

        public void Saludar() //saludamos a todos aquellos que ingresan a la tienda
        {
            Console.WriteLine("----------¡Bienvenidos " + this.nombres + " " + this.apellidos + "!----------");
            return;
        }

        public int Dinero(out int pobres) //analizamos si el cliente tiene dinero o no
        {                                 //el valor que ingresa evalua si el cliente es pobre o no
            Console.WriteLine("¿Cuanto dinero tiene para gastar?");
            dinero = int.Parse(Console.ReadLine()); //ingrese cuanto dinero tiene
            if (dinero == 0)
            {
                Console.WriteLine("no negociamos con pobres :) "); //si no tenes guita, te sacamos de la tienda
                pobres = 0;
                return pobres;
            }
            else //si tenes guita te quedas
                Console.WriteLine("tiene cargado " + dinero + "$ en su cuenta");
            pobres = 1;

            return pobres;
        }
       
        public void productos()
        {
            while (this.ContinuarComprando == 0 )
            {
                
                Console.WriteLine("¿Que le interesa comprar?");
                Console.WriteLine("[1] --> Computadoras");
                Console.WriteLine("[2] --> Celulares");
                Console.WriteLine("[0] --> Salir de la tienda");
                Console.WriteLine("Balance actual: " + "$" + this.dinero);
                Console.WriteLine("Prodcutos Comprados: " + this.ProductosComprados);
                int Seleccione_Un_Producto = int.Parse(Console.ReadLine());
                int comprar;

                switch (Seleccione_Un_Producto)
                {
                    #region SALIR DE LA TIENDA
                    case 0:
                       this.ContinuarComprando = 1;
                        break;
                    #endregion

                    #region COMPUTADORAS
                    case 1: //COMPRAMOS UNA COMPUTADORA
                        Console.WriteLine("usted esta interesado en comprar " + Productos.Computadoras);
                        Console.WriteLine(TipoDeComputadoras.Dell + "  : 150 dolares -----> PRESIONE [1]");
                        Console.WriteLine(TipoDeComputadoras.Mac + "   : 300 dolares -----> PRESIONE [2]");
                        Console.WriteLine(TipoDeComputadoras.Lenovo + ": 100 dolares -----> PRESIONE [3]");
                        Console.WriteLine("Salir -----> PRESIONE [0]");
                        Console.WriteLine("Balance actual: " + "$" + this.dinero);
                        Console.WriteLine("¿Cual desea comprar?");
                        comprar = int.Parse(Console.ReadLine());
                        switch (comprar)
                        {
                            case 0:
                                break;

                            case 1: //compramos una computadora DELL
                                if (this.dinero < 150) //si no alcanza, no te podras comprar esta compu
                                {
                                    Console.WriteLine("saldo insuficiente :(");
                                    break;
                                }
                                else
                                {
                                    this.dinero = this.dinero - 150;
                                    if (this.dinero < 0) { this.dinero = 0; }
                                    Console.WriteLine("Usted ha comprado 1 computadora " + TipoDeComputadoras.Dell);
                                    Console.WriteLine("Balance actual: " + this.dinero);
                                    this.ProductosComprados++;
                                    break;
                                }
                            case 2: //compramos una computadora MAC
                                if (this.dinero < 300) //si no alcanza, no te podras comprar esta compu
                                {
                                    Console.WriteLine("saldo insuficiente :(");
                                    break;
                                }
                                else
                                {
                                    this.dinero = this.dinero - 300;
                                    if (this.dinero < 0) { this.dinero = 0; }
                                    Console.WriteLine("Usted ha comprado 1 computadora " + TipoDeComputadoras.Mac);
                                    Console.WriteLine("Balance actual: " + this.dinero);
                                    this.ProductosComprados++;
                                    break;
                                }
                            case 3: //compramos una computadora Lenovo
                                if (this.dinero < 100) //si no alcanza, no te podras comprar esta compu
                                {
                                    Console.WriteLine("saldo insuficiente :(");
                                    break;
                                }
                                else
                                {
                                    this.dinero = this.dinero - 100;
                                    if (this.dinero < 0) { this.dinero = 0; }
                                    Console.WriteLine("Usted ha comprado 1 computadora " + TipoDeComputadoras.Mac);
                                    Console.WriteLine("Balance actual: " + this.dinero);
                                    this.ProductosComprados++;
                                    break;
                                }


                        }
                        break;
                    #endregion

                    #region CELULARES

                    case 2: //COMPRAMOS UN CELULAR
                        Console.WriteLine("usted esta interesado en comprar " + Productos.Celulares);
                        Console.WriteLine(TipoDeCelulares.Apple + "    : 900 dolares -----> PRESIONE [1]");
                        Console.WriteLine(TipoDeCelulares.Samsung + "  : 500 dolares -----> PRESIONE [2]");
                        Console.WriteLine(TipoDeCelulares.Motorola + " : 100 dolares -----> PRESIONE [3]");
                        Console.WriteLine("Salir -----> PRESIONE [0]");
                        Console.WriteLine("Balance actual: " + "$"+this.dinero);
                        Console.WriteLine("¿Cual desea comprar?");
                        comprar = int.Parse(Console.ReadLine());
                        switch (comprar)
                        {
                            case 0:
                                break;

                            case 1: //compramos un Celular Apple
                                if (this.dinero < 900) //si no alcanza, no te podras comprar esta compu
                                {
                                    Console.WriteLine("saldo insuficiente :(");
                                    break;
                                }
                                else
                                {
                                    this.dinero = this.dinero - 900;
                                    if (this.dinero < 0) { this.dinero = 0; }
                                    Console.WriteLine("Usted ha comprado 1 celular " + TipoDeCelulares.Apple);
                                    Console.WriteLine("Balance actual: " + "$"+this.dinero);
                                    this.ProductosComprados++;
                                    break;
                                }
                            case 2: //compramos un Celular Samsung
                                if (this.dinero < 500) //si no alcanza, no te podras comprar esta compu
                                {
                                    Console.WriteLine("saldo insuficiente :(");
                                    break;
                                }
                                else
                                {
                                    this.dinero = this.dinero - 500;
                                    if (this.dinero < 0) { this.dinero = 0; }
                                    Console.WriteLine("Usted ha comprado 1 celular " + TipoDeCelulares.Samsung);
                                    Console.WriteLine("Balance actual: " + "$" + this.dinero); 
                                    this.ProductosComprados++;
                                    break;
                                }
                            case 3: //compramos un Celular Motorola
                                if (this.dinero < 100) //si no alcanza, no te podras comprar esta compu
                                {
                                    Console.WriteLine("saldo insuficiente :(");
                                    break;
                                }
                                else
                                {
                                    this.dinero = this.dinero - 100;
                                    if (this.dinero < 0) { this.dinero = 0; }
                                    Console.WriteLine("Usted ha comprado 1 celular " + TipoDeCelulares.Motorola);
                                    Console.WriteLine("Balance actual: " + "$" + this.dinero);
                                    this.ProductosComprados++;
                                    break;
                                }


                        }
                        break;
                        #endregion

                }

                

                if (dinero == 0)
                {
                    this.ContinuarComprando = 1;
                }
                else 
                {
                    Console.WriteLine("¿Desea continuar comprando? presione [0] sino presione [1]");
                    ContinuarComprando = int.Parse(Console.ReadLine());
                }
                
            }
            return;
        }

    }
}
