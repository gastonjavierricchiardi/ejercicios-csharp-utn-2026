public class Destructor : Navio, IAcarreable
{
    private int _maniobrabilidad;
    public int Maniobrabilidad
    {
        get { return _maniobrabilidad; }
        set { _maniobrabilidad = value; }
    }

    private float peso =0;
    public Destructor(string nombre, float peso)
    {
        this.Nombre = nombre;
        this.peso = peso;
    }

    public string GetDescripcion()
    {
        return $"SOy un destructor y fui bautizado con el nombre de {this.Nombre} y peso {this.GetPeso()}";
    }

    public override string GetInformacion()
    {
        return this.GetDescripcion();
    }

    public float GetPeso()
    {
        return this.peso;
    }
}