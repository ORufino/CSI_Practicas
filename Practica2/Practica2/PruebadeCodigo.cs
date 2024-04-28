using Lib_Practica2;

internal class Program
{
    private static void Main(string[] args)
    {
        Persona persona = new Persona("Juan", 30, "Calle Principal 123", "juan@example.com");
        persona.ImprimirDatos();

        string destinatario = persona.ObtenerCorreoElectronico();
        
        ServicioEnviar servicioEnviar = new ServicioEnviar();
        servicioEnviar.EnviarCorreoElectronico(destinatario, "Este es un mensaje de prueba.");
    }
}