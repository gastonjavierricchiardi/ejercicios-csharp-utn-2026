// /src/Guia01/EJ13/Robot.cs
// Gastón Ricchiardi(Gastonj@hotmail.com)

public class Robot
{
    // 1. ATRIBUTOS
    private string numeroDeSerie;
    private double ptb;
    private SistemaDeTraccion sistemaDeTraccion;

    // 2. CONSTRUCTOR
    public Robot(SistemaDeTraccion sistemaDeTraccion, string numeroDeSerie)
    {
        this.sistemaDeTraccion = sistemaDeTraccion;
        this.numeroDeSerie = numeroDeSerie;
        this.ptb = 10;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string NumeroDeSerie
    {
        get => numeroDeSerie;
        set => numeroDeSerie = value;
    }

    public double Ptb
    {
        get => ptb;
        set => ptb = value;
    }

    public SistemaDeTraccion SistemaDeTraccion
    {
        get => sistemaDeTraccion;
        set => sistemaDeTraccion = value;
    }

    // 4. MÉTODOS (Comportamiento)
    public double PotenciaFinal()
    {
        return this.ptb - this.sistemaDeTraccion.Desgaste();
    }

    public string GetInfo()
    {
        return $"Estos son mis datos: {this.numeroDeSerie}; con {this.ptb} HP, " +
               $"una potencia final de {this.PotenciaFinal()}, " +
               $"tipo de tracción: {this.sistemaDeTraccion.GetTipoTraccion()}, " +
               $"con un avance máximo de {this.sistemaDeTraccion.AvanceMaximo()}. " +
               $"Con la siguiente información extra: {this.sistemaDeTraccion.GetInfoExtra()}";
    }
}