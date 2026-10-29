// EJ01-Adapter
public class LocalSensor : ITemperatureSensor
{
    // 1. CAMPOS / ATRIBUTOS
    private string name;
    private double temperatureCelsius;

    // 2. CONSTRUCTOR
    public LocalSensor(
        string name,
        double temperatureCelsius
    )
    {
        this.name = name;
        this.temperatureCelsius = temperatureCelsius;
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
        return temperatureCelsius;
    }
}