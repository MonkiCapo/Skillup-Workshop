namespace skillupWorkshop
{
    public class Taller
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("El nombre no puede estar vacío");
                _nombre = value;
            }
        }
        public Taller(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }













}