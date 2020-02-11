using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicleta.Clases
{
    class Bicicleta
    {
        //tipos de datos
        public enum lista_colores { Rojo, Negro, Azul, Naranja };

        //Atributos
        //public string Color;
        private string marca;
        private string material;
        private float tamanoMarco = 0F;
        private float tamanoLlanta = 0F;
        private short numeroCambios;
        private short cambioActual;
        private short velocidadActual;
        private short velocidadMaxima;

        public lista_colores Color;

        //construidos
        public string Marca
        {
            get
            {
                return marca.ToUpper();

            }
            set
            {
                if (Validar_Marca(value)) marca = value.ToUpper();
                else throw new Exception($"{nameof(value)} debe ser mayor o igual a 3 caracteres");
            }
        }

        //public string Marca { get => marca; set => marca = value; }
        public string Material { get => material.ToUpper(); set => material = value; }
        public float TamanoMarco { get => tamanoMarco; set => tamanoMarco = value; }
        public float TamanoLlanta { get => tamanoLlanta; set => tamanoLlanta = value; }
        public short NumeroCambios { get => numeroCambios; set => numeroCambios = value; }
        public short CambioActual { get => cambioActual; set => cambioActual = value; }
        public short VelocidadActual { get => velocidadActual; set => velocidadActual = value; }
        public short VelocidadMaxima { get => velocidadMaxima; set => velocidadMaxima = value; }

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

        //subrrutinas
        public bool Validar_Marca(string marca)
        {
            try
            {
                if (marca.Length >= 3 && !String.IsNullOrEmpty(marca) && !String.IsNullOrWhiteSpace(marca))
                    return true;
                else return false;
            }

            catch(Exception)
            {
                return false;
                throw new Exception("Error en subrutina Validar_Marca");
            }
        }
    }
}
