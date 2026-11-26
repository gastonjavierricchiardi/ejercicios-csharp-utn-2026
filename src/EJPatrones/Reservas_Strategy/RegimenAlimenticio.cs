using System;
public class RegimenAlimenticio
{
    private string codigo;
    private double porcentajeIncremento;

    public RegimenAlimenticio(
        string codigo,
        double porcentajeIncremento)
    {
        if (string.IsNullOrWhiteSpace(codigo))
        {
            throw new ArgumentException(
                "El regimen debe tener un codigo.");
        }

        if (porcentajeIncremento < 0)
        {
            throw new ArgumentException(
                "El porcentaje no puede ser negativo.");
        }

        this.codigo = codigo;
        this.porcentajeIncremento = porcentajeIncremento;
    }

    public string Codigo
    {
        get { return codigo; }
    }

    public double PorcentajeIncremento
    {
        get { return porcentajeIncremento; }
    }
}