public class CuentaSueldo : TipoCuenta
{
    private readonly float MONTO_NEGATIVO_CUENTAS_SUELDO = -200000;
    public override void Retirar(float unMonto)
    {
        System.Console.WriteLine("Ingresando en la cuenta sueldo...");
        System.Console.WriteLine("Queriendo realizar operación de retiro de fondos...");
        if ((this.Monto - unMonto) >= 0)
        {
            this.Monto = this.Monto - unMonto;
        }else
        {
            if((this.Monto - unMonto) > MONTO_NEGATIVO_CUENTAS_SUELDO)
                this.Monto = this.Monto - unMonto * (float)(1.5);
            else
                System.Console.WriteLine("Operación no permitida, por favor contactese con su ejecutivo/a de cuenta");
        }
    }
}