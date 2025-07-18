using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EvaluacionEscrita : Evaluacion
    {
        public List<string> ArchivosAdjuntos { get; private set; }

        public EvaluacionEscrita(Alumno alumno, Taller taller) : base("Escrita", 10, 0, "Virtual", alumno, taller)
        {
            ArchivosAdjuntos = new List<string>();
        }
        public void AdjuntarArchivo(string archivo)
        {
            ArchivosAdjuntos.Add(archivo);
        }

        public override void Devolucion(string mensajeObservacion, int puntajeObtenido)
        {
            PorcentajeAprobacion= puntajeObtenido / PuntajeMaximo * 100;
            Observacion = $"[Devolución escrita] {mensajeObservacion}";
            Console.WriteLine("Archivos adjuntos:");
            foreach (var archivo in ArchivosAdjuntos)
            {
                Console.WriteLine($"Archivo adjunto: {archivo}");
            }
            Console.WriteLine($"Observación: {Observacion}");
        }

        public override bool EstaAprobado(int puntajeObtenido)
        {
            double porcentaje = puntajeObtenido / PuntajeMaximo * 100;
            return porcentaje >= PorcentajeAprobacion;
        }
    }
}