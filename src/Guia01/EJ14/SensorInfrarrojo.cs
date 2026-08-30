// src/Guia01/EJ14/SensorInfrarrojo.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class SensorInfrarrojo : Herramienta
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public SensorInfrarrojo() : base(250)
    {
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    // Comportamiento del objeto.
    public override string GetTipoHerramienta()
    {
        return "Sensor infrarrojo";
    }
}