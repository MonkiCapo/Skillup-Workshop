using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class EspacioFísico
    {
        // Terminado
        public string Lugar {get; private set;}
        public string Dirección{get; private set;}
        public ushort CapacidadMax{get; private set;}
        public bool AccesoMovilidadReducida{get; private set;}
        public EspacioFísico(string Lugar, string Dirección, ushort CapacidadMax, bool AccesoMovilidadReducida){
            Validaciones.Dirección(Lugar);
            this.Lugar=Lugar;
            Validaciones.Dirección(Dirección);
            this.Dirección=Dirección;
            this.CapacidadMax=CapacidadMax;
            this.AccesoMovilidadReducida=AccesoMovilidadReducida; 
        }
    }
}