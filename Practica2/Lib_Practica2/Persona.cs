namespace Lib_Practica2
{
    public class Persona
    {
        private string Nombre;
        private int Edad;
        private string Direccion;
        private string CorreoElectronico;

        //Constructor
        public Persona (string nombre, int edad, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }
        //Metodo para permitir el acceso del correo electronico a otras clases
        public string ObtenerCorreoElectronico()
        {
            return CorreoElectronico;
        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Direccion: {Direccion}");
            Console.WriteLine($"Correo electronico: {CorreoElectronico}");
        }
    }
}
