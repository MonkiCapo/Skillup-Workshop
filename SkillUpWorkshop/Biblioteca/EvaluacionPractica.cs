using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EvaluacionPractica : Evaluacion
    {
        public string Ejecución { get; private set; }
        public string Desempeño { get; private set; }
        public string CumplimientoObjetivos { get; private set; }

        public EvaluacionPractica(Alumno alumno, Taller taller) : base("Práctica", 100, 0, "Presencial", alumno, taller)
        {
            Ejecución = string.Empty;
            Desempeño = string.Empty;
            CumplimientoObjetivos = string.Empty;
        }
        public void RegistrarObservacionDesempeño(string desempeño, string cumplimiento, string ejecución)
        {
            Desempeño = desempeño;
            CumplimientoObjetivos = cumplimiento;
            Ejecución = ejecución;
        }
        public override void Devolucion(string mensajeObservacion, int puntajeObtenido)
        {
            PorcentajeAprobacion = puntajeObtenido / PuntajeMaximo * 100;
            Observacion = $"[Devolución práctica] {mensajeObservacion}\nDesempeño: {Desempeño}\nCumplimiento: {CumplimientoObjetivos}\n Ejecución: {Ejecución}";
            Console.WriteLine(Observacion);
        }
        public override bool EstaAprobado(int puntajeObtenido)
        {
            double porcentaje = (double)puntajeObtenido / PuntajeMaximo * 100;
            return porcentaje >= PorcentajeAprobacion;
        }
    }
}