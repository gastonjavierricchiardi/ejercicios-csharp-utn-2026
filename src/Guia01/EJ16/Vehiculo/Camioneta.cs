public class Camioneta : Vehiculo
{
    // 1. CAMPOS / ATRIBUTOS
    private static readonly int capacidadMaxima = 10;

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override void Cargar(Elemento elemento)
    {
        if (TieneCapacidad(capacidadMaxima))
        {
            if (elemento is Comoda)
            {
                AgregarElemento(elemento);
            }
            else if (elemento is Heladera)
            {
                AgregarElemento(elemento);
            }
            else if (elemento is Lavarropas)
            {
                AgregarElemento(elemento);
            }
        }
    }
}