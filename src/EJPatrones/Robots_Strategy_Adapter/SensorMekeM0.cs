public class SensorMekeM0 : ISensorTemperatura
{
    private double temperaturaCelsius;

    public SensorMekeM0(double temperaturaCelsius)
    {
        this.temperaturaCelsius = temperaturaCelsius;
    }

    public double ObtenerTemperaturaCelsius()
    {
        return temperaturaCelsius;
    }
}
