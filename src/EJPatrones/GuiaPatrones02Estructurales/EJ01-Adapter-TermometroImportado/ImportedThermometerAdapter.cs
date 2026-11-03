// EJ01-Adapter
public class ImportedThermometerAdapter : ITemperatureSensor
{
    // 1. CAMPOS / ATRIBUTOS
    private string name;
    private ImportedThermometer thermometer;
    // 2. CONSTRUCTOR
    public ImportedThermometerAdapter(
        string name,
        ImportedThermometer thermometer
    )
    {
        this.name = name;
        this.thermometer = thermometer;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public string GetName()
    {
        //throw new NotImplementedException();
        return name;
    }
    public void SetName(string name)
    {
        //throw new NotImplementedException();
        this.name = name;
    }

    public double GetTemperatureCelsius()
    {
        //throw new NotImplementedException();
        double fahrenheit = thermometer.ReadFahrenheit();
        double celsius = (fahrenheit - 32) * 5.0 / 9.0;

        return celsius;
    }
}