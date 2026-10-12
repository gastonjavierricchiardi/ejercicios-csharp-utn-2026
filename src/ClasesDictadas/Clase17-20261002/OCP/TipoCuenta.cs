public abstract class TipoCuenta
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private float _monto;
    public float Monto
    {
        get { return _monto; }
        set { _monto = value; }
    }

    public TipoCuenta()
    {
        this.Monto = 0;
    }

    public abstract void Retirar(float unMonto);
    public void IngresarMonto (float unMonto)
    {
        //System.Console.WriteLine($"DEBUG - {unMonto} / {this.Monto}");
        this.Monto  += unMonto;
    }
}