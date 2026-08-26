// /src/Herencia/Herencia03_celulares/IPhone.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class IPhone : Telefono
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override void Llamar(Telefono telefono, double duracion)
    {
        // CONSOLIDADO DEL PROFESOR.
        double consumo = duracion * 0.1;
        DescontarBateria(consumo);
    }
}
