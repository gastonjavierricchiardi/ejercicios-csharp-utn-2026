
public abstract class SistemaDeTraccion
{
    private string _entorno;

    public string Entorno { get => _entorno; set => _entorno = value; }

    public abstract double AvanceMaximo();
    public abstract double Desgaste();
    public abstract string GetInfoExtra();
}