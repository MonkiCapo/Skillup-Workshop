using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Administrador : Usuario
{
    public Administrador(string nombre, string apellido, string correo, string teléfono)
        : base(nombre, apellido, correo, teléfono)
    {
    }

    public void VerReportes()
    { 
        
    }
    public void GestionarSistema()
    { 

    }

    public override void MostrarMenu()
    {
        Console.WriteLine("1. Ver reportes\n2. Gestionar instructores\n3. Gestionar alumnos\n4. Gestionar talleres");
    }
}

}