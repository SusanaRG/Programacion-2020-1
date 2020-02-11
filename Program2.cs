using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicleta.Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //instanciar objeto bicicleta 

                Bicicleta Mongoose = new Bicicleta();

                //Ponemos info a los atributos de la bicicleta

                Mongoose.Marca = "Moongose";
                Mongoose.Material = "Aluminio";
                Mongoose.TamanoLlanta = 17;
                Mongoose.TamanoMarco = 28;
                Mongoose.VelocidadActual = 0;
                Mongoose.CambioActual = 1;
                Mongoose.NumeroCambios = 7;
                Mongoose.VelocidadMaxima = 50;


                Bicicleta Santa_Cruz = new Bicicleta("", "Carbono", 18, 20);


                Console.WriteLine("La bicicleta " + Santa_Cruz.Marca + " Tiene una llanta " + Santa_Cruz.TamanoLlanta + "'' y un marco " + Santa_Cruz.TamanoMarco + "'' ");


            }
            catch (Exception error)
            {
                Console.WriteLine("error: " + error);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
