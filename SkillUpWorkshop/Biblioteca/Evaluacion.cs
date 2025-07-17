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

    public Evaluacion(string tipo, int puntajeMax, int porcentajeAprob, string modalidad)
    {
        TipoEvaluacion = tipo;
        PuntajeMaximo = puntajeMax;
        PorcentajeAprobacion = porcentajeAprob;
        ModalidadEntrega = modalidad;
        Observacion = string.Empty;
    }

    public abstract void Devolucion(string mensajeObservacion);
    public abstract bool EstaAprobado(int puntajeObtenido);
}
}