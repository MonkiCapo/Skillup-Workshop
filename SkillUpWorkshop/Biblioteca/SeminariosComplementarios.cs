namespace Biblioteca
{
    public class SeminariosComplementarios : ActividadesComplementarias
    {
        public SeminariosComplementarios(string Titulo, int CupoMaximo, DateTime Fecha, bool PermiteInscripción, bool RequierePaga, bool PublicoExterno, Instructor responsable, EspacioFísico FisicoEspacio) : base(Titulo, CupoMaximo, Fecha, PermiteInscripción, RequierePaga, PublicoExterno, responsable, FisicoEspacio)
        {

        }
        public void MostrarDetalle()
        {
             Console.WriteLine($"Actividad: {Titulo}, Responsable: {Responsable}, Espacio: {FisicoEspacio}, Cupo: {CupoMaximo}, Fecha: {Fecha}");
        }
    }
}