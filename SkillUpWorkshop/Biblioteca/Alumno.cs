namespace Biblioteca
{
    public class Alumno : Usuario
    {
        public DateTime FechaNacimiento { get; private set; }
        public string Dirección { get; private set; }
        public string ContactoEmergente { get; private set; }
        public List<Evaluacion> Evaluaciones { get; private set; }
        public List<Evaluacion> Devoluciones { get; private set; }
        public List<object> Notificaciones { get; private set; }

        public Alumno(string nombre, string apellido, string correo, string teléfono, DateTime nacimiento, string dirección, string contactoEmergente)
            : base(nombre, apellido, correo, teléfono)
        {
            FechaNacimiento = nacimiento;
            Dirección = dirección;
            ContactoEmergente = contactoEmergente;
            Evaluaciones = new List<Evaluacion>();
            Devoluciones = new List<Evaluacion>();
            Notificaciones = new List<object>();
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

            return new Alumno(nombre, apellido, correo, teléfono, nacimiento, dirección, contactoEmergente);
        }

        public void MostrarInformación()
        {
            Console.WriteLine($"\t------ Datos del Alumno {Nombre} {Apellido} ------");
            Console.WriteLine($"Nombre Completo: {Nombre} {Apellido}");
            Console.WriteLine($"Nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Teléfono: {Teléfono}");
            Console.WriteLine($"Dirección: {Dirección}");
            Console.WriteLine($"Contacto de Emergencia: {ContactoEmergente}");
        }
        public void VerHistorial()
        {
            Console.WriteLine("Historial de actividades del alumno:");
            if (Evaluaciones == null || Evaluaciones.Count == 0)
            {
                Console.WriteLine("No hay evaluaciones registradas.");
                return;
            }
            else
            {
                foreach (var evaluacion in Evaluaciones)
                {
                    Console.WriteLine($"- {evaluacion.TipoEvaluacion}: {evaluacion}");
                }
            }
        }

        public void VerInscripciones(List<Taller> talleres)
        {
            Console.WriteLine("Historial de inscrcipciones");
            foreach (Taller taller in talleres) {
                foreach (Inscripción inscripción1 in taller.inscripción) {
                    if (inscripción1.alumno==this) {
                        Console.WriteLine($"Taller: {inscripción1.taller.Nombre}");
                    }
                }
            }
            // if (taller.inscripciones)
        }
        public void InscribirseTaller()
        {
            Console.WriteLine("Inscripción a talleres:");
            Console.WriteLine("Seleccione un taller para inscribirse:");
        }
        public void VerCalificaciones()
        {
            Console.WriteLine("Calificaciones del alumno:");
            if (Devoluciones == null || Devoluciones.Count == 0)
            {
                Console.WriteLine("No hay calificaciones registradas.");
                return;
            }
            else
            { 
                foreach (var devolucion in Devoluciones)
                {
                    Console.WriteLine($"- {devolucion.TipoEvaluacion}: {devolucion.Observacion} (Puntaje: {devolucion.PorcentajeAprobacion}%)");
                }
            }
        }
        public void VerNotificaciones()
        {
            Console.WriteLine("\t------ Notificaciones ------");
            if (Notificaciones == null || Notificaciones.Count == 0)
            {
                Console.WriteLine("No hay notificaciones.");
                return;
            }
            foreach (var notificacion in Notificaciones)
            {
                Console.WriteLine($"- {notificacion}");
            }
        }

        public override void MostrarMenu(List<Taller> talleres, List<Instructor> instructors, List<Alumno> alumnos)
        {
            Console.WriteLine("1. Ver historial\n2. Inscribirse en taller\n3. Ver calificaciones\n4. Ver notificaciones");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":
                    VerHistorial();
                    break;
                case "2":
                    InscribirseTaller();
                    break;
                case "3":
                    VerCalificaciones();
                    break;
                case "4":
                    VerNotificaciones();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}