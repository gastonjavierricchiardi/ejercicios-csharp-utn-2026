public class MesaCuadrada : MuebleVoluminoso
{
    // 1. CAMPOS / ATRIBUTOS
    private double lado;

    // 2. CONSTRUCTOR
    public MesaCuadrada(
        string nombre,
        double precioUnitario,
        int stock,
        double altura,
        double lado
    ) : base(nombre, precioUnitario, stock, altura)
    {
        this.lado = lado;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override double CalcularVolumen()
    {
        return lado * lado * altura;
    }
}