﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Skillup_Workshop;

List<string> opciones = new List<string>();
List<Taller> talleres = new List<Taller>
{
    new Taller("Programación", "Enseñamos lenguajes de programación como C#", 15000, 12, 20, "Intermedio", "Retiro", "Av. Libertador 2811", 100, false),
    new Taller("Mecánica Automotriz", "Mantenimiento y reparación de vehiculos", 20000, 25, 25, "Intermedio", "Retiro", "San Martín 473", 100, false),
    new Taller("Programación", "Enseñamos lenguajes de programación como C#.", 32000, 15, 20, "Intermedio", "Retiro", "Av. Libertador 2811", 100, false),
    new Taller("Mecánica Automotriz", "Mantenimiento y reparación de vehiculos.", 40000, 15, 25, "Intermedio", "Retiro", "San Martín 473", 100, false),
    new Taller("Torneria", "Confeccion de piezas.", 25000, 15, 20, "Intermedio", "Retiro", "San Martín 1415", 100, false),
    new Taller("Metales","Confeccion de piezas.", 17000, 15, 20, "Avanzado", "Retiro", "San Martín 7174", 100, false),
    new Taller("Electronica","Confeccion de piezas.", 23000, 15, 20, "Intermedio", "Retiro", "San Martín 1212", 100, false),
    new Taller("Arte","Confeccion de piezas.", 12000, 10, 15, "Facil", "Retiro", "San Martín 3264", 100, true),
    new Taller("Soldadura","Confeccion de piezas.", 33000, 15, 25, "Avanzado", "Retiro", "San Martín 1123", 100, false),
    new Taller("Electricidad", "Confeccion de piezas.", 35000, 15, 25, "Avanzado", "Retiro", "San Martín 7984", 100, false)
};
List<Alumno> alumnos = new List<Alumno>{
    new Alumno("Juan", "Diaz", new DateTime(2000-11-02), "Juanitogolazo@gmail.com", "1123851645", "Fuerta Apache", "1189248116"),
    new Alumno("Alan", "Pascal", new DateTime(2000-07-29), "AlanManchester@gmail.com", "1144228811", "Central Cordoba", "1145468122"),
    new Alumno("Galván", "Gutierrez", new DateTime(2000 - 11 - 22), "GalvanArgentina@gmail.com", "1123458116", "Barracas", "1145812966"),
    new Alumno("Melina", "Medina", new DateTime(2005 - 07 - 09), "MedinaMeninas@gmail.com", "1123283136", "Pompeya", "1144262849"),
    new Alumno("Fernanda", "Fernandez", new DateTime(2007-08-06), "Fernandismo@gmail.com", "1155862162", "Once", "1189172188")
};
List<Instructor> instructors = new List<Instructor>
{
    new Instructor("Carlos", "Pérez", "30123456", "1134567890", "Programación"),
    new Instructor("María", "Gómez", "30234567", "1145678901", "Mecánica Automotriz"),
    new Instructor("Luis", "Fernández", "30345678", "1156789012", "Torneria"),
    new Instructor("Ana", "Martínez", "30456789", "1167890123", "Metales"),
    new Instructor("Jorge", "López", "30567890", "1178901234", "Electricidad")
};
List<Inscripción> inscripcións = new List<Inscripción>
{
    
};


