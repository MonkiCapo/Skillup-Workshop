namespace Biblioteca
{
    public class Alumno : Usuario
    {
        public DateTime FechaNacimiento { get; set; }
        public string Dirección { get; set; }
        public string ContactoEmergente { get; set; }

        public Alumno(string nombre, string apellido, string correo, string teléfono,
                      DateTime nacimiento, string dirección, string contactoEmergente)
            : base(nombre, apellido, correo, teléfono)
        {
            FechaNacimiento = nacimiento;
            Dirección = dirección;
            ContactoEmergente = contactoEmergente;
        }

        public void VerHistorial() { /* lógica */ }
        public void InscribirseTaller() { /* lógica */ }
        public void VerCalificaciones() { /* lógica */ }

        public override void MostrarMenu()
        {
            Console.WriteLine("1. Ver historial\n2. Inscribirse en taller\n3. Ver calificaciones\n4. Ver notificaciones");
        }
    }
}