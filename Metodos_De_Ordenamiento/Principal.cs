using System;

namespace Metodos_De_Ordenamiento
{
    public class Principal
    {
        public static void Main(string[] args)
        {

            bool continuar = true;
            int contador = 0;
            int[] vector = new int[10];
            

            while (continuar)
            {
                                
                Console.Clear();

                Console.WriteLine("Ingrese la opción a realizar");
                Console.WriteLine("1. Ingresar datos al vector");
                Console.WriteLine("2. Consultar los datos del metodo burbuja");
                Console.WriteLine("3. Consultar los datos del metodo shell");
                Console.WriteLine("4. Consultar los datos del metodo selección");
                Console.WriteLine("5. Consultar los datos del metodo inserción");
                Console.WriteLine("6. Salir");
                int opcion;

                opcion = int.Parse(Console.ReadLine());

                if(opcion == 1)
                {
                    Console.Clear();
                    contador += 1;
                    Console.WriteLine("\nIngrese los datos del vector");
                    Console.WriteLine("\n\n");
                    for (int i = 0; i < vector.Length; i++)
                    {
                        Console.WriteLine("Ingrese el " + i + " numero del vector");
                        vector[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("\nDatos del vector");
                    for (int i = 0; i < vector.Length; i++)
                    {
                        
                        Console.WriteLine(vector[i]);
                    }


                    Console.WriteLine("Vector llenado correctamente, presione una tecla para continuar");
                    Console.ReadKey();

                }
                else if(opcion == 2)
                {
                    Console.Clear();
                    if (contador == 0)
                    {
                        Console.WriteLine("No se pueden mostrar datos, el vector está vacio, primero llenelo");
                    }
                    else
                    {

                        /*Console.WriteLine("\nMostrando los datos del vector de forma desorganizada");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }*/

                        Console.WriteLine("\nMostrando los datos del vector de forma organizada");

                        Burbuja burbuja = new Burbuja();
                        burbuja.MetodoOrdenar(vector);
                        burbuja.imprimir();
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();

                }
                else if(opcion == 3)
                {
                    Console.Clear();

                    if(contador == 0)
                    {
                        Console.WriteLine("No se pueden mostrar datos, el vector está vacio, primero llenelo");
                    }
                    else
                    {
                        /*Console.WriteLine("\nMostrando los datos del vector de forma desorganizada");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }*/

                        Console.WriteLine("\nMostrando los datos del vector de forma organizada");
                        Shell shell = new Shell();
                        shell.MetodoOrdenar(vector);
                        shell.imprimir();
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();

                }
                else if(opcion == 4)
                {
                    Console.Clear();
                    if (contador == 0)
                    {
                        Console.WriteLine("No se pueden mostrar datos, el vector está vacio, primero llenelo");
                    }
                    else
                    {
                        /*Console.WriteLine("\nMostrando los datos del vector de forma desorganizada");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }*/

                        Console.WriteLine("\nMostrando los datos del vector de forma organizada");
                        Seleccion seleccion = new Seleccion();
                        seleccion.MetodoOrdenar(vector);
                        seleccion.imprimir();
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();

                }
                else if(opcion == 5)
                {
                    Console.Clear();
                    if (contador == 0)
                    {
                        Console.WriteLine("No se pueden mostrar datos, el vector está vacio, primero llenelo");
                    }
                    else
                    {
                        /*Console.WriteLine("\nMostrando los datos del vector de forma desorganizada");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }*/

                        Console.WriteLine("\nMostrando los datos del vector de forma organizada");
                        Insercion insercion = new Insercion();
                        insercion.MetodoOrdenar(vector);
                        insercion.imprimir();
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();


                }
                else if(opcion == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ha salido del programa");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("El numero ingresado no es valido");
                }
            }




            //int[] vector = new int[11] { 1, 3, 4, 2, 54, 6, 7, 4, 3, 2, 2 };
            //Burbuja burbuja = new Burbuja();
            //burbuja.MetodoOrdenar(vector);

            //Insercion inse = new Insercion();
            //inse.MetodoOrdenar(vector);
        }
    }
}
