public abstract class Traccion : ITraccion
{
    private int deterioroPorcentaje;

    protected Traccion()
    {
        deterioroPorcentaje = 0;
    }

    public abstract int ConsumoHp { get; }
    public abstract int AutonomiaKm { get; }

    public int DeterioroPorcentaje
    {
        get { return deterioroPorcentaje; }
    }

    public void Deteriorar()
    {
        if (!RequiereReemplazo())
        {
            deterioroPorcentaje += 2;
        }
    }

    public bool RequiereReemplazo()
    {
        return deterioroPorcentaje >= 100;
    }
}
