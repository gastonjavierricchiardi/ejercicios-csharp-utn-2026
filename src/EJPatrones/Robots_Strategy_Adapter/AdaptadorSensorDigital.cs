using System;

public class AdaptadorSensorDigital : ISensorTemperatura
{
    private SensorDigitalFahrenheit sensorDigital;

    public AdaptadorSensorDigital(SensorDigitalFahrenheit sensorDigital)
    {
        this.sensorDigital = sensorDigital
            ?? throw new ArgumentNullException(nameof(sensorDigital));
    }

    public double ObtenerTemperaturaCelsius()
    {
        double fahrenheit = sensorDigital.ObtenerTemperaturaFahrenheit();
        return (fahrenheit - 32) * 5.0 / 9.0;
    }
}
