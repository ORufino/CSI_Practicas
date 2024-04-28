namespace Lib_Practica2
{
    public class Persona_Original
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        //Para respetar el Single Responsible Principle, esta funcion de Enviar correo debe encontrarse en una clase separada.
        public void EnviarCorreoElectronico(string mensaje)
        {
            //Logica para enviar correo electronico
        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo electronico: {correoElectronico}");
        }
    }
}