Regresar:
Console.WriteLine("------ Opciones ------");
Console.WriteLine("1. Crear Taller\n2. Crear Instructor\n3. Crear Alumno\n4. Opciones de taller\n5. Opciones alumno\n6. Salir del programa");
    switch (Console.ReadLine())
    {
        case "1":
            try
            {
                talleres.Add(Taller.CrearTaller());
                Console.WriteLine("****** Registro Exitoso ******");
            }
            catch
            {
                Console.WriteLine("Error al crear taller. Volviendo al inicio.");
                goto Regresar;
            }
            Console.WriteLine("Desea continuar?(s/n)");
            if (String.Compare(Console.ReadLine()!.Trim(),"s", true)==0){
                goto Regresar;
            }
            break;
        case "2":
            try
            {
                instructors.Add(Instructor.CrearInstructor());
                Console.WriteLine("****** Registro Exitoso ******");
            }
            catch
            {
                Console.WriteLine("Error al crear instructor. Volviendo al inicio.");
                goto Regresar;
            }
            Console.WriteLine("Desea continuar?(s/n)");
            if (String.Compare(Console.ReadLine()!.Trim(),"s", true)==0){
                goto Regresar;
            }
            break;
        case "3":
            try
            {
                alumnos.Add(Alumno.CrearAlumno());
                Console.WriteLine("****** Registro Exitoso ******");
            }
            catch
            {
                Console.WriteLine("Error al crear alumno. Volviendo al inicio.");
                goto Regresar;
            }
            Console.WriteLine("Desea continuar?(s/n)");
            if (String.Compare(Console.ReadLine()!.Trim(),"s", true)==0){
            goto Regresar;
            }
        break;
        case "4": //Opciones de taller

            Console.WriteLine("------ Lista de Talleres------");
            foreach(Taller t in talleres) {
                Console.WriteLine(t.Nombre);
            }
            Console.WriteLine("Acceder a: ");
            string acceder_A = Console.ReadLine()!.Trim().ToLower();
            Taller tallerAccedido;
            try
            {
                tallerAccedido = talleres.Find(taller => taller.Nombre.ToLower() == acceder_A) ?? throw new ArgumentException("Taller no encontrado");
            }
            catch
            {
                Console.WriteLine("Taller no encontrado. Volviendo al inicio.");
                goto Regresar;
            }
            Console.WriteLine("****** Taller Encontrado ******");
            
            Console.WriteLine("Acciones para realizar: \n 1- Mostrar Información\n 2- Asignar/Desasignar/Cambiar Instructor\n 3- Mostrar Inscripciones\n 4- Eliminar taller");
            switch (Console.ReadLine()){
                case "1":
                    tallerAccedido.MostrarInformación();
                    break;
                case "2":
                    Console.WriteLine("\t------ Lista de instructores disponibles ------");
                    foreach (Instructor instructor in instructors)
                    {
                        if (instructor.Disponible == true)
                        {
                            Console.WriteLine($"Nombre: {instructor.Nombre} DNI: {instructor.DNI} Disponible: {instructor.Disponible}");
                        }
                    }
                    Console.Write("Ponga el DNI del Instructor a elegir: ");
                    string buscarInstructor = Console.ReadLine()!;
                    Instructor InstructorEncontrado;
                    try
                    {
                        InstructorEncontrado = instructors.Find(instructors => instructors.DNI == buscarInstructor) ?? throw new ArgumentException("Instructor no encontrado");
                    }
                    catch
                    {
                        Console.WriteLine("Instructor no encontrado. Volviendo al inicio.");
                        goto Regresar;
                    }
                    tallerAccedido.AsignarInstructor(InstructorEncontrado);
                    Console.WriteLine("\t*** Instructor asignado exitosamente ***");
                    break;
                case "3":
                    Console.WriteLine("=============================");
                    var CuposOcupados = 0;
                    foreach (Inscripción inscripción in inscripcións)
                    {
                        if (inscripción.taller == tallerAccedido)
                        {
                        ++CuposOcupados;
                        Console.WriteLine($"Alumno: {inscripción.alumno.Nombre} {inscripción.alumno.Apellido}\nFecha de Inscripción: {inscripción.fechaInscripción}\n Pagó {(inscripción.Pagó ? "Si" : "No")}\nEstado: {inscripción.Estado}");
                        Console.WriteLine("=============================");
                        }
                    }
                    Console.WriteLine($"Cupos disponibles: {tallerAccedido.cupos-CuposOcupados}\nCupos ocupados: {CuposOcupados}");
                    break;
                case "4":
                    tallerAccedido.EliminarTaller_E_Inscripciones(tallerAccedido);
                    talleres.Remove(tallerAccedido);

                    Console.WriteLine("Desea continuar?(s/n)");
                    if (String.Compare(Console.ReadLine()!.Trim(),"s", true)==0){
                        goto Regresar;
                    }
                break;   
                default:
                    Console.WriteLine("Opción no válida. Volviendo al inicio.");
                    goto Regresar;
                }
            Console.WriteLine("Desea continuar?(s/n)");
            if (String.Compare(Console.ReadLine()!.Trim(), "s", true) == 0)
            {
                goto Regresar;
            }
            break;     
        case "5": //Opciones de Alumno
            Console.WriteLine("Ingrese el correo electrónico del estudiante");
            string buscarCorreo = Console.ReadLine()!;
            Alumno registrado;
            try
            {
                registrado = alumnos.Find(alumno => alumno.Correo== buscarCorreo) ?? throw new ArgumentException("Alumno no encontrado");
            }
            catch
            {
                Console.WriteLine("Alumno no encontrado. Volviendo al inicio.");
                goto Regresar;
            }
            Console.WriteLine("------ Lista de Talleres------");
            foreach(Taller t in talleres) {
                Console.WriteLine(t.Nombre);
            }
            Console.WriteLine("Acciones para realizar: \n 1- Mostrar Información\n 2- Cancelar inscripción\n 3- Iniciar inscripción");
            switch (Console.ReadLine())
            {
                case "1":
                    registrado.MostrarInformación();
                    goto Regresar;
                break;
                case "2":
                    Console.WriteLine($"------ Inscripciones del Alumno ------");
                    foreach (Inscripción inscripción in inscripcións){
                        if(inscripción.alumno==registrado){
                            Console.WriteLine($"Taller: {inscripción.taller.Nombre}\nFecha de Inscripción:{inscripción.fechaInscripción}\n Pagó {(inscripción.Pagó ? "Si" : "No")}\nEstado: {inscripción.Estado}");
                            Console.WriteLine("=================");
                        }
                    }
                    Console.Write($"Acceder a la inscripción del taller: ");
                    Console.Write("Ingrese el nombre del taller a cancelar: ");
                    string tallerCancelar = Console.ReadLine()!.Trim().ToLower();
                    Taller tallerACancelar;
                    try
                    {
                        tallerACancelar = talleres.Find(t => t.Nombre.ToLower() == tallerCancelar) ?? throw new ArgumentException("Taller no encontrado");
                    }
                    catch
                    {
                        Console.WriteLine("Taller no encontrado. Volviendo al inicio.");
                        goto Regresar;
                    }
                    var aCancelar = inscripcións.Find(i => i.taller == tallerACancelar && i.alumno == registrado);
                break;
                case "3":
                    Console.Write("Inscribirse en el taller: ");
                    string inscribirEn = Console.ReadLine()!.ToLower().Trim();
                    Taller tallerElegido;
                    try
                    {
                        tallerElegido = talleres.Find(taller => taller.Nombre.ToLower() == inscribirEn) ?? throw new ArgumentException("Taller no encontrado");
                    }
                    catch
                    {
                        Console.WriteLine("Taller no encontrado. Volviendo al inicio.");
                        goto Regresar;
                    }
                    tallerElegido.IniciarInscripción(registrado,true,"Activa");
                break;
                default:
                    Console.WriteLine("Opción no válida. Volviendo al inicio.");
                    goto Regresar;
            }
            break;
         default:
             Console.WriteLine("Opción no válida.");
             goto Regresar;

            case "6": 
                break;
            
    }