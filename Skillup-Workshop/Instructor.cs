using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Skillup_Workshop
{
    public class Instructor
    {
        public string Nombre{get; private set;}
        public string Apellido{get; private set;}
        public string DNI{get; private set;}
        public string Teléfono{get; private set;}
        public string Especialidad{ get; private set;}
        public bool Ocupado{get; private set;} //False: no está en ningun taller ; True: esta ubicado en un solo taller.
        public bool Disponible{get; private set;} // False: No acepta más talleres ; True: Acepta dar más talleres
        public Instructor(string Nombre, string Apellido, string DNI, string Teléfono, string Especialidad, bool Disponible){
            Validaciones.Longitud(Nombre);
            this.Nombre=Nombre;
            Validaciones.Longitud(Apellido);
            this.Apellido=Apellido; 
            Validaciones.DNI(DNI);
            this.DNI=DNI; 
            Validaciones.Teléfono(Teléfono);
            this.Teléfono=Teléfono; 
            Validaciones.Longitud(Especialidad);
            this.Especialidad=Especialidad;
            this.Disponible=Disponible;
        }
        public void SetTeléfono(string teléfono){
            Validaciones.Teléfono(teléfono);
            Teléfono=teléfono;
        }

        public void SetOcupado(bool ocupado){
            if(!Ocupado && ocupado){
                Ocupado=ocupado;
            }
        }
        public void SetDisponibilidad(bool disponible){
            Disponible=disponible;
        }
        
    }
}