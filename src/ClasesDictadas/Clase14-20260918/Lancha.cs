public class Lancha : Navio
{
    public static int PesoMaximoDeAcarreo = 300;


    public bool Acarrear(IAcarreable algoAcarreable)
    {
        if (Lancha.PesoMaximoDeAcarreo < algoAcarreable.GetPeso())
            return false;
        else
            return true;
    }
    public override string GetInformacion()
    {
        return $"Soy la lancha llamada {this.Nombre}";
    }
}