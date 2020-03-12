using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea_tripulacion.Clases
{
    class Pasajero: Persona
    {
        public enum categoria { Basico, Plata, Oro, Diamante};

        private categoria tipo_Categoria;
        private ulong nro_tarjetaFrecuente;

        public Pasajero(categoria tipo_Categoria, ulong nro_tarjetaFrecuente, string nro_Identif, string nombre_Completo, string telefono_Contacto, string nacionalidad) 
         :base(nro_Identif,nombre_Completo,telefono_Contacto,nacionalidad)
        {
            this.tipo_Categoria = tipo_Categoria;
            this.nro_tarjetaFrecuente = nro_tarjetaFrecuente;
        }
    }
}
