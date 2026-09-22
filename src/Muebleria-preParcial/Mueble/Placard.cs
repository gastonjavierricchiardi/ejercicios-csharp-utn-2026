public class Placard : MuebleVoluminoso
{
    // 1. CAMPOS / ATRIBUTOS
    private double lado1;
    private double lado2;

    // 2. CONSTRUCTOR
    public Placard(
        string nombre,
        double precioUnitario,
        int stock,
        double altura,
        double lado1,
        double lado2
    ) : base(nombre, precioUnitario, stock, altura)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override double CalcularVolumen()
    {
        return lado1 * lado2 * altura;
    }
}