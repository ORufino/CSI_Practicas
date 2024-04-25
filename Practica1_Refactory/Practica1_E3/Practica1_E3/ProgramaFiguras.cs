using Lib_Practica1_E3;

//Introduccion de datos de las figuras.
Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };
Circulo circulo = new Circulo { Radio = 7 };
Triangulo triangulo = new Triangulo { Base = 6, Altura = 8 };

//Mostrar resultados en consola.
Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
Console.WriteLine($"Área del Triángulo: {triangulo.CalcularArea()}");