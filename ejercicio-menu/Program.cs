using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodoExterno = new Metodos();

            int opcion = 0;
                bool continuar = true;

            while (continuar)
            {
          
                bool opcionCorrecta = false;
                while (!opcionCorrecta)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Supervisado - Ricardo Guevara - 1176323");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("MENÚ DE JERCICIOS");
                    Console.WriteLine("1. Visualizar Ejercicio 1");                                        
                    Console.WriteLine("2. Visualizar Ejercicio 2");
                    Console.WriteLine("3. Salir");

                    Console.WriteLine("Ingrese el numero de ejercicio que desea visualizar o ingresa 3 para salir");

                    try
                    {
                        opcion = int.Parse(Console.ReadLine());

                        if (opcion > 0 && opcion <= 4)
                        {
                            Console.Clear();
                            opcionCorrecta = true;
                        }
                    }

                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe ingresar un número valido");
                        Console.WriteLine("");
                        Console.WriteLine("Presiona ENTER para continuar");

                        Console.ReadKey();
                    }
                   Console.Clear();

                }               
                

                switch (opcion)
                {
                    case 1:

                       metodoExterno.primerEjercicio();
                       metodoExterno.peticionSalida(continuar);
                                                                    
                        break;
                    case 2:
                        metodoExterno.segundoEjercicio();
                        metodoExterno.peticionSalida(continuar);

                        break;                   
                    case 3:
                        Environment.Exit(0);

                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}