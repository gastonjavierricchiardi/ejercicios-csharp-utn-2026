// EJ01-Adapter
using System;
using System.Collections.Generic;
//using System.Globalization;
public class TemperatureMonitor
{
    // 1. CAMPOS / ATRIBUTOS
    private List<ITemperatureSensor> sensors;

    // 2. CONSTRUCTOR
    public TemperatureMonitor()
    {
        sensors = new List<ITemperatureSensor>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void AddSensor(ITemperatureSensor sensor)
    {
        sensors.Add(sensor);
    }
    /*
        public void ShowTemperatures()
        {
            foreach (ITemperatureSensor sensor in sensors)
            {
                string name = sensor.GetName();

                double temperature = sensor.GetTemperatureCelsius();

                string formattedTemperature = temperature.ToString(
                    "F1",
                    CultureInfo.InstalledUICulture
                );
                System.Console.WriteLine($"{name}: {formattedTemperature} °C");
            }
}*/

    public void ShowTemperatures()
    {
        foreach (ITemperatureSensor sensor in sensors)
        {
            System.Console.WriteLine($"{sensor.GetName()}: {sensor.GetTemperatureCelsius()} °C");
        }
    }
}