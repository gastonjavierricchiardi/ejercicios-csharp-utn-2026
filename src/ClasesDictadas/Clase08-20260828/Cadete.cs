public class Cadete : ICategoria
{
    public double DevolverNeto()
    {
        return 500000;
    }

    public override string ToString()
    {
        return "La categoria es " + base.ToString();
    }
}