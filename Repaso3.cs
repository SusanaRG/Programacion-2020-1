using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string opcion;

                Int16[,] Matriz = new Int16[4, 5];
                List<int> ListaPpal = new List<int>();

                Random NroAleatorio = new Random();

                for(short i = 0; i<4; i++)
                {
                    for(short j = 0; j < 5; j++)
                    {
                        Matriz[i , j] = (Int16)NroAleatorio.Next(1, 9);
                    }
                }
                Console.WriteLine("El resultado es" + SumaMatriz(Matriz));

                ListaPpal = SumFil_SumCol(Matriz, 4, 5);

                if (ListaPpal.Count == 0) Console.WriteLine("La lista está vacía");
                else
                {
                    foreach(Int16 elemento in ListaPpal)
                    {
                        Console.WriteLine(elemento);
                    }
                }

                
               /* do
                {

                    opcion = menu();
               
                    switch (opcion.Substring(0))
                    {

                        case "1":
                            op1();
                            break;
                        case "2":
                            op2();
                            break;
                        case "3":
                            op3();
                            break;
                        case "S":
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        default:
                            Console.WriteLine("Opción Inválida");
                            break;
                    }

                }
                
                while (!opcion.Equals("S"));
                //los string se comparan con equals
*/
            }

            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ocurrió Error en " + error);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            }

            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fin de Ejecución");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
        }

        public static int SumaMatriz(Int16[,] matriz)
        {
            int resultado = 0;
            for(short i = 0; i < 4; i++)
            {
                for(short j = 0; j< 5; j++)
                {
                    resultado += matriz[i,j];
                }
                
            }
            return resultado;
        }

        public static List<int>  SumFil_SumCol(Int16[,] matriz, short nrofil, short nrocol)
        {
            List<int> ListaResult = new List<int>();
            int sumFil = 0, sumCol = 0;


            try
            {
              for(short i = 0; i < nrofil ; i++)
                {
                    for(short j = 0; j < nrocol; j++)
                    {
                        sumFil += matriz[i, j];
                    }
                }

                for (short i = 0; i <nrocol; i++)
                {
                    for (short j = 0; j < nrofil; j++)
                    {
                        sumCol += matriz[j , i];
                    }
                }
                ListaResult.Add(sumFil);
                ListaResult.Add(sumCol);
            }

            catch(Exception Error)
            {
                Console.WriteLine("ocurrio un error en subrutina SumFil_Sumcol" + Error);
            }

            return ListaResult;
        }

        public static string menu()
        {
            string opcion;

            Console.WriteLine("****** Digite su opción ******");
            Console.WriteLine("1. Opcion 1");
            Console.WriteLine("2. Opcion 2");
            Console.WriteLine("3. Opcion 3");
            Console.WriteLine("S. Salir");

            opcion = Console.ReadLine();

            return opcion;

        }
        public static void op1()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void op2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void op3()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }

}
}
