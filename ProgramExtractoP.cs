using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extracto_de_puntos
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine(Puntos_Articulo());
        }

       public static uint Puntos_Articulo()
        {
            uint Puntos = 0;
            short Opcion = 0;
            try
            {
                do
                {
                    Console.WriteLine("1. Artículo de decoración ==> 5.000 Puntos ");
                    Console.WriteLine("2. Artículo Electrónico menor ==> 10.000 Puntos ");
                    Console.WriteLine("3. Artículo Electrónico mediano ==> 50.000 Puntos ");
                    Console.WriteLine("4. Tiquete nacional un trayecto ==> 90.000 Puntos ");
                    Console.WriteLine("5. Artículo Electrónico grande ==> 150.000 Puntos ");
                    Console.WriteLine("6. Tiquete nacional RoundTrip ==> 180.000 Puntos ");
                    Console.WriteLine("Escriba su opción");

                    try
                    {
                        Opcion = short.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Opcion = 0;
                    }

                } while (Opcion < 1 && Opcion < 6);

                return Puntos;
            }
            catch (Exception)
            {
                return Puntos;
            }
           
        }


    }
}
