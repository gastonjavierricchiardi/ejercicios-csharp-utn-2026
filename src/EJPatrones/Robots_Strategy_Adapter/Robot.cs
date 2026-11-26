using System;

public class Robot
{
    private string numeroSerie;
    private int resistencia;
    private IArma arma;
    private ITraccion traccion;

    public Robot(string numeroSerie, int resistencia, IArma arma, ITraccion traccion)
    {
        if (string.IsNullOrWhiteSpace(numeroSerie))
        {
            throw new ArgumentException("Debe indicar un numero de serie.");
        }

        if (resistencia <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(resistencia));
        }

        this.numeroSerie = numeroSerie;
        this.resistencia = resistencia;
        this.arma = arma ?? throw new ArgumentNullException(nameof(arma));
        this.traccion = traccion ?? throw new ArgumentNullException(nameof(traccion));
    }

    public string NumeroSerie
    {
        get { return numeroSerie; }
    }

    public int Resistencia
    {
        get { return resistencia; }
    }

    public ITraccion Traccion
    {
        get { return traccion; }
    }

    public int PotenciaTraccionDisponibleHp
    {
        get { return 10 - traccion.ConsumoHp; }
    }

    public bool EstaOperativo()
    {
        return resistencia > 0 && !traccion.RequiereReemplazo();
    }

    public void Atacar(Robot objetivo)
    {
        if (objetivo == null)
        {
            throw new ArgumentNullException(nameof(objetivo));
        }

        if (!EstaOperativo() || !objetivo.EstaOperativo())
        {
            throw new InvalidOperationException(
                "Ambos robots deben estar operativos para atacar.");
        }

        objetivo.RecibirDanio(arma.ObtenerDanio());
        traccion.Deteriorar();
    }

    private void RecibirDanio(int danio)
    {
        resistencia = Math.Max(0, resistencia - danio);
    }
}
