// /src/Herencia/Herencia03_celulares/Motorola.cs
public class MotorolaG5 : Telefono
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override void Llamar(Telefono telefono, double duracion)
    {
        DescontarBateria(0.25);
    }
}