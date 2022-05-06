using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metodos_De_Ordenamiento
{
    public class Seleccion : Ordenamiento
    {
        int[] seleccion;
        public override void MetodoOrdenar(int[] vector)
        {
            try
            {
                seleccion = vector;
                int menor;
                int posicion;
                int aux;

                for(int i = 0; i < seleccion.Length - 1; i++)
                {
                    menor = seleccion[i];
                    posicion = i;

                    for(int j = i+1; j < seleccion.Length; j++)
                    {
                        if(seleccion[j] < menor)
                        {
                            menor = seleccion[j];
                            posicion = j;
                        }
                    }
                    if(posicion != i)
                    {
                        aux = seleccion[i];
                        seleccion[i] = seleccion[posicion];
                        seleccion[posicion] = aux;
                    }
                }

                //Se hace uso de la clase StreamWriter para la creación de los archivos.
                using (StreamWriter escribirArchivo = new StreamWriter("D:/seleccion.txt", false))
                {
                    escribirArchivo.WriteLine("Método de selección ordenanado de forma ascendente");
                    for(int i = 0; i < seleccion.Length; i++)
                    {
                        escribirArchivo.WriteLine(seleccion[i].ToString());
                    }
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error al intentar crear el archivo" + error.Message);
            } 

        }

        public void imprimir()
        {
            for (int i = 0; i < seleccion.Length; i++)
            {
                Console.WriteLine(seleccion[i]);
            }
        }
    }
}
