namespace Lib_Practica1_E3
{
    //SubClass Circulo
    public class Circulo : Figura
    {
        public double Radio { get; set; }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
