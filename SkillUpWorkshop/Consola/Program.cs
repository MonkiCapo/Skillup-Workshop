
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
    new Alumno("Juan", "Diaz", "Juanitogolazo@gmail.com", "1123851645",new DateTime(2000-11-02), "Fuerta Apache", "1189248116"),
    new Alumno("Alan", "Pascal", "AlanManchester@gmail.com", "1144228811",new DateTime(2000-07-29), "Central Cordoba", "1145468122"),
    new Alumno("Galván", "Gutierrez", "GalvanArgentina@gmail.com", "1123458116", new DateTime(2000-11-22), "Barracas", "1145812966"),
    new Alumno("Melina", "Medina", "MedinaMeninas@gmail.com", "1123283136", new DateTime(2005-07-09), "Pompeya", "1144262849"),
    new Alumno("Fernanda", "Fernandez", "Fernandismo@gmail.com", "1155862162", new DateTime(2007-08-06), "Once", "1189172188")
};
List<Instructor> instructors = new List<Instructor>
{
    new Instructor("Carlos", "Pérez","carlosperez@gmail.com", "30123456", "1134567890", "Programación"),
    new Instructor("María", "Gómez","mariagomez@gmail.com", "30234567", "1145678901", "Mecánica Automotriz"),
    new Instructor("Luis", "Fernández","luisfernandez@gmail.com", "30345678", "1156789012", "Torneria"),
    new Instructor("Ana", "Martínez","anamartinez@gmail.com", "30456789", "1167890123", "Metales"),
    new Instructor("Jorge", "López","jorgelopez@gmail.com", "30567890", "1178901234", "Electricidad")
};

List<Administrador> Admins = new List<Administrador>
{
     new Administrador("Juan", "Diaz", "Juanitogolazo@gmail.com", "1123851645")
};

Console.WriteLine("------ Elige tu sesión ------");
Console.WriteLine("1. Administrador \n2. Instructor\n 3. Alumno");
switch (Console.ReadLine())
{
    case "1":
        int num1 = 0;
        foreach (Administrador administrador in Admins)
        {
            Console.WriteLine($"{num1} - {administrador.Nombre} {administrador.Apellido}");
        }
        Console.WriteLine("Qué administrador sos?");
        int soyEste1 = int.Parse(Console.ReadLine()!);
        Administrador administrador1 = Admins[soyEste1];
        administrador1.MostrarMenu(talleres, instructors, alumnos);
        break;
    case "2":
        int num2 = 0;
        foreach (Instructor instructor in instructors)
        {
            Console.WriteLine($"{num2} - {instructor.Nombre} {instructor.Apellido}");
        }
        Console.WriteLine("Qué instructor sos?");
        int soyEste2 = int.Parse(Console.ReadLine()!);
        Instructor instructor1 =instructors[soyEste2];
        instructor1.MostrarMenu(talleres, instructors, alumnos);
        break;
    case "3":
        int num3 = 0;
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine($"{num3} - {alumno.Nombre} {alumno.Apellido}");
        }
        Console.WriteLine("Qué alumno sos?");
        int soyEste3 = int.Parse(Console.ReadLine()!);
        Alumno alumno1 =alumnos[soyEste3];
        alumno1.MostrarMenu(talleres, instructors, alumnos);
        break;
    default:
        Console.WriteLine("Opción incorrecta.");
        break;
}
