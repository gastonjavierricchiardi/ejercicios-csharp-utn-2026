public class Robot
{
    private string _numeroDeSerie;
    private double _ptb;
    private SistemaDeTraccion _sistemaDeTraccion;

    public string NumeroDeSerie { get => _numeroDeSerie; set => _numeroDeSerie = value; }
    public double Ptb { get => _ptb; set => _ptb = value; }
    public SistemaDeTraccion SistemaDeTraccion { get => _sistemaDeTraccion; set => _sistemaDeTraccion = value; }

    public Robot(SistemaDeTraccion sistemaDeTraccion, string numeroDeSerie)
    {
        this.SistemaDeTraccion = sistemaDeTraccion;
        this.NumeroDeSerie = numeroDeSerie;
        this.Ptb = 10;
    }
    
    public double PotenciaFinal()
    {
        return this.Ptb - this.SistemaDeTraccion.Desgaste();
    }

    public string GetInfo()
    {
        return $"Estos son mis datos: {this.NumeroDeSerie}; con {this.Ptb} HP, una potencia final de {this.PotenciaFinal()} y con un avance máximo de {this.SistemaDeTraccion.AvanceMaximo()}. Con la siguiente información extra: {this.SistemaDeTraccion.GetInfoExtra()}";
    }
}