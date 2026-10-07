// EJ21
public class Prestamo
{
    // 1. CAMPOS / ATRIBUTOS

    private double monto;
    private double interes;

    // 2. CONSTRUCTOR
    public Prestamo(
        double monto,
        double interes
        )
    {
        this.monto = monto;
        this.interes = interes;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public double Interes
    {
        get { return interes; }
        //        set { interes = value; }
    }
    public double Monto
    {
        get { return monto; }
        //        set { monto = value; }
    }

    // 4. MÉTODOS
}