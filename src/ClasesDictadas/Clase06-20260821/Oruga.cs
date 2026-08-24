public class Oruga : SistemaDeTraccion
{

    private string _sensores;

    public string Sensores { get => _sensores; set => _sensores = value; }

    public Oruga()
    {
        this._sensores="Termometro";
    }

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
}