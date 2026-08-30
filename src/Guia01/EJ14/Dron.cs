// src/Guia01/EJ14/Dron.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class Dron
{
    // 1. CAMPOS / ATRIBUTOS
    private double velocidadBase;
    private double alturaBase;
    private double pesoSinPenalizacion;
    private Herramienta herramienta;

    // 2. CONSTRUCTOR
    public Dron(Herramienta herramienta)
    {
        this.velocidadBase = 5;
        this.alturaBase = 100;
        this.pesoSinPenalizacion = 200;
        this.herramienta = herramienta;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public Herramienta Herramienta
    {
        get => herramienta;
        set => herramienta = value;
    }
    // 4. MÉTODOS
    // Calculamos los bloques extras que según el enunciado son cada 50
    public double CantidadBloquesExtra()
    {
        double pesoExtra = this.herramienta.Peso - this.pesoSinPenalizacion;

        if (pesoExtra <= 0) // Si peso extra, es menor o igual a 0 regresamos 0 (No hay peso extra según el enunciado)
        {
            return 0;
        }
        // Cada 50 gramos extra representan un bloque de penalización.
        // Las herramientas de la consigna producen excesos múltiplos de 50.
        return pesoExtra / 50;
    }
    // Calculamos la velocidad final
    public double CalcularVelocidadFinal()
    {
        double porcentajePenalizacion = this.CantidadBloquesExtra() * 0.02; // La cantidad de bloques *0.02
                                                                            // Pedimos la velocidad base y le restamos (la velocidad base  * porcentaje de penalización)
        return this.velocidadBase - (this.velocidadBase * porcentajePenalizacion);
    }
    // Lo mismo con la altura, hacemos los calculos
    public double CalcularAlturaFinal()
    {
        double porcentajePenalizacion = this.CantidadBloquesExtra() * 0.05;

        return this.alturaBase - (this.alturaBase * porcentajePenalizacion);
    }

    // Mostramos los datos
    public string GetInfo()
    {
        return $"Velocidad: {this.CalcularVelocidadFinal()} m/s, " +
               $"altura: {this.CalcularAlturaFinal()} m, " +
               $"herramienta: {this.herramienta.GetTipoHerramienta()}";
    }


}