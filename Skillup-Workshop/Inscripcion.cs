using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class Inscripción
    {
        public Alumno? alumno{get; private set;}
        public Taller taller{get; private set;}
        public DateTime fechaInscripción{get; private set;}
        public bool Pagó{get; private set;}
        public string Estado {get; private set;}
        public List<string> estados= new List<string>(){"Activa","Cancelada","Finalizada"};
        public Inscripción(Alumno alumno,Taller taller, bool Pagó, string Estado){
            this.alumno=alumno;
            this.taller=taller;
            fechaInscripción=DateTime.Now;
            this.Pagó=Pagó;
            this.Estado=Estado;
        }
        //public void agregarTaller(string Nombre, string Descripción, uint Costo, byte Duración, byte Cupos, Instructor instructor, string Lugar, string Dirección, byte CapacidadMax, bool AccesForDisabled){
            //taller=new Taller(Nombre, Descripción,Costo, Duración, Cupos, instructor, Lugar, Dirección, CapacidadMax, AccesForDisabled);
        //}
        public void SetEstado(string _estado){
            foreach(string estado in estados){
                if(_estado!=estado){
                    throw new Exception("");
                }
                Estado=_estado;
                if(Estado=="Cancelado"){
                    alumno=null;
                }
            }
        }
        public void SetPagó(bool pagó){
            Pagó=pagó;
        }
    }
}