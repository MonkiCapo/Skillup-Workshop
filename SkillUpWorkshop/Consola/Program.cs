
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Biblioteca;

List<Taller> talleres = new List<Taller>
{
    new Taller("Programación", "Enseñamos lenguajes de programación como C#", 15000, 12, 20, "Intermedio", "Retiro", "Av. Libertador 2811", 100, false),
    new Taller("Mecánica Automotriz", "Mantenimiento y reparación de vehiculos", 20000, 25, 25, "Intermedio", "Retiro", "San Martín 473", 100, false),
    new Taller("Programación", "Enseñamos lenguajes de programación como C#.", 32000, 15, 20, "Intermedio", "Retiro", "Av. Libertador 2811", 100, false),
    new Taller("Mecánica Automotriz", "Mantenimiento y reparación de vehiculos.", 40000, 15, 25, "Intermedio", "Retiro", "San Martín 473", 100, false),
    new Taller("Torneria", "Confeccion de piezas.", 25000, 15, 20, "Intermedio", "Retiro", "San Martín 1415", 100, false),
    new Taller("Metales","Confeccion de piezas.", 17000, 15, 1, "Avanzado", "Retiro", "San Martín 7174", 100, false),
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

Regresar:
Console.WriteLine("------ Opciones ------");
Console.WriteLine("1. Crear Taller\n2. Crear Instructor\n3. Crear Alumno\n4. Opciones de taller\n5. Opciones alumno\n6. Opciones instructor\n7. Salir");
    switch (Console.ReadLine())
    {
        case "1":
            try
            {
                talleres.Add(Taller.CrearTaller()); //Terminado
                Console.WriteLine("****** Registro Exitoso ******");
            }
            catch
            {
                Console.WriteLine("¡¡ Registro Fallido !!\nVolviendo al inicio...");
                goto Regresar;
            }
            Console.WriteLine("Desea continuar?(s/n)");
            if (String.Compare(Console.ReadLine()!.Trim(), "s", true) == 0){
                goto Regresar;
            }
            break;
        case "2":
            try{
                instructors.Add(Instructor.CrearInstructor()); //Terminado
                Console.WriteLine("****** Registro Exitoso ******");
            }catch
            {
                Console.WriteLine("¡¡ Registro Fallido !!\nVolviendo al inicio...");
                goto Regresar;
            }
            Console.WriteLine("Desea continuar?(s/n)");
            if (String.Compare(Console.ReadLine()!.Trim(),"s", true)==0){
                goto Regresar;
            }
            break;
        case "3":
            try{
                alumnos.Add(Alumno.CrearAlumno()); //Terminado
                Console.WriteLine("****** Registro Exitoso ******");
            }
            catch
            {
                Console.WriteLine("¡¡ Registro Fallido !!\nVolviendo al inicio...");
                goto Regresar;
            }
            Console.WriteLine("Desea continuar?(s/n)");
            if (String.Compare(Console.ReadLine()!.Trim(),"s", true)==0){
                goto Regresar;
            }
        break;
        case "4": //Opciones de taller

            Console.WriteLine("------ Lista de Talleres------");
            foreach(Taller t in talleres){
                Console.WriteLine(t.Nombre);
            }
            Console.WriteLine("================");
            Console.WriteLine("Acceder a: ");
            string acceder_A = Console.ReadLine()!.Trim().ToLower();
            var tallerAccedido=talleres.Find(taller => taller.Nombre.ToLower() == acceder_A) ?? throw new Exception("Taller no encontrado");
            Console.WriteLine("****** Taller Encontrado ******");
            
            Console.WriteLine("Acciones para realizar: \n 1- Mostrar Información\n 2- Asignar/Cambiar Instructor\n 3- Mostrar Inscripciones\n 4- Eliminar taller");
            Console.WriteLine("=============================");
            switch (Console.ReadLine()){
                case "1":
                    tallerAccedido.MostrarInformación(); //Terminado
                    break;
                case "2":
                    Console.WriteLine("\t------ Lista de instructores disponibles ------");
                    foreach (Instructor instructor in instructors)
                    {
                    if (instructor.Disponible == true)
                    {
                        Console.WriteLine($"Nombre: {instructor.Nombre}\nEspecialidad: {instructor.Especialidad}\nDNI: {instructor.DNI}\nDisponible: {(instructor.Disponible ? "Si" : "No")}");
                        Console.WriteLine("===================================");
                        }
                    }
                    Console.Write("DNI del Instructor a elegir: ");
                    string buscarInstructor = Console.ReadLine()!;
                    var InstructorEncontrado = instructors.Find(instructors => instructors.DNI == buscarInstructor) ?? throw new ArgumentException("Instructor no encontrado");
                    tallerAccedido.AsignarInstructor(InstructorEncontrado);
                    Console.WriteLine("\t*** Instructor asignado exitosamente ***");
                    break;
                case "3": //Terminado
                    int cuposOcupados=0;
                    tallerAccedido.MostrarInscripciones(out cuposOcupados);
                    Console.WriteLine($"Cupos disponibles: {tallerAccedido.Cupos-cuposOcupados}\nCupos ocupados: {cuposOcupados}"); 
                    break;
                case "4": //Terminado
                    tallerAccedido.EliminarTaller_E_Inscripciones(tallerAccedido);
                    talleres.Remove(tallerAccedido);

                    Console.WriteLine("Desea continuar?(s/n)");
                    if (String.Compare(Console.ReadLine()!.Trim(),"s", true)==0){
                        goto Regresar;
                    }
                break;   
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
            var registrado = alumnos.Find(alumno => alumno.Correo.ToLower()== buscarCorreo.ToLower()) ?? throw new ArgumentException("Alumno no encontrado");
            Console.WriteLine("------ Lista de Talleres------");
            foreach(Taller t in talleres) {
                Console.WriteLine(t.Nombre);
            }
            Console.WriteLine("======================");
            Console.WriteLine("Acciones para realizar: \n 1- Mostrar Información\n 2- Mostrar Inscripciones\n 3- Cancelar inscripción\n 4- Iniciar inscripción");
            switch (Console.ReadLine())
            {
                case "1": //Terminado
                    registrado.MostrarInformación();
                break;
                case "2": //Terminado
                    foreach(Taller taller in talleres){
                        taller.InscripciónDelAlumno(registrado);
                    }
                break;
                case "3": //Terminado
                    Console.WriteLine($"------ Inscripciones del Alumno ------");
                    foreach(Taller taller in talleres){
                        taller.InscripciónDelAlumno(registrado);
                    }
                    Console.Write($"Acceder a la inscripción del taller: ");
                    
                    string InscripcionDelTaller = Console.ReadLine()!;
                    var aCancelar = talleres.Find(taller => taller.Nombre == InscripcionDelTaller) ?? throw new Exception("Taller no encontrado");
                    aCancelar.CancelarInscripciónDe(registrado);
                goto Regresar;
                case "4":
                    Console.Write("Inscribirse en el taller: ");
                    string inscribirEn = Console.ReadLine()!.ToLower().Trim();
                    var tallerElegido=talleres.Find(taller => taller.Nombre.ToLower() == inscribirEn) ?? throw new ArgumentException("Taller no encontrado"); 
                    tallerElegido.IniciarInscripción(registrado,true,"Activo");
                goto Regresar;
            }
        break;
        case "6":
                Console.WriteLine("\t------ Lista de instructores------");
                foreach (Instructor instructor in instructors)
                {
                    Console.WriteLine($"Nombre: {instructor.Nombre}\nDNI: {instructor.DNI}\nAsignado: {(instructor.Asignado ? "Si" : "No")}\nDisponible: {(instructor.Disponible ? "Si" : "No")}");
                    Console.WriteLine("===================");
                }
                Console.Write("DNI del Instructor a elegir: ");
                string buscarInstructor2 = Console.ReadLine()!;
                var InstructorEncontrado2 = instructors.Find(instructors => instructors.DNI == buscarInstructor2) ?? throw new ArgumentException("Instructor no encontrado");

                Console.WriteLine("Sacar disponibilidad?(s/n)");
                if (String.Compare(Console.ReadLine()!.Trim(), "s", true) == 0){
                    InstructorEncontrado2.Disponible = false;
                    Console.WriteLine("*** Ya no tiene disponibilidad");
                    goto Regresar;
                }
                else{
                    Console.WriteLine("Regresando...");
                    goto Regresar;
                }
            case "7":
            break;
        default:
            Console.WriteLine("Opción no válida.");
            goto Regresar;
    }