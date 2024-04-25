namespace Practica1_E2
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

    ///////////////////////////////////////////////////////////////////////////////////////////

    public class Estudiante : Persona
    {
        //Atributos del Estudiante.
        public string? Carrera { get; set; }
        public int? Matricula { get; set; }

        //Constructor.
        public Estudiante(string nombre, DateTime fechaNacimiento, string ciudad, string carrera, int matricula) : base(nombre, fechaNacimiento, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        //Metodo para mostrar la informacion del estudiante.
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matrícula: {Matricula}\n");
        }

    }

    //PROGRAMA del metodo para mostrar la informacion del Estudiante.

    class ProgramaEstudiante
    {
        static void Main(string[] args)
        {
            //Crear instancia de la clase Estudiante.
            Estudiante estudiante1 = new Estudiante("Luis", new DateTime(1990, 5, 15), "Madrid", "Ingenieria de Software", 54321);
            Estudiante estudiante2 = new Estudiante("Alejandra", new DateTime(1995, 10, 8), "Barcelona", "Arquitectura", 12345);

            // Mostrar información de los Estudiantes.
            Console.WriteLine("Información de la primera persona:");
            estudiante1.MostrarInformacion();

            estudiante2.MostrarInformacion();
        }

    }
}