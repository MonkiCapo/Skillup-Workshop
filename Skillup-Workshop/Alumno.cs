using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class Alumno
    {
        //Terminado
        private string nombre;
        public string Nombre { get { return nombre; } set { Validaciones.Longitud(value); nombre = value; } }
        private string apellido;
        public string Apellido { get { return apellido; } set { Validaciones.Longitud(value); apellido = value; } }
        public DateTime Nacimiento { get; private set; }
        private string correo;
        public string Correo { get { return correo; } set { Validaciones.Correo(value); correo = value; } }
        private string teléfono;
        public string Teléfono { get { return teléfono; } set { Validaciones.Teléfono(value); teléfono = value; } }
        private string dirección;
        public string Dirección { get { return dirección; } set { Validaciones.Dirección(value); dirección = value; } }
        public string ContactoEmergente;
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
            Console.WriteLine("Nombre: "); var nombre = Console.ReadLine();
            Console.WriteLine("Apellido: "); var apellido = Console.ReadLine();
            Console.WriteLine("Nacimiento (yyyy-MM-dd): "); 
            DateTime nacimiento;
            while (!DateTime.TryParse(Console.ReadLine(), out nacimiento))
            {
                Console.WriteLine("Fecha inválida. Intente de nuevo (yyyy-MM-dd): ");
            }
            Console.WriteLine("Correo: "); var correo = Console.ReadLine();
            Console.WriteLine("Teléfono: "); var telefono = Console.ReadLine();
            Console.WriteLine("Dirección: "); var direccion = Console.ReadLine();
            Console.WriteLine("Contacto Emergente: "); var contactoEmergente = Console.ReadLine();

            return new Alumno(nombre, apellido, nacimiento, correo, telefono, direccion, contactoEmergente);
        }
    }
}