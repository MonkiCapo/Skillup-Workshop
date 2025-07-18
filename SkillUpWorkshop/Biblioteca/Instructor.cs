using System.ComponentModel.Design;

namespace Biblioteca
{
    public class Instructor : Usuario
    {
        public string DNI { get; set; }
        public string Especialidad { get; set; }
        public bool Asignado { get; private set; }
        public bool Disponible { get; set; }

        public Instructor(string nombre, string apellido, string correo, string teléfono, string dni, string especialidad)
            : base(nombre, apellido, correo, teléfono)
        {
            DNI = dni;
            Especialidad = especialidad;
            Disponible = true;
        }

        public void SetOcupado(bool asignado)
        {
            if (Asignado is false && asignado is true)
            {
                Asignado = true;
            }
        }
        public static Instructor CrearInstructor()
        {
            Console.WriteLine("\t------ Rellenar datos del Instructor ------");
            Console.Write("Nombre: ");
            string Inombre = Console.ReadLine()!;

            Console.Write("Apellido: ");
            string Iapellido = Console.ReadLine()!;

            Console.Write("Correo: ");
            string Icorreo = Console.ReadLine()!;

            Console.Write("Teléfono: ");
            string teléfono = Console.ReadLine()!;

            Console.Write("DNI: ");
            string DNI = Console.ReadLine()!;

            Console.Write("Especialidad: ");
            string especialidad = Console.ReadLine()!;

            return new Instructor(Inombre, Iapellido, Icorreo, DNI, teléfono, especialidad);
        }
        public void MarcarAsistencia()
        {
            
        } 
        public void CorregirEvaluaciones(Evaluacion evaluacion, int puntaje)
        {
            if (evaluacion is EvaluacionEscrita)
            {
                Console.WriteLine("Corregir evaluación escrita:");
                Console.Write("Ingrese observación: ");
                string Observacion = Console.ReadLine()!;
                evaluacion.Devolucion(Observacion, puntaje);
            }
            else if (evaluacion is EvaluacionPractica)
            {
                Console.WriteLine("Corregir evaluación práctica:");

                Console.Write("Ingrese observación: "); string Observacion = Console.ReadLine()!;
                Console.WriteLine("Ingrese desempeño: "); string Desempeño = Console.ReadLine()!;
                Console.WriteLine("Ingrese cumplimiento de objetivos: "); string CumplimientoObjetivos = Console.ReadLine()!;
                Console.WriteLine("Ingrese ejecución: "); string Ejecución = Console.ReadLine()!;

                ((EvaluacionPractica)evaluacion).RegistrarObservacionDesempeño(Desempeño, CumplimientoObjetivos, Ejecución);
                evaluacion.Devolucion(Observacion, puntaje);
            }
        }
        public void VerTalleresAsignados(List<Taller> talleres)
        {
            Console.WriteLine("\t------ Talleres Asignados ------");
            foreach (var asignado in talleres)
            {
                if (asignado.instructor == this)
                { 
                    Console.WriteLine($"- Taller: {asignado.Nombre}, Dificultad: {asignado.Dificultad}");
                }
            }
         }
        public void ContactarAlumnos(Alumno alumno, string mensaje)
        {
            alumno.Notificaciones.Add(mensaje);
            Console.WriteLine($"Mensaje enviado a {alumno.Nombre} {alumno.Apellido}: {mensaje}");
        }
        public override void MostrarMenu(List<Taller> talleres, List<Instructor> instructors, List<Alumno> alumnos)
        {
            Regresar:
            Console.WriteLine("1. Ver talleres asignados\n2. Corregir evaluaciones\n3. Marcar asistencia\n4. Contactar alumnos\n5. Crear Evaluación");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":
                    VerTalleresAsignados(talleres);
                    goto Regresar;
                case "2":
                    foreach (Taller taller in talleres)
                    {
                        if (taller.instructor == this)
                        {
                            int i1 = 1;
                            foreach (Evaluacion evaluacion in taller.Evaluaciones)
                            {
                                Console.WriteLine($"{i1}- {evaluacion.TipoEvaluacion}\n Alumno: {evaluacion.alumno}. Puntuación {evaluacion.PuntajeMaximo}, Taller: {evaluacion.taller.Nombre}");
                                ++i1;
                            }
                        }
                        Console.Write("Seleccione la evaluación: ");
                        int Eleccion = int.Parse(Console.ReadLine()!);
                        Evaluacion evaluacionElegida = taller.Evaluaciones[Eleccion];
                        Console.Write("Puntaje: ");
                        byte puntaje = byte.Parse(Console.ReadLine()!);
                        CorregirEvaluaciones(evaluacionElegida, puntaje);
                    }
                    Thread.Sleep(2000);
                    goto Regresar;
                case "3":
                    MarcarAsistencia();
                    break;
                case "4":
                    foreach (Taller taller in talleres)
                    {
                        if (taller.instructor == this)
                        {
                            foreach (Inscripción inscripcion1 in taller.inscripción)
                            {
                                if (inscripcion1.Estado == "Activo")
                                {
                                    int i2 = 0;
                                    Console.WriteLine($"{i2} - Nombre:{inscripcion1.alumno.Nombre}, {inscripcion1.alumno.Apellido}\n Taller{inscripcion1.taller.Nombre}");
                                    ++i2;
                                }
                            }
                        }
                        Console.Write("A quien le enviaras este mensaje?");
                        int alumnoSeleccionado2 = int.Parse(Console.ReadLine()!);
                        Console.WriteLine("Mensaje a enviar: ");
                        string mensaje = Console.ReadLine()!;
                        Alumno receptor = taller.inscripción[alumnoSeleccionado2].alumno;
                        ContactarAlumnos(receptor, mensaje);
                    }
                    goto Regresar;

                case "5":
                    Console.WriteLine("Crear Evaluación:");
                    Console.Write("Ingrese el tipo de evaluación (Escrita/Práctica): ");
                    string tipoEvaluacion = Console.ReadLine()!;
                    
                    Console.Write("Seleccione el alumno: ");
                    int i = 1;
                    foreach (Alumno alumno in alumnos)
                    {
                        Console.WriteLine($"{i} - {alumno.Nombre} {alumno.Apellido}");
                        ++i;
                    }
                    int alumnoSeleccionado = int.Parse(Console.ReadLine()!);
                    
                    Console.Write("Seleccione el taller: ");
                    i = 1;
                    foreach (Taller taller in talleres)
                    {
                        Console.WriteLine($"{i} - {taller.Nombre}");
                        ++i;
                    }
                    int tallerSeleccionado = int.Parse(Console.ReadLine()!);

                    Alumno alumnoElegido = alumnos[alumnoSeleccionado-1];
                    Taller tallerElegido = talleres[tallerSeleccionado-1];

                    Evaluacion nuevaEvaluacion;
                    if (tipoEvaluacion.Equals("Escrita", StringComparison.OrdinalIgnoreCase))
                    {
                        nuevaEvaluacion = new EvaluacionEscrita(alumnoElegido, tallerElegido);
                    }
                    else
                    {
                        nuevaEvaluacion = new EvaluacionPractica(alumnoElegido, tallerElegido);
                    }
                    alumnoElegido.Evaluaciones.Add(nuevaEvaluacion);
                    tallerElegido.Evaluaciones.Add(nuevaEvaluacion);
                    Console.WriteLine("Evaluación creada exitosamente.");
                    Console.WriteLine("Regresando...");
                    Thread.Sleep(2000);
                    goto Regresar;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}