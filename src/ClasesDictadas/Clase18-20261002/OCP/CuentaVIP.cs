public class CuentaVIP : TipoCuenta
{
    public override void Retirar(float unMonto)
    {
        this.Monto -= unMonto;
        System.Console.WriteLine("Estamos retirando plata de una cuenta VIP... permite tener fondos ilimitados");
    }
}