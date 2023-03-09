using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_menu
{
    public class Metodos
    {
        public int numeroIngresado;
        public bool continuarEx1 = true;

        public void primerEjercicio()
        {
            while (continuarEx1)
            {
                Console.WriteLine("----Ejercicio1----");
                Console.Write("Escriba el numero del mes que quiera saber su nombre: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado <= 12 && numeroIngresado >= 1)
                {
                    continuarEx1 = false;

                    switch (numeroIngresado)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Enero");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Febrero");
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Marzo");
                            break;
                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Abril");
                            break;
                        case 5:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Mayo");
                            break;
                        case 6:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Junio");
                            break;
                        case 7:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Julio");
                            break;
                        case 8:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Agosto");
                            break;
                        case 9:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Septiembre");
                            break;
                        case 10:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Octubre");
                            break;
                        case 11:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Noviembre");
                            break;
                        case 12:
                            Console.WriteLine("");
                            Console.WriteLine("MES: Diciembre");
                            break;
                    }
                    Console.WriteLine("");
                    

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("“Error: El número a ingresar debe estar contenido entre 1 y 12");
                    Console.WriteLine("Presiona ENTER para reintentar");

                    bool validarTecla = true;

                    while (validarTecla) { 
                    if(Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                            Console.Clear();
                        continuarEx1 = true;
                            validarTecla = false;
                    } else
                    {
                            Console.Clear();
                            Console.WriteLine("Presiona ENTER para reintentar");

                            validarTecla = true;
                    }
                    }

                }
            }

        }
        
        public string peticionString = "";
        public void peticionSalida(bool continuarEjecucion)
        {
            Console.WriteLine("");
            Console.WriteLine("Desea regresar? escriba 'si' para regresar y 'no' para salir");
            peticionString = Console.ReadLine().ToLower();

            if (peticionString == "si")
            {
                Console.WriteLine("Presiona ENTER para regresar");
            }
            else if (peticionString == "no")
            {
                continuarEjecucion = false;
                Console.Clear();
                Console.WriteLine("Gracias por utilizar el programa");
                Console.ReadKey();
                Environment.Exit(0);

            }
        }

        public void segundoEjercicio()
        {
            Console.WriteLine("----Ejercicio 2----");
            Console.WriteLine("");


            Console.Write("Número 1: ");
            string valor1 = Console.ReadLine();
            Console.Write("Número 2: ");
            string valor2 = Console.ReadLine();
            Console.Write("Número 3: ");
            string valor3 = Console.ReadLine();

            int numero1, numero2, numero3;

            // aca use && porque es la validacion, no el diagrama de flujo

            if (int.TryParse(valor1, out numero1) && numero1 > 0 &&
                int.TryParse(valor2, out numero2) && numero2 > 0 &&
                int.TryParse(valor3, out numero3) && numero3 > 0)
            {

                // diagrama de flujo

                if (numero1 > numero2)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine($"Resultado: {numero1} es mayor a {numero3} ");
                    }
                    else
                    {
                        if (numero1 == numero3)
                        {
                            Console.WriteLine($"Resultado: {numero1} es igual a {numero3} ");

                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {numero1} no es igual a {numero3} ");

                        }
                    }
                }
                else
                {
                    if (numero1 == numero2)
                    {
                        if (numero1 > numero3)
                        {
                            Console.WriteLine($"Resultado: {numero1} es mayor a {numero3} ");

                        }
                        else
                        {
                            if (numero1 == numero3)
                            {
                                Console.WriteLine($"Resultado: {numero1} es igual a {numero3} ");

                            }
                            else
                            {
                                Console.WriteLine($"Resultado: {numero1} no es igual a {numero3} ");

                            }

                        }
                    }
                    else
                    {
                        if (numero2 > numero3)
                        {
                            Console.WriteLine($"Resultado: {numero2} es mayor a {numero3} ");

                        }
                        else
                        {
                            if (numero2 == numero3)
                            {
                                Console.WriteLine($"Resultado: {numero2} es igual a {numero3} ");

                            }
                            else
                            {
                                Console.WriteLine($"Resultado: {numero2} no es igual a {numero3} ");

                            }
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Error: uno o más valores ingresados no son números enteros mayores a cero.");
            }

        }

    }
}
