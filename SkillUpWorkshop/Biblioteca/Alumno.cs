namespace Biblioteca
{
    public class Alumno
    {
         private string nombre;
        private string apellido;
        public DateTime Nacimiento { get; private set; }
        private string correo;
        private string teléfono;
        private string dirección;
        private string contactoEmergente;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                Validaciones.Longitud(value);
                nombre = value;
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                Validaciones.Longitud(value);
                apellido = value;
            }
        }
        public string Correo
        {
            get { return correo; }
            set
            {
                Validaciones.Correo(value);
                correo = value;
            }
        }
        public string Teléfono
        {
            get { return teléfono; }
            set
            {
                Validaciones.Teléfono(value);
                teléfono = value;
            }
        }
        public string Dirección
        {
            get { return dirección; }
            set
            {
                Validaciones.Dirección(value);
                dirección = value;
            }
        }
        public string ContactoEmergente
        {
            get { return contactoEmergente; }
            set
            {
                Validaciones.Teléfono(value);
                contactoEmergente = value;
            }
        }
        public Alumno(string Nombre, string Apellido, DateTime Nacimiento, string Correo, string Teléfono, string Dirección, string ContactoEmergente)
        {
            Validaciones.Longitud(Nombre);
            this.Nombre = Nombre;
            Validaciones.Longitud(Apellido);
            this.Apellido = Apellido;
            Validaciones.Nacimiento(Nacimiento);
            this.Nacimiento = Nacimiento;
            Validaciones.Correo(Correo);
            this.Correo = Correo;
            Validaciones.Teléfono(Teléfono);
            this.Teléfono = Teléfono;
            Validaciones.Dirección(Dirección);
            this.Dirección = Dirección;
            Validaciones.Teléfono(ContactoEmergente);
            this.ContactoEmergente = ContactoEmergente;
        }
        public static Alumno CrearAlumno()
        {
            Console.WriteLine("\t------ Rellenar datos del Alumno ------");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine()!;

            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine()!;

            Console.WriteLine("Nacimiento (yyyy-MM-dd): ");
            DateTime nacimiento = DateTime.Parse(Console.ReadLine()!);

            Console.WriteLine("Correo: ");
            string correo = Console.ReadLine()!;

            Console.WriteLine("Teléfono: ");
            string teléfono = Console.ReadLine()!;

            Console.WriteLine("Dirección: ");
            string dirección = Console.ReadLine()!;

            Console.WriteLine("Contacto Emergente: ");
            string contactoEmergente = Console.ReadLine()!;

            return new Alumno(nombre, apellido, nacimiento, correo, teléfono, dirección, contactoEmergente);
        }
        public void MostrarInformación()
        {
            Console.WriteLine($"\t------ Datos del Alumno {nombre} {apellido} ------");
            Console.WriteLine($"Nombre Completo: {nombre} {apellido}");
            Console.WriteLine($"Nacimiento: {Nacimiento}");
            Console.WriteLine($"Correo: {correo}");
            Console.WriteLine($"Teléfono: {teléfono}");
            Console.WriteLine($"Dirección: {dirección}");
            Console.WriteLine($"Contacto de Emergencia: {contactoEmergente}");
        }
    }
}