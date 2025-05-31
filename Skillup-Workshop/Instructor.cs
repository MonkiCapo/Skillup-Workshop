using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Skillup_Workshop
{
    public class Instructor
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string teléfono;
        private string especialidad;
        public bool Asignado{get; private set;} //False: no está en ningun taller ; True: esta ubicado en un solo taller.
        public bool Disponible{get; set;} // False: No acepta más talleres ; True: Acepta dar más talleres
        public string Nombre
        {
            get{return nombre;}
            set{
                Validaciones.Longitud(value);
                nombre = value;
            }
        }
        public string Apellido
        {
            get{return apellido;}
            set{
                Validaciones.Longitud(value);
                apellido = value;
            }
        }
        public string DNI
        {
            get{return dni;}
            set{
                Validaciones.DNI(value);
                dni = value;
            }
        }
        public string Teléfono
        {
            get{return teléfono;}
            set{
                Validaciones.Teléfono(value);
                teléfono = value;
            }
        }
        public string Especialidad
        {
            get{return especialidad;}
            set{
                Validaciones.Longitud(value);
                especialidad = value;
            }
        }
        public Instructor(string Nombre, string Apellido, string DNI, string Teléfono, string Especialidad)
        {
            Validaciones.Longitud(Nombre);
            this.Nombre = Nombre;
            Validaciones.Longitud(Apellido);
            this.Apellido = Apellido;
            Validaciones.DNI(DNI);
            this.DNI = DNI;
            Validaciones.Teléfono(Teléfono);
            this.Teléfono = Teléfono;
            Validaciones.Longitud(Especialidad);
            this.Especialidad = Especialidad;
            Disponible = true;
        }

        public static Instructor CrearInstructor()
        { 
            Console.WriteLine("\t------ Rellenar datos del Instructor ------");
            Console.Write("Nombre: ");
            string Inombre= Console.ReadLine()!;
            
            Console.Write("Apellido: ");
            string Iapellido= Console.ReadLine()!;

            Console.Write("DNI: ");
            string DNI= Console.ReadLine()!;

            Console.Write("Teléfono: ");
            string teléfono= Console.ReadLine()!;

            Console.Write("Especialidad: ");
            string especialidad= Console.ReadLine()!;

            return new Instructor(Inombre, Iapellido, DNI, teléfono, especialidad);
        }
        public void SetOcupado(bool asignado)
        {
            if (!Asignado && asignado)
            {
                Asignado = asignado;
            }
        } 
    }
}