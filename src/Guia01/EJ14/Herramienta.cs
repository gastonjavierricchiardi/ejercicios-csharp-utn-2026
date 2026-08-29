// src/Guia01/EJ14/Herramienta.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public abstract class Herramienta
{
    // 1. CAMPOS / ATRIBUTOS
    // Estado interno del objeto.
    // Normalmente private.
    private double peso; // en gramos

    // 2. CONSTRUCTOR
    // Recibe los datos necesarios al crear el objeto.
    public Herramienta(double peso)
    {
        this.peso = peso;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Formas de exponer o modificar el estado.
    public double Peso { get => peso; }

    // 4. MÉTODOS
    // Comportamiento del objeto.

    public abstract string GetTipoHerramienta();
}