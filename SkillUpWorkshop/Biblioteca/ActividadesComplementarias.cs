namespace Biblioteca
{
    public abstract class ActividadesComplementarias
    {
        public string Titulo { get; set; }
        public int CupoMaximo { get; set; }
        public DateTime Fecha { get; set; }
        public bool PermiteInscripción { get; set; }
        public bool RequierePaga { get; set; }
        public bool PublicoExterno { get; set; }
        public EspacioFísico FisicoEspacio { get; set; }
        public Instructor Responsable { get; set; }
        public List<DateTime> Sesiones { get; set;}
        public ActividadesComplementarias(string Titulo, int CupoMaximo, DateTime Fecha, bool PermiteInscripción, bool RequierePaga, bool PublicoExterno, Instructor responsable, EspacioFísico FisicoEspacio)
        {
            Validaciones.Longitud(Titulo);
            this.Titulo = Titulo;
            Responsable = responsable;
            this.FisicoEspacio = FisicoEspacio;
            this.PermiteInscripción = PermiteInscripción;
            this.RequierePaga = RequierePaga;
            this.PublicoExterno = PublicoExterno;
            this.CupoMaximo = CupoMaximo;
            this.Fecha = Fecha;
            Sesiones = new List<DateTime>();
        }

        // Método virtual que puede ser sobreescrito
        public virtual void MostrarDetalle()
        {
            Console.WriteLine($"Actividad: {Titulo}, Responsable: {Responsable}, Espacio: {FisicoEspacio}, Cupo: {CupoMaximo}, Fecha: {Fecha}");
        }
    }
}