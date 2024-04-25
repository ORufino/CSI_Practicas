using Lib_Practica1_E1;

// Ejemplo de uso de la clase Persona
Persona persona1 = new Persona("Juan", new DateTime(1990, 5, 15), "Madrid");
Persona persona2 = new Persona("Maria", new DateTime(1995, 10, 8), "Barcelona");

// Mostrar información de las personas
Console.WriteLine("Información de la primera persona:");
persona1.MostrarInformacion();

Console.WriteLine("\nInformación de la segunda persona:");
persona2.MostrarInformacion();