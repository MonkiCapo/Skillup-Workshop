namespace Biblioteca
{
    public class EspacioFísico
    {
        private string? lugar;
        private string? dirección;
        private uint capacidadMax;
        public uint CapacidadMax
        {
            get { return capacidadMax; }
            set
            {
                Validaciones.valorCeroUINT(value);
                capacidadMax = value;
            }
        }
        public bool AccesoMovilidadReducida;
        public string Lugar{get {return lugar!;}set{
                Validaciones.Dirección(value);
                lugar = value;
            }
        }
        public string Dirección
        {
            get { return dirección!; }
            set
            {
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