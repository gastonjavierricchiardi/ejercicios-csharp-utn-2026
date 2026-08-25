// src/Guia01/EJ12/Guardia.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
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

    public string ControlarDocumento(Visitante visitante)
    {
        return $"Adelante {visitante.Presentarse()} con dni {visitante.GetDni()}";
    }
}