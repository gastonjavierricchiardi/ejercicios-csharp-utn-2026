// /src/Herencia/Herencia03_celulares/Program.cs
public class iPhone : Telefono
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override void Llamar(Telefono telefono, double duracion)
    {
        // PENDIENTE:
        // reemplazar este consumo, cuando el profesor aclare
        // cómo calcular el 0,1% según la duración de la llamada.
        DescontarBateria(0.25);
    }
}
