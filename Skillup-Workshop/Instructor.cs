using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class Instructor
    {
        public string Nombre{get; private set;}
        public string Apellido{get; private set;}
        public string DNI{get; private set;}
        public string Teléfono{get; private set;}
        public string Especialidad{ get; private set;}
        public bool Disponible;
        public Instructor(string Nombre, string Apellido, string DNI, string Teléfono, string Especialidad, bool Disponible){
            Validaciones.Nombre_Apellido(Nombre);
            this.Nombre=Nombre;
            Validaciones.Nombre_Apellido(Apellido);
            this.Apellido=Apellido;
            Validaciones.DNI(DNI);
            this.DNI=DNI;
            Validaciones.Teléfono(Teléfono);
            this.Teléfono=Teléfono;
            this.Especialidad=Especialidad;
            this.Disponible=Disponible;
        }
        public void SetTeléfono(string teléfono){
            Validaciones.Teléfono(teléfono);
            this.Teléfono=teléfono;
        }
    }
}
