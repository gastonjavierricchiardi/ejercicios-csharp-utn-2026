using System;

public class Oruga : Traccion
{
    private ISensorTemperatura sensor;

    public Oruga(ISensorTemperatura sensor)
    {
        this.sensor = sensor ?? throw new ArgumentNullException(nameof(sensor));
    }

    public override int ConsumoHp
    {
        get { return 3; }
    }

    public override int AutonomiaKm
    {
        get { return 400; }
    }

    public double ObtenerTemperaturaCelsius()
    {
        return sensor.ObtenerTemperaturaCelsius();
    }
}
