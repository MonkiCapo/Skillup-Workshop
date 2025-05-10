using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class EspacioFísico
    {
        public string Lugar {get; private set;}
        public string Dirección{get; private set;}
        public byte CapacidadMax{get; private set;}
        public bool AccesoMovilidadReducida;
        public EspacioFísico(string Lugar, string Dirección, byte CapacidadMax, bool AccesoMovilidadReducida){
            this.Lugar=Lugar;
            Validaciones.Dirección(Dirección);
            this.Dirección=Dirección;
            this.CapacidadMax=CapacidadMax;
            this.AccesoMovilidadReducida=AccesoMovilidadReducida;
        }
    }
}
