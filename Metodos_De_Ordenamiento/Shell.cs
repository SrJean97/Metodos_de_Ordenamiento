using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metodos_De_Ordenamiento
{
    public class Shell : Ordenamiento
    {
        int[] shell;
        public override void MetodoOrdenar(int[] vector)
        {
            try
            {
                shell = vector;

                int salto = 0;
                int aux = 0;
                int sw = 0;
                int e = 0;

                salto = shell.Length / 2;

                while(salto > 0)
                {
                    sw = 1;

                    while(sw != 0)
                    {
                        sw = 0;
                        e = 1;

                        while( e <= (shell.Length - salto))
                        {
                            if(shell[e-1] > shell[(e-1) + salto])
                            {
                                aux = shell[(e - 1) + salto];
                                shell[(e - 1) + salto] = shell[e - 1];
                                shell[e - 1] = salto;
                                sw = 1;
                            }
                            e++;
                        }
                    }
                    salto = salto / 2;
                }

                using (StreamWriter escribirArchivo = new StreamWriter("D:/shell.txt", false))
                {
                    escribirArchivo.WriteLine("Método shell organizado ascendentemente");
                    for (int i = 0; i < shell.Length; i++)
                    {
                        escribirArchivo.WriteLine(shell[i].ToString());

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
            for (int i = 0; i < shell.Length; i++)
            {
                Console.WriteLine(shell[i]);
            }
        }
    }
}
