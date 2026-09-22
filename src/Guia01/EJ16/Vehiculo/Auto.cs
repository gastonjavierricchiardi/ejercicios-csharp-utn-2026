public class Auto : Vehiculo
{
    // 1. CAMPOS / ATRIBUTOS
    private static readonly int capacidadMaxima = 5;

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override void Cargar(Elemento elemento)
    {
        if (TieneCapacidad(capacidadMaxima))
        {
            if (elemento is Televisor)
            {
                AgregarElemento(elemento);
            }
            else if (elemento is Bicicleta)
            {
                AgregarElemento(elemento);
            }
            else if (elemento is CajaPequena)
            {
                AgregarElemento(elemento);
            }
        }
    }
}