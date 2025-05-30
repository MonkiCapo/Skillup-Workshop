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
        private string? lugar;
        private string? dirección;
        public uint CapacidadMax { get; private set; }
        public bool AccesoMovilidadReducida;
        public string Lugar{get {return lugar!;}set{
                Validaciones.Dirección(value);
                lugar = value;
            }
        }
        public string Dirección{get{ return dirección!;} set{
                Validaciones.Dirección(value);
                dirección = value;
            } 
        }
        public EspacioFísico(string Lugar, string Dirección, uint CapacidadMax, bool AccesoMovilidadReducida)
        {
            Validaciones.Dirección(Lugar);
            this.Lugar = Lugar;
            Validaciones.Dirección(Dirección);
            this.Dirección = Dirección;
            this.CapacidadMax = CapacidadMax;
            this.AccesoMovilidadReducida = AccesoMovilidadReducida;
        }
    }
}
