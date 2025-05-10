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

        private string _dificultad;
        public string Dificultad
        {
            get { return _dificultad; }
            private set
            {
                if (value == "Inicial" || value == "Intermedio" || value == "Dificil")
                    Dificultad = value;
                else
                    throw new ArgumentException("Dificultad no valida");

            }
        }
        public Instructor instructor {get; private set;}
        public EspacioFísico espacioFísico{get; private set;}
        public List<Inscripción>? inscripción {get; private set;}
        public Taller(string Nombre, string Descripción, uint Costo, byte Duración, byte Cupos, string Dificultad, Instructor instructor, string Lugar, string Dirección, byte CapacidadMax, bool AccesForDisabled){
            Validaciones.Nombre_Apellido(Nombre);
            this.Nombre=Nombre;
            Validaciones.Descripción(Descripción);
            this.Descripción=Descripción;
            this.Costo=Costo;
            this.Duración=Duración;
            this.Cupos=Cupos;
            this.Dificultad=Dificultad;
            this.instructor=instructor;
            espacioFísico=new EspacioFísico(Lugar, Dirección, CapacidadMax, AccesForDisabled);
        }
        public void SetDescripción(string descripción){
            Validaciones.Descripción(descripción);
            Descripción=descripción;
        }
        public void SetCosto(uint costo){
            Costo=costo;
        }
        public void IniciarInscripción(Alumno alumno, bool Pagó,string Estado){
            if(inscripción?.Count < Cupos){
                inscripción.Add(new Inscripción(alumno, Pagó, Estado));
            }
            else{
                throw new ArgumentException("Taller completo.");
            }
        }
        
    }
}