namespace Lib_Practica2
{
    public class ServicioEnviar
    {
        //Para respetar el Single Responsible Principle, esta funcion de Enviar correo debe encontrarse en una clase separada.
        public void EnviarCorreoElectronico(string destinatario, string mensaje)
        {
            //Logica para enviar correo electronico
            Console.WriteLine($"\nEnviando correo a {destinatario} con mensaje: {mensaje}");
        }
    }
}
