using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Skillup_Workshop
{
    public class Inscripción
    {
        public Alumno alumno { get; private set; }
        public Taller taller { get; private set; }
        public DateTime fechaInscripción { get; private set; }
        public bool Pagó { get; set; }
        private string estado;
        public string Estado
        {
            get { return estado; }
            set
            {
                Validaciones.Estado(value, alumno);
                estado = value;
                alumno = alumno;
            }
        }
        public Inscripción(Alumno alumno, Taller taller, bool Pagó, string Estado)
        {
            this.alumno = alumno;
            this.taller = taller;
            fechaInscripción = DateTime.Now;
            this.Pagó = Pagó;
            Validaciones.Estado(Estado, alumno);
            this.Estado = Estado;
        }
        
    }
}