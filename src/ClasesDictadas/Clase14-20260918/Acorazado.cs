public class Acorazado : Navio
{
    private string _blindaje;
    public string Blindaje
    {
        get { return _blindaje; }
        set { _blindaje = value; }
    }
    private string _potenciaDeFuego;
    public string PotenciaDeFuego
    {
        get { return _potenciaDeFuego; }
        set { _potenciaDeFuego = value; }
    }
    private string _solidez;
    public string Solidez
    {
        get { return _solidez; }
        set { _solidez = value; }
    }
    private float _velocidadCrucero;
    public float VelocidadCrucero
    {
        get { return _velocidadCrucero; }
        set { _velocidadCrucero = value; }
    }
    
    
    
    
    public override string GetInformacion()
    {
        return $"Soy un acorazado llamado {this.Nombre}";
    }
}