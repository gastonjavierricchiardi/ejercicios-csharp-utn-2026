// /src/Guia01/EJ13/Caucho.cs
// Gastón Ricchiardi(Gastonj@hotmail.com)

public class Caucho : SistemaDeTraccion
{
    // 1. CAMPOS / ATRIBUTOS

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override double AvanceMaximo()
    {
        return 100;
    }

    public override double Desgaste()
    {
        return 1;
    }

    public override string GetInfoExtra()
    {
        return "Sin información extra";
    }
    public override string GetTipoTraccion()
    {
        return "Caucho";
    }
}