public class Formal : Persona
{
    public Formal(string nombre, string apellido) : base(nombre, apellido)
    {
    }

    public override string Presentarse()
    {
        return $"Mi nombre es {this.Nombre}";
    }

    public override string Saludar(Persona receptorSaludo)
    {
        return $"Hola sr/a {receptorSaludo.Apellido}, soy {this.Apellido}";
    }
}