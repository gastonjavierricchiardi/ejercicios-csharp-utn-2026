using System.Security;

public class Cuenta
{

    public float Monto
    {
        get { return _tipoCuenta.Monto; }
    
    }

    private TipoCuenta _tipoCuenta;
    public TipoCuenta TipoCuenta
    {
        get { return _tipoCuenta; }
        set { _tipoCuenta = value; }
    }

    public string Depositar(float plata)
    {
        this.TipoCuenta.IngresarMonto(plata);
        return $"Se ingresaron {plata} a la cuenta {TipoCuenta.Nombre}";
    }

    public float ObtenerMonto ()
    {
        return this.TipoCuenta.Monto;
    }

    public void SetMonto (float unMonto)
    {
        this.TipoCuenta.IngresarMonto(unMonto);
    }

    public void Retirar(float unMonto)
    {
        this.TipoCuenta.Retirar(unMonto);
    }

    public string ImprimirInfo()
    {
        return $"Nombre cuenta bancaria {this.TipoCuenta.Nombre}, tiene un saldo de  {this.Monto}";
    }
    
    
}