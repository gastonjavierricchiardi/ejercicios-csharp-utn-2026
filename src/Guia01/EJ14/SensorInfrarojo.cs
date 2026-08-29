// src/Guia01/EJ14/SensorInfrarojo.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class SensorInfrarojo : Herramienta
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    /* Este es el constructor creao por defecto que solo hay que cambiarle el valor.
    public SensorInfrarojo(double peso) : base(peso){}*/
    public SensorInfrarojo(double peso) : base(250) // Peso en gramos, se ignora el valor recibido por parámetro
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