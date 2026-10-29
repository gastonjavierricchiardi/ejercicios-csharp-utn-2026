//EJ01-Adapter
using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        ITemperatureSensor localSensor = new LocalSensor("Sensor local", 25.3);

        ImportedThermometer importedThermometer = new ImportedThermometer(98.6);

        ITemperatureSensor importedSensor = new ImportedThermometerAdapter(
            "Sensor importado",
            importedThermometer
        );

        TemperatureMonitor monitor = new TemperatureMonitor();

        monitor.AddSensor(localSensor);
        monitor.AddSensor(importedSensor);

        monitor.ShowTemperatures();
    }
}
