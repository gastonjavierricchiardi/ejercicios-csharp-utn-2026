// EJ01-Adapter
public class ImportedThermometer
{
    // 1. CAMPOS / ATRIBUTOS
    private double temperatureFahrenheit;
    // 2. CONSTRUCTOR
    public ImportedThermometer(double temperatureFahrenheit)
    {
        this.temperatureFahrenheit = temperatureFahrenheit;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public double ReadFahrenheit()
    {
        return temperatureFahrenheit;
    }
}