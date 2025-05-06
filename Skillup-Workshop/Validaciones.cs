namespace skillupWorkshop
{
    public class Validaciones
    {
        public static void ValidarNombre(string Nombre)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío y debe tener al menos 3 caracteres.");
            }
        }
        public static void ValidarDescripcion(string descripcion)
        {
            if (descripcion.Length > 355)
            {
            throw new ArgumentException("La descripción debe ser breve (Menos de 355 caracteres)");
            }
        }

        public static void ValidarCosto(double costo)
        {
            if (costo < 0)
            {
            throw new ArgumentException("El costo no puede ser negativo.");
            }
        }

        public static void ValidarFecha(DateTime fecha)
        {
            if (fecha < DateTime.Now)
                throw new ArgumentException("La fecha no puede ser anterior a la actual");
        }

        public static void ValidarDuracion(int duracion)
        {
            if (duracion <= 0)
                throw new ArgumentException("La duración debe ser mayor a cero");
        }
    }
}