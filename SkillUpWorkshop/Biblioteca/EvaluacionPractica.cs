using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class EvaluacionPractica : Evaluacion
{
    public string Desempeño { get; private set; }
    public string CumplimientoObjetivos { get; private set; }

    public EvaluacionPractica(int puntajeMax, int porcentajeAprob, string modalidad)
        : base("Práctica", puntajeMax, porcentajeAprob, modalidad)
    {
    }

    public void RegistrarObservacionDesempeño(string desempeño, string cumplimiento)
    {
        this.Desempeño = desempeño;
        this.CumplimientoObjetivos = cumplimiento;
    }

    public override void Devolucion(string mensajeObservacion)
    {
        Observacion = $"[Devolución práctica] {mensajeObservacion}\nDesempeño: {Desempeño}\nCumplimiento: {CumplimientoObjetivos}";
        Console.WriteLine(Observacion);
    }

    public override bool EstaAprobado(int puntajeObtenido)
    {
        double porcentaje = (double)puntajeObtenido / PuntajeMaximo * 100;
        return porcentaje >= PorcentajeAprobacion;
    }
}

}