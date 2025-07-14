using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Evaluacion
    {
        private string tipoEvaluacion { get; set; }
        private int puntajesMax { get; set; }
        private int porcentajeAprobacion { get; set; }
        private string modalidadEntrega { get; set; }

        public Evaluacion(string tipoEvaluacion, int puntajesMax, int porcentajeAprobacion, string modalidadEntrega)
        {
            this.tipoEvaluacion = tipoEvaluacion;
            this.puntajesMax = puntajesMax;
            this.porcentajeAprobacion = porcentajeAprobacion;
            this.modalidadEntrega = modalidadEntrega;
        }

        public void 
    }
}