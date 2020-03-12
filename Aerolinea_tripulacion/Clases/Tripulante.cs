using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea_tripulacion.Clases
{
    class Tripulante:Persona
    {
        private UInt16 antiguedad;
        private string nro_Carnet;
        private UInt32 horas_Vuelo;
        private string licencia_Vigente;

        public ushort Antiguedad { get => antiguedad; set => antiguedad = value; }
        public string Nro_Carnet { get => nro_Carnet; set => nro_Carnet = value; }
        public uint Horas_Vuelo { get => horas_Vuelo; set => horas_Vuelo = value; }
        public string Licencia_Vigente { get => licencia_Vigente; set => licencia_Vigente = value; }

        public Tripulante(string nro_Identif, string nombre_Completo, string telefono_Contacto, string nacionalidad, ushort antiguedad, string nro_Carnet, uint horas_Vuelo, string licencia_Vigente)
            :base(nro_Identif, nombre_Completo, telefono_Contacto, nacionalidad)
        {
            this.antiguedad = antiguedad;
            this.nro_Carnet = nro_Carnet;
            this.horas_Vuelo = horas_Vuelo;
            this.licencia_Vigente = licencia_Vigente;
        }

        
    }
}
