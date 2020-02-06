using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicicleta
{
    class Bicicleta
    {
        //tipos de datos
        public enum lista_colores { Rojo, Negro, Azul, Naranja };

        //Atributos
        public string Marca;
        //public string Color;
        public string Material;
        public float TamanoMarco = 0F;
        public float TamanoLlanta = 0F;
        public short NumeroCambios;
        public short CambioActual;
        public short VelocidadActual;
        public short VelocidadMaxima;
     
        public lista_colores Color;

        //Constructor
        public Bicicleta()
        {
            try
            {

            }
            catch (Exception Error)
            {

            }
        }

        public Bicicleta(string Marca, string Material, float TamanoLlanta, float TamanoMarco)
        {
            string msg_error = "";
            try
            {
                if (Marca.Length >= 2) this.Marca = Marca.ToUpper();
                else
                {
                    msg_error = "Error en el atributo marca";
                    throw new Exception("Error en el atributo marca");
                }

                this.Material = Material;
                this.TamanoLlanta = TamanoLlanta;
                this.TamanoMarco = TamanoMarco;

                VelocidadActual = 0;
                VelocidadMaxima = 50;
                CambioActual = 1;
                NumeroCambios = 7;
            }
            catch (Exception Error)
            {
                 throw new Exception("" + Error);
            }
        }

        //Metodos
        public void Acelerar(short Vel_Objetivo)
        {
            try
            {

            }
            catch (Exception Error)
            {

            }
        }

        public void Desacelerar(short Vel_Objetivo)
        {
            try
            {

            }
            catch (Exception Error)
            {

            }
        }

        public void SubirCambio()
        {
            try
            {

            }
            catch (Exception Error)
            {

            }
        }

        public void SubirCambio(short CambioFinal)
        {
            try
            {

            }
            catch (Exception Error)
            {

            }
        }

        public void BajarCambio()
        {
            try
            {

            }
            catch (Exception Error)
            {

            }
        }

        public void BajarCambio(short CambioFinal)
        {
            try
            {

            }
            catch (Exception Error)
            {

            }
        }
    }
}
