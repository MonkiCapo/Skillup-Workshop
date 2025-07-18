using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Alumno : Usuario
    {
        public DateTime FechaNacimiento { get; set; }
        public string Dirección { get; set; }
        public string ContactoEmergente { get; set; }
        public List<Evaluacion> Evaluaciones { get; private set; }

        public Alumno(string nombre, string apellido, string correo, string teléfono,
                      DateTime nacimiento, string dirección, string contactoEmergente)
            : base(nombre, apellido, correo, teléfono)
        {
            FechaNacimiento = nacimiento;
            Dirección = dirección;
            ContactoEmergente = contactoEmergente;
            Evaluaciones = new List<Evaluacion>();
        }

        public void VerHistorial()
        {
            Console.WriteLine("Historial de evaluaciones:");
            foreach (var eval in Evaluaciones)
            {
                Console.WriteLine($"- {eval.TipoEvaluacion} | Puntaje Máximo: {eval.PuntajeMaximo} | Modalidad: {eval.ModalidadEntrega}");
            }
        }

        public void AgregarEvaluacion(Evaluacion evaluacion)
        {
            Evaluaciones.Add(evaluacion);
        }

        public void InscribirseTaller() { /* lógica */ }
        public void VerCalificaciones()
        {
            Console.WriteLine("Calificaciones:");
            foreach (var eval in Evaluaciones)
            {
                Console.WriteLine($"{eval.TipoEvaluacion}: {eval.Observacion}");
            }
        }

        public override void MostrarMenu()
        {
            Console.WriteLine("1. Ver historial\n2. Inscribirse en taller\n3. Ver calificaciones\n4. Ver notificaciones");
        }
    }
}