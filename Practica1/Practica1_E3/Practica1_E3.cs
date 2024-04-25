namespace Figuras;

//SuperClass Figura
public abstract class Figura
{
    public abstract double CalcularArea();
}

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

//SubClass Circulo
public class Circulo : Figura
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

// Programa para calcular el Area de las 3 figuras.
class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };
        Circulo circulo = new Circulo { Radio = 7 };
        Triangulo triangulo = new Triangulo { Base = 6, Altura = 8 };

        Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Área del Triángulo: {triangulo.CalcularArea()}");
    }
}
