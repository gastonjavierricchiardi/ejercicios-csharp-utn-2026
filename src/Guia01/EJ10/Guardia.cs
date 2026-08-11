// src/Guia01/EJ10/Guardia.cs

public class Guardia : Persona
{
    // 1. ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS (Comportamiento)
    public override string Presentarse()
    {
        return $"Hola, mi nombre es {this.GetNombre()} {this.GetApellido()} y soy el guardia";
    }

    public string ControlarDocumento(int dni)
    {
        return $"Adelante persona con dni {dni}";
    }
}