// Guia01\EJ06\Fruta.ts
// Gastón Ricchiardi (gastonj@hotmail.com)

public class Fruta
{
    // ATRIBUTOS PRIVADOS
    private string _color;
    private int _peso;
    private bool _esEstacional;

    // CONSTRUCTOR VACÍO
    public Fruta()
    {
        this._color = "";
        this._peso = 0;
        this._esEstacional = false;
    }

    // CONSTRUCTOR CON PARÁMETROS
    public Fruta(string color, int peso, bool esEstacional)
    {
        this._color = color;
        this._peso = peso;
        this._esEstacional = esEstacional;
    }

    // GETTERS Y SETTERS

    // Color
    public string GetColor()
    {
        return this._color;
    }

    public void SetColor(string color)
    {
        this._color = color;
    }

    // Peso
    public int GetPeso()
    {
        return this._peso;
    }

    public void SetPeso(int peso)
    {
        this._peso = peso;
    }

    // EsEstacional
    public bool GetEsEstacional()
    {
        return this._esEstacional;
    }

    public void SetEsEstacional(bool esEstacional)
    {
        this._esEstacional = esEstacional;
    }

    // REGLA DE NEGOCIO
    // Es comestible si pesa menos de 200 gr y es de estación.
    public bool EsComestible()
    {
        return this._peso < 200 && this._esEstacional;
    }
}