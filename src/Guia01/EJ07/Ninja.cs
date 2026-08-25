// Guia01\EJ07\Program.cs
// Gastón Ricchiardi (gastonj@hotmail.com)

public class Ninja
{
    // 1. Atributos
    private string _arteMarcial = "";
    private string _arma = "";
    private int _fuerza;
    private int _salto;

    // 2. Constructor

    // 3. Getters y Setters
    // arteMarcial
    public string GetArteMarcial() { return this._arteMarcial; }
    public void SetArteMarcial(string arteMarcial) { this._arteMarcial = arteMarcial; }

    // arma
    public string GetArma() { return this._arma; }
    public void SetArma(string arma) { this._arma = arma; }

    // fuerza
    public int GetFuerza() { return this._fuerza; }
    public void SetFuerza(int fuerza) { this._fuerza = fuerza; }

    // salto
    public int GetSalto() { return this._salto; }
    public void SetSalto(int salto) { this._salto = salto; }

    // 4. Métodos
    public void Saltar(int multiplicador)
    {
        Console.WriteLine(this._salto * multiplicador); // imprime la lógica de negocio
    }

    public void Ataque()
    {
        Console.WriteLine($"Arma: {this._arma} - Arte marcial: {this._arteMarcial}");
    }
    // Ojo que acá tenemos violación de principio SOLID, viola SRP, la clase no debería imprimir en pantalla
    // Solo se tiene que encargar de la lógica de negocio.
    // Pero la consigna dice especificamente que lo viole.
}