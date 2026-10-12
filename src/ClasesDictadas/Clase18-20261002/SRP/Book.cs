public class Book
{
    private string _autor;
    public string Autor
    {
        get { return _autor; }
        set { _autor = value; }
    }

    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _contenido;
    public string Contenido
    {
        get { return _contenido; }
        set { _contenido = value; }
    }

    public Book(string autor, string nombre, string contenido)
    {
        this.Autor = autor;
        this.Nombre = nombre;
        this.Contenido = contenido;
    }
}


public interface ILibroPersistible
{
    void Guardar (Book unLibro);
}

public class LibroPersistidoEnBBDD : ILibroPersistible
{
    public void Guardar(Book unLibro)
    {
        System.Console.WriteLine($"El libro {unLibro.Nombre} se ha guardado en la base de datos...");
    }
}

public class LibroEnPDF : ILibroPersistible
{
    public void Guardar(Book unLibro)
    {
        System.Console.WriteLine($"El libro {unLibro.Nombre} se ha guardado como archivo PDF...");
    }
}