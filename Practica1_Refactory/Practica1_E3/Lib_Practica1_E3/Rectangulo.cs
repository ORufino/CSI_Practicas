namespace Lib_Practica1_E3
{
    //SubClass Rectangulo
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
