public class Libro
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public int AñoPublicacion { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de Publicación: {AñoPublicacion}");
        Console.WriteLine();
    }
}