public class ReinoDeCaballito
{
    private List <Navio> navios;

    public ReinoDeCaballito()
    {
        this.navios = new List<Navio>();
    }

    public void AgregarNavio(Navio navio)
    {
        this.navios.Add(navio);
    }

    public string PresentarArmada ()
    {
        string textoPresentacion = string.Empty;
        foreach (Navio barco in navios)
        {
            textoPresentacion += barco.GetInformacion() + Environment.NewLine;
        }
        return textoPresentacion;
    }
}