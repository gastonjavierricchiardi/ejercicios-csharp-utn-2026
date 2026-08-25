// /src/Guia01/EJ13/Oruga.cs
// Gastón Ricchiardi(Gastonj@hotmail.com)


public class Oruga : SistemaDeTraccion
{
    // 1. ATRIBUTOS
    private string sensores = "";

    // 2. CONSTRUCTOR
    public Oruga()
    {
        this.sensores = "Termometro";
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Sensores
    {
        get => sensores;
        set => sensores = value;
    }

    // 4. MÉTODOS (Comportamiento)
    public override double AvanceMaximo()
    {
        return 400;
    }

    public override double Desgaste()
    {
        return 3;
    }

    public override string GetInfoExtra()
    {
        return this.Sensores;
    }
    public override string GetTipoTraccion()
    {
        return "Oruga";
    }
}