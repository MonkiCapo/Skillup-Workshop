using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Evaluacion
    {
        public string TipoEvaluacion { get; protected set; }
        public int PuntajeMaximo { get; protected set; }
        public int PorcentajeAprobacion { get; protected set; }
        public string ModalidadEntrega { get; protected set; }
        public string Observacion { get; protected set; }
        public Alumno alumno { get; private set; }
        public Taller taller { get; private set; }

        public Evaluacion(string tipo, int puntajeMax, int porcentajeAprob, string modalidad, Alumno alumno, Taller taller)
        {
            TipoEvaluacion = tipo;
            PuntajeMaximo = puntajeMax;
            PorcentajeAprobacion = porcentajeAprob;
            ModalidadEntrega = modalidad;
            Observacion = string.Empty;
            this.alumno = alumno ?? throw new ArgumentNullException("El alumno no puede ser nulo.");
            this.taller = taller ?? throw new ArgumentNullException("El taller no puede ser nulo.");
        }
        public abstract void Devolucion(string mensajeObservacion, int puntajeObtenido);
        public abstract bool EstaAprobado(int puntajeObtenido);
    }
}