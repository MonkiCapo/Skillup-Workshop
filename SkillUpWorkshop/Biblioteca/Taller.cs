namespace Biblioteca
{
    public class Taller
    {
        private string nombre;
        private string descripción;
        private uint costo; //En pesos
        private byte duración; //En semanas
        private byte cupos;
        private string dificultad;
        public Instructor instructor { get; private set; }
        public EspacioFísico espacioFísico { get; private set; }
        public List<Inscripción> inscripción { get; private set; }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                Validaciones.Longitud(value);
                nombre = value;
            }
        }
        public string Descripción
        {
            get { return descripción; }
            set
            {
                Validaciones.Descripción(value);
                descripción = value;
            }
        }
        public uint Costo
        {
            get { return costo; }
            set
            {
                Validaciones.valorCeroUINT(value);
                costo = value;
            }
        }
        public byte Duración
        {
            get { return duración; }
            set
            {
                Validaciones.valorCeroByte(value);
                duración = value;
            }
        }
        public byte Cupos
        {
            get { return cupos; }
            set
            {
                Validaciones.valorCeroByte(value);
                cupos = value;
            }

        }
        public string Dificultad
        {
            get { return dificultad; }
            set
            {
                Validaciones.Dificultad(value, out value);
                dificultad = value;
            }
        }
        public Taller(string Nombre, string Descripción, uint Costo, byte Duración, byte Cupos, string Dificultad, string Lugar, string Dirección, uint CapacidadMax, bool AccesoMovilidadReducida)
        {
            Validaciones.Longitud(Nombre);
            this.Nombre = Nombre;
            Validaciones.Descripción(Descripción);
            this.Descripción = Descripción;
            Validaciones.valorCeroUINT(Costo);
            Validaciones.valorCeroByte(Duración);
            Validaciones.valorCeroByte(Cupos);
            this.Costo = Costo;
            duración = Duración;
            cupos = Cupos;
            Validaciones.Dificultad(Dificultad, out Dificultad);
            this.Dificultad = Dificultad;
            instructor = null!;
            espacioFísico = new EspacioFísico(Lugar, Dirección, CapacidadMax, AccesoMovilidadReducida);
            inscripción = new List<Inscripción>();
        }

        public static Taller CrearTaller()
        {
            Console.WriteLine("\t------ Rellenar datos del Taller ------");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()!;

            Console.WriteLine("Descripción: ");
            string descripción = Console.ReadLine()!;

            Console.Write("Costo: ");
            uint costo = uint.Parse(Console.ReadLine()!);

            Console.Write("Duración en semanas: ");
            byte duración = byte.Parse(Console.ReadLine()!);

            Console.Write("Cupos: ");
            byte cupos = byte.Parse(Console.ReadLine()!);

            Console.WriteLine("Facil, Intermedio, Avanzado");
            Console.Write("Dificultad: ");
            string dificultad = Console.ReadLine()!;

            Console.WriteLine("\t------ Rellenar datos del Espacio Físico ------");
            Console.Write("Lugar: ");
            string lugar = Console.ReadLine()!;

            Console.Write("Dirección: ");
            string dirección = Console.ReadLine()!;

            Console.Write("Capacidad máxima: ");
            uint CapacidadMax = uint.Parse(Console.ReadLine()!);

            Console.WriteLine("Acceso para personas con movilidad reducida?(s/n): ");
            string accesible = Console.ReadLine()!.Trim();

            bool AccesoMovilidadReducida = false;
            if (accesible.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                AccesoMovilidadReducida = true;
            }
            return new Taller(nombre, descripción, costo, duración, cupos, dificultad, lugar, dirección, CapacidadMax, AccesoMovilidadReducida);
        }

        public void IniciarInscripción(Alumno alumno, bool Pagó, string Estado)
        {
            if (inscripción?.Count < Cupos)
            {
                inscripción?.Add(new Inscripción(alumno, this, Pagó, Estado));
            }
            else
            {
                throw new ArgumentException("Taller completo.");
            }
        }

        public void EliminarTaller_E_Inscripciones(Taller taller)
        {
            Console.WriteLine($"Eliminando {taller.inscripción?.Count ?? 0} inscripciones del taller: {Nombre}");
            taller.inscripción?.Clear();
        }

        public void MostrarInformación()
        {
            Console.WriteLine($"\t------ Información del Taller {nombre} ------");
            Console.WriteLine($"Descripción: {descripción}");
            Console.WriteLine($"Costo: {costo}");
            Console.WriteLine($"Duración: {duración}");
            Console.WriteLine($"Cupos: {cupos}");
            Console.WriteLine($"Dificultad: {dificultad}\n");
            Console.WriteLine($"Profesor: {(instructor is null ? "Sin asignar" : instructor!.Nombre)}");
            Console.WriteLine("========================");

        }

        public void AsignarInstructor(Instructor instructor)
        {
            if (instructor.Asignado)
            {
                if (!instructor.Disponible)
                {
                    throw new Exception("El instructor no se encuentra disponible para dar más clases.");
                }
                else
                {
                    this.instructor = instructor;
                }
            }
            else
            {
                this.instructor = instructor;
            }
        }

        public void MostrarInscripciones(out int cuposOcupados)
        {
            cuposOcupados = 0;
            foreach (Inscripción inscripcións in inscripción)
            {
                ++cuposOcupados;
                Console.WriteLine($"Alumno: {inscripcións.alumno.Nombre} {inscripcións.alumno.Apellido}\nFecha de Inscripción: {inscripcións.fechaInscripción}\n Pagó {(inscripcións.Pagó ? "Si" : "No")}\nEstado: {inscripcións.Estado}");
                Console.WriteLine("=============================");
            }
        }
        public void CancelarInscripciónDe(Alumno alumno)
        {
            foreach (Inscripción inscripcións in inscripción)
            {
                var InscripciónDeAlumno = inscripción.Find(i => i.alumno == alumno) ?? throw new Exception("Inscripción no encontrada");
                InscripciónDeAlumno.Estado = "Cancelado";
                Console.WriteLine("****** Inscripción cancelada exitosamente ******");
            }
        }
        public void InscripciónDelAlumno(Alumno alumno)
        {
            foreach(Inscripción inscripciónAlumno in inscripción) {
                if (inscripciónAlumno.alumno == alumno)
                {
                    Console.WriteLine($"Taller: {Nombre}\nFecha de Inscripción:{inscripciónAlumno.fechaInscripción}\n Pagó {(inscripciónAlumno.Pagó ? "Si" : "No")}\nEstado: {inscripciónAlumno.Estado}"); 
                    Console.WriteLine("=================");
                }
            }
        }
    }
}