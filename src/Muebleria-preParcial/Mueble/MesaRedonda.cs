using System;

public class MesaRedonda : MuebleVoluminoso
{
    // 1. CAMPOS / ATRIBUTOS
    private double radio;

    // 2. CONSTRUCTOR
    public MesaRedonda(
        string nombre,
        double precioUnitario,
        int stock,
        double altura,
        double radio
    ) : base(nombre, precioUnitario, stock, altura)
    {
        this.radio = radio;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override double CalcularVolumen()
    {
        return Math.PI * radio * radio * altura;
    }
}