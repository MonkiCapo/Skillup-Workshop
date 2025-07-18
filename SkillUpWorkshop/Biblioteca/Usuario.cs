using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Biblioteca
{ 
    public abstract class Usuario
{
    public string Nombre { get; protected set; }
    public string Apellido { get; protected set; }
    public string Correo { get; protected set; }
    public string Teléfono { get; protected set; }

    protected Usuario(string nombre, string apellido, string correo, string teléfono)
    {
        Nombre = nombre;
        Apellido = apellido;
        Correo = correo;
        Teléfono = teléfono;
    }

    public abstract void MostrarMenu(List<Taller> talleres, List<Instructor> instructors, List<Alumno> alumnos); // Cada tipo de usuario implementa su menú
}
}

