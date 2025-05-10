using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class Taller
    {
        public string Nombre{get; private set;}
        public string Descripción{get; private set;}
        public uint Costo{get; private set;} //En pesos
        public byte Duración{get; private set;} //En semanas
        public byte Cupos{get; private set;}
        public string Dificultad{get; private set;}
        public Instructor instructor {get; private set;}
        public EspacioFísico espacioFísico{get; private set;}
        public List<Inscripción>? inscripción {get; private set;}
        public Taller(string Nombre, string Descripción, uint Costo, byte Duración, byte Cupos, string Dificultad, Instructor instructor, string Lugar, string Dirección, ushort CapacidadMax, bool AccesoMovilidadReducida){
            Validaciones.Longitud(Nombre);
            this.Nombre=Nombre;
            Validaciones.Descripción(Descripción);
            this.Descripción=Descripción;
            this.Costo=Costo;
            this.Duración=Duración;
            this.Cupos=Cupos;
            this.Dificultad=Dificultad;
            Validaciones.AsignarInstructor(instructor);
            this.instructor=instructor;
            instructor.SetOcupado(true);
            espacioFísico=new EspacioFísico(Lugar, Dirección, CapacidadMax, AccesoMovilidadReducida);
        }
        public void SetDescripción(string descripción){
            Validaciones.Descripción(descripción);
            Descripción=descripción;
        }
        public void SetCosto(uint costo){
            Costo=costo;
        }
        public void SetDificultad(string _dificultad){
           Validaciones.Dificultad(_dificultad);
           Dificultad=_dificultad;
        }
        public void IniciarInscripción(Alumno alumno,Taller taller, bool Pagó,string Estado){
            if(inscripción?.Count < Cupos){
                inscripción.Add(new Inscripción(alumno,taller, Pagó, Estado));
            }
            else{
                throw new ArgumentException("Taller completo.");
            }
        }

        public void EliminarTaller_E_Inscripciones(Taller taller)
        {   
            Console.WriteLine($"Eliminando {inscripción?.Count ?? 0} inscripciones del taller: {Nombre}");
            inscripción?.Clear();
            taller=null;
        }
    }
}