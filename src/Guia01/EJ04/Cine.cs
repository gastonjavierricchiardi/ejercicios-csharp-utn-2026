// Guia01\EJ04\Cine.ts
// Gastón Ricchiardi (gastonj@hotmail.com)
public class Cine
{
    // 1. ATRIBUTOS
    private string _pelicula = "";
    private string _horario = "";
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Para pelicula
    public string GetPelicula()
    {
        return this._pelicula;
    }
    public void SetPelicula(string pelicula)
    {
        this._pelicula = pelicula;
    }
    // Para horario
    public string GetHorario()
    {
        return this._horario;
    }
    public void SetHorario(string horario)
    {
        this._horario = horario;
    }

    // 4. MÉTODOS (Comportamiento)
    public string ObtenerCartelera()
    {
        return $"La película \"{this.GetPelicula()}\" se proyecta a las {this.GetHorario()}.";
    }
}