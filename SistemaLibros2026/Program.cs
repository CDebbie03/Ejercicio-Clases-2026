Libro libro1 = new Libro();
libro1.Titulo = "El Principito";
libro1.Autor = "Antoine de Saint-Exupéry";
libro1.AñoPublicacion = 1943;

Libro libro2 = new Libro();
libro2.Titulo = "Cien Años de Soledad";
libro2.Autor = "Gabriel García Marquez";
libro2.AñoPublicacion = 1967;

Libro libro3 = new Libro();
libro3.Titulo = "Don Quijote de la Mancha";
libro3.Autor = "Miguel de Cervantes";
libro3.AñoPublicacion = 1605;

Persona persona1 = new Persona();
persona1.Nombre = "Sofia";
persona1.Apellido = "Garcia";
persona1.Edad = 25;

Persona persona2 = new Persona();
persona2.Nombre = "Carlos";
persona2.Apellido = "Ramirez";
persona2.Edad = 30;

Estante estante1 = new Estante(1, 5);
estante1.LibrosEnEstante.Add(libro1);
estante1.LibrosEnEstante.Add(libro2);
estante1.LibrosEnEstante.Add(libro3);

Console.WriteLine("INFORMACION DE LAS PERSONAS");
Console.WriteLine("---------------------------------------------");
persona1.Saludar();
persona2.Saludar();

Console.WriteLine("INFORMACION DE LOS LIBROS CREADOS");
Console.WriteLine("---------------------------------------------");
libro1.MostrarInformacion();
libro2.MostrarInformacion();
libro3.MostrarInformacion();

Console.WriteLine("CONTENIDO COMPLETO DEL ESTANTE");
estante1.MostrarContenido();

Console.WriteLine("El programa ha finalizado");