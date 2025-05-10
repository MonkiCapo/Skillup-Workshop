﻿using Skillup_Workshop;

Console.WriteLine("Sos un alumno o instructor?");
Console.WriteLine("Escribí 'alumno' o 'instructor' para continuar.");
string? opcion = Console.ReadLine();

switch (opcion?.ToLower())
{
    case "alumno":
        Console.WriteLine("Seleccionaste Alumno.");
        break;
    case "instructor":
        Console.WriteLine("Seleccionaste Instructor.");
        break;
    default:
        Console.WriteLine("Opción no válida. Por favor, selecciona 'alumno' o 'instructor'.");
        break;
}

static void ProcesarInstructor()
{
    Console.WriteLine("¿Qué taller quieres dirigir?");
    string? taller = Console.ReadLine();
    Console.WriteLine($"Has seleccionado dirigir el taller: {taller}");
}

static void ProcesarAlumno()
{
    Console.WriteLine("¿A qué taller te quieres inscribir?");
    string? taller = Console.ReadLine();
    Console.WriteLine($"Te has inscrito en el taller: {taller}");
}