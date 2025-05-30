using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class Inscripción
    {
        public Alumno alumno{get; private set;}
        public Taller taller{get; private set;}
        public DateTime fechaInscripción{get; private set;}
        public bool Pagó{get; set;}
        private string estado;
        public string Estado { get { return estado; } set{
                Validaciones.Estado(value);
                estado = value;
            } 
        }
        public Inscripción(Alumno alumno, Taller taller, bool Pagó, string Estado)
        {
            this.alumno = alumno ?? throw new ArgumentException("Alumno Invalido");
            this.taller = taller;
            fechaInscripción = DateTime.Now;
            this.Pagó = Pagó;
            Validaciones.Estado(Estado);
            this.Estado = Estado;
        }
    }
}