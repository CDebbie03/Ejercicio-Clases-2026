public class Estante
{
    public int NumeroEstante { get; set; }
    public int CapacidadMaxima { get; set; }
    public List<Libro> LibrosEnEstante { get; set; }

    public Estante(int numeroEstante, int capacidadMaxima)
    {
        NumeroEstante = numeroEstante;
        CapacidadMaxima = capacidadMaxima;
        LibrosEnEstante = new List<Libro>();
    }

    public void MostrarContenido()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Numero de estante: {NumeroEstante}");
        Console.WriteLine($"Capacidad maxima: {CapacidadMaxima} libros");
        Console.WriteLine("Libros en el estante:");
        Console.WriteLine();

        foreach (Libro libro in LibrosEnEstante)
        {
            libro.MostrarInformacion();
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine();
    }
}