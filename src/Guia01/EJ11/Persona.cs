// src/Guia01/EJ11/Persona.cs
// Gastón Ricchiardi (gastonj@hotmail.com)

public class Persona
{
    // 1. ATRIBUTOS
    private string _nombre = "";
    private string _apellido = "";
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Nombre
    public string GetNombre() { return this._nombre; }
    public void SetNombre(string nombre) { this._nombre = nombre; }

    // Apellido
    public string GetApellido() { return this._apellido; }
    public void SetApellido(string apellido) { this._apellido = apellido; }

    // 4. MÉTODOS (Comportamiento)
    public virtual string Presentarse()
    {
        return $"{this.GetNombre()} {this.GetApellido()}";
    }
}