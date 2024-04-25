using Lib_Practica1_E2.Persona;

namespace Lib_Practica_E2.Estudiante
{
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
}
