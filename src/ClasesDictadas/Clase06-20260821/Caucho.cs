public class Caucho : SistemaDeTraccion
{
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
        return "Sin información extra"; //return "";
    }
}