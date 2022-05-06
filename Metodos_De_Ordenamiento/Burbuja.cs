using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Ordenamiento
{
    public class Burbuja : Ordenamiento
    {
        int[] burbuja;
        public override void MetodoOrdenar(int[] vector)
        {
            try
            {

                burbuja = vector;

                int aux = 0;

                for(int i = 1; i < burbuja.Length; i++)
                {
                    for(int j = 0; j < burbuja.Length - 1; j++)
                    {
                        if(burbuja[j] > burbuja[j + 1])
                        {
                            aux = burbuja[j + 1];
                            burbuja[j + 1] = burbuja[j];
                            burbuja[j] = aux;
                        }
                    }
                }


                using (StreamWriter escribirArchivo = new StreamWriter("D:/burbuja.txt", false))
                {
                    escribirArchivo.WriteLine("Método burbuja organizado ascendentemente");
                    for (int i = 0; i < burbuja.Length; i++)
                    {
                        escribirArchivo.WriteLine(burbuja[i].ToString());

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al intentar crear el archivo" + error.Message);
            }

        }

        public void imprimir()
        {
            for (int i = 0; i < burbuja.Length; i++)
            {
                Console.WriteLine(burbuja[i]);
            }
        }
    }
}
