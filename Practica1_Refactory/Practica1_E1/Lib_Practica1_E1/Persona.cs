namespace Lib_Practica1_E1
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Ciudad { get; set; }

        public int Edad 
        {
            get
            {
                var edad = DateTime.Now.Year - FechaNacimiento.Year;
                return edad;
            }
        }

        public Persona(string? nombre, DateTime fechaNacimiento, string? ciudad)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }
    }
}
