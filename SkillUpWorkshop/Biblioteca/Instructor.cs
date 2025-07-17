namespace Biblioteca
{
   public class Instructor : Usuario
{
    public string DNI { get; set; }
    public string Especialidad { get; set; }
    public bool Asignado { get; private set; }
    public bool Disponible { get; set; }

    public Instructor(string nombre, string apellido, string correo, string teléfono, string dni, string especialidad)
        : base(nombre, apellido, correo, teléfono)
    {
        DNI = dni;
        Especialidad = especialidad;
        Disponible = true;
    }

    public void SetOcupado(bool asignado)
    {
        if (!Asignado && asignado)
        {
            Asignado = true;
        }
    }

    public void MarcarAsistencia() { /* lógica */ }
    public void CorregirEvaluaciones() { /* lógica */ }

    public override void MostrarMenu()
    {
        Console.WriteLine("1. Ver talleres asignados\n2. Corregir evaluaciones\n3. Marcar asistencia\n4. Contactar alumnos");
    }
}

}