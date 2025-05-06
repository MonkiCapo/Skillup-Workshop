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
                Validaciones.ValidarNombre(value);
                _nombre = value;
            }
        }

        private string _descripcion; 
        public string Descripcion
        {
            get { return _descripcion; }
            private set
            {
                Validaciones.ValidarDescripcion(value);
                _descripcion = value;
            }
        }

        private double _costo;
        public double Costo
        {
            get { return _costo; }
            private set
            {
                Validaciones.ValidarCosto(value);
            _costo = value;
            }
        }
    }













}