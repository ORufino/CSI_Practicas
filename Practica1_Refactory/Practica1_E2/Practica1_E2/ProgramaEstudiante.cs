using Lib_Practica_E2.Estudiante;

//Crear instancia de la clase Estudiante.
Estudiante estudiante1 = new Estudiante("Luis", new DateTime(1990, 5, 15), "Madrid", "Ingenieria de Software", 54321);
Estudiante estudiante2 = new Estudiante("Alejandra", new DateTime(1995, 10, 8), "Barcelona", "Arquitectura", 12345);

// Mostrar información de los Estudiantes.
Console.WriteLine("Información de la primera persona:");
estudiante1.MostrarInformacion();

estudiante2.MostrarInformacion();
