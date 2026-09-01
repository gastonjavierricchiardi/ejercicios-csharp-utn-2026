public class Informal : Persona
{
    public Informal(string nombre, string apellido) : base(nombre, apellido)
    {
    }

    public override string Presentarse()
    {
        return $"Soy {this.Nombre}";
    }

    public override string Saludar(Persona receptorSaludo)
    {
        return $"¿Qué haces {receptorSaludo.Nombre}?, ¡soy {this.Nombre}!";
    }
}