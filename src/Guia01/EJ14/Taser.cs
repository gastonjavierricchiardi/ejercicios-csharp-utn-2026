// src/Guia01/EJ14/Taser.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class Taser : Herramienta
{

    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public Taser() : base(300)
    {
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override string GetTipoHerramienta()
    {
        return "Taser";
    }
}