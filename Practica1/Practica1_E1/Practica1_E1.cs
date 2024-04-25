namespace Practica1_E1
{
    public class Persona
    {

        // Atributos.
        public string? Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Ciudad { get; set; }

        // Constructor.
        public Persona(string nombre, DateTime fechaNacimiento, string ciudad)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }

        // Propiedad para calcular el valor de la edad.
        public int Edad
        {
            get
            {
                DateTime Ahora = DateTime.Today;
                int edad = Ahora.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Date > Ahora.AddYears(-edad))
                {
                    edad--;
                }
                return edad;
            }
        }

        // Metodo para guardar la informacion.
        public void Save()
        {
            Console.WriteLine("Guardando la informacion...");
        }

        // Metodo para mostrar la informacion.
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }

    }

    //PROGRAMA del metodo MostrarInformacion
    class ProgramaPersona
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de la clase Persona
            Persona persona1 = new Persona("Juan", new DateTime(1990, 5, 15), "Madrid");
            Persona persona2 = new Persona("Maria", new DateTime(1995, 10, 8), "Barcelona");

            // Mostrar información de las personas
            Console.WriteLine("Información de la primera persona:");
            persona1.MostrarInformacion();

            Console.WriteLine("\nInformación de la segunda persona:");
            persona2.MostrarInformacion();
        }
    }
}