// src/Guia01/EJ14/BrazoRobotico.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class BrazoRobotico : Herramienta
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public BrazoRobotico() : base(500) // Peso en gramos, se ignora el valor recibido por parámetro
    {
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Formas de exponer o modificar el estado.

    // 4. MÉTODOS
    // Comportamiento del objeto.

    public override string GetTipoHerramienta()
    {
        return "Brazo robótico";
    }
}