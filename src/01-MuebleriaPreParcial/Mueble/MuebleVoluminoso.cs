public abstract class MuebleVoluminoso : Mueble
{
    // 1. CAMPOS / ATRIBUTOS
    protected double altura;

    // 2. CONSTRUCTOR
    public MuebleVoluminoso(
        string nombre,
        double precioUnitario,
        int stock,
        double altura
    ) : base(nombre, precioUnitario, stock)
    {
        this.altura = altura;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public abstract double CalcularVolumen();
    public override double CalcularPrecio(int cantidad)
    {
        double precio = base.CalcularPrecio(cantidad);
        double volumen = CalcularVolumen();

        if (volumen > 2)
        {
            precio = precio * 1.75;
        }
        else if (volumen >= 1)
        {
            precio = precio * 1.50;
        }
        else
        {
            precio = precio * 1.20;
        }
        return precio;
    }
}