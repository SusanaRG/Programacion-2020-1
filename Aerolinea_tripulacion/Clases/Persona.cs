using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea_tripulacion.Clases
{
    class Persona
    {
        private string nro_Identif;
        private string nombre_Completo;
        private string telefono_Contacto;
        private string nacionalidad;


        public string Nro_Identif { get => nro_Identif; }
        public string Nombre_Completo { get => nombre_Completo; }
        public string Telefono_Contacto { get => telefono_Contacto;}
        public string Nacionalidad { get => nacionalidad;}

        public Persona(string nro_Identif, string nombre_Completo, string telefono_Contacto, string nacionalidad)
        {
            this.nro_Identif = nro_Identif;
            this.nombre_Completo = nombre_Completo;
            this.telefono_Contacto = telefono_Contacto;
            this.nacionalidad = nacionalidad;
        }

 
    }
}
