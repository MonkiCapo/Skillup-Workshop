namespace Biblioteca
{
    public class CharlasComplementarias : ActividadesComplementarias
    {

        public CharlasComplementarias(string Titulo, int CupoMaximo, DateTime Fecha, bool PermiteInscripción, bool RequierePaga, bool PublicoExterno, Instructor responsable, EspacioFísico FisicoEspacio) : base(Titulo, CupoMaximo, Fecha, PermiteInscripción, RequierePaga, PublicoExterno, responsable, FisicoEspacio)
        {
            
        }
    }
}