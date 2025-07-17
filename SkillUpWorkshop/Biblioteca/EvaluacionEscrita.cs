using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class EvaluacionEscrita : Evaluacion
{
    public string ArchivoAdjunto { get; private set; }

    public EvaluacionEscrita(int puntajeMax, int porcentajeAprob, string modalidad)
        : base("Escrita", puntajeMax, porcentajeAprob, modalidad)
    {
        ArchivoAdjunto = string.Empty;
    }

    public void AdjuntarArchivo(string archivo)
    {
        ArchivoAdjunto = archivo;
    }

    public override void Devolucion(string mensajeObservacion)
    {
        Observacion = $"[Devolución escrita] {mensajeObservacion}";
        Console.WriteLine($"Archivo adjunto: {ArchivoAdjunto}");
        Console.WriteLine($"Observación: {Observacion}");
    }

    public override bool EstaAprobado(int puntajeObtenido)
    {
        double porcentaje = (double)puntajeObtenido / PuntajeMaximo * 100;
        return porcentaje >= PorcentajeAprobacion;
    }
}

}