namespace Lib_Practica1_E3
{
    //SubClass Triangulo
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea()
        {
            return Base * Altura / 2;
        }
    }
}
