using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metodos_De_Ordenamiento
{
    public class Insercion : Ordenamiento
    {

        int[] insercion;

        public override void MetodoOrdenar(int[] vector)
        {
            try
            {
                insercion = vector;
                int aux;
                int j;

                for(int i = 0; i < insercion.Length; i++)
                {
                    aux = insercion[i];
                    j = i - 1;
                    while(j >= 0 && insercion[j] > aux)
                    {
                        insercion[j + 1] = insercion[j];
                        j--;
                    }
                    insercion[j + 1] = aux;
                }

                using (StreamWriter escribirArchivo = new StreamWriter("D:/insercion.txt", false))
                {
                    escribirArchivo.WriteLine("Método de inserción ordenanado de forma ascendente");
                    for (int i = 0; i < insercion.Length; i++)
                    {
                        escribirArchivo.WriteLine(insercion[i].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar crear el archivo" + e.Message);
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < insercion.Length; i++)
            {
                Console.WriteLine(insercion[i]);
            }
        }
    }
    
}
