using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extracto_de_puntos.Clases
{
    class Extracto
    {
       private string nombre_cliente;
       private UInt32 nro_ID;
       private UInt64 telefono;
       private UInt64 saldo_puntos;

        public string Nombre_cliente
        {
         get { return nombre_cliente.ToUpper(); }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5) throw new Exception("El nombre no cumple los requisitos");
                else nombre_cliente = value.ToUpper();
            }
         }
        public uint Nro_ID
        {
         get { return nro_ID; }
         set
         {
                if (value > 0)
                {
                    nro_ID = value;
                }
                else throw new Exception("Numero del ID no cumple");
                
         }
        }


        public ulong Telefono
        {
         get { return telefono; }
         set
            {
                if (value >= 1000000 && value <= 9999999999)
                {
                    telefono = value;
                }
                else throw new Exception("Numero de telefono invlido");
            }
        }
        public ulong Saldo_puntos  { get => saldo_puntos; }

        public Extracto(string nombre_cliente, uint nro_ID, ulong telefono)
        {
            try
            {
                this.nombre_cliente = nombre_cliente;
                this.nro_ID = nro_ID;
                this.telefono = telefono;
            }
            catch (Exception)
            {
                throw new Exception("Problema al crear el objeto");
            }
        }

        public ulong Acumular_Puntos(ulong Vlr_Compra)
        {
            ulong Vlr_Acumulado = 0;
            try
            { 
              //if(Vlr_Compra >= 100)
               Vlr_Acumulado = Vlr_Compra / 100;             
                return Vlr_Acumulado;
            }
            catch (Exception)
            {
                return Vlr_Acumulado;
            }
        }

        public bool Redimir_Puntos(ulong Puntos)
        {
            
            try
            {
                if(saldo_puntos >= Puntos)
                {
                    saldo_puntos -= Puntos;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
