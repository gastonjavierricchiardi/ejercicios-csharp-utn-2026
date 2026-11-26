# Robots — UML final (código implementado)

```mermaid
classDiagram
    direction TB

    class IArma {
        <<interface>>
        +ObtenerDanio() int
    }
    class Granadas {
        +ObtenerDanio() int
    }
    class RayoLaser {
        +ObtenerDanio() int
    }
    class Espada {
        +ObtenerDanio() int
    }
    class ITraccion {
        <<interface>>
        +ConsumoHp int
        +AutonomiaKm int
        +DeterioroPorcentaje int
        +Deteriorar() void
        +RequiereReemplazo() bool
    }
    class Traccion {
        <<abstract>>
        -int deterioroPorcentaje
        +ConsumoHp int*
        +AutonomiaKm int*
        +DeterioroPorcentaje int
        +Deteriorar() void
        +RequiereReemplazo() bool
    }
    class RuedaCaucho {
        +ConsumoHp int
        +AutonomiaKm int
    }
    class Oruga {
        -ISensorTemperatura sensor
        +ConsumoHp int
        +AutonomiaKm int
        +ObtenerTemperaturaCelsius() double
    }
    class ISensorTemperatura {
        <<interface>>
        +ObtenerTemperaturaCelsius() double
    }
    class SensorMekeM0 {
        -double temperaturaCelsius
        +ObtenerTemperaturaCelsius() double
    }
    class SensorDigitalFahrenheit {
        -double temperaturaFahrenheit
        +ObtenerTemperaturaFahrenheit() double
    }
    class AdaptadorSensorDigital {
        -SensorDigitalFahrenheit sensorDigital
        +ObtenerTemperaturaCelsius() double
    }
    class Robot {
        -string numeroSerie
        -int resistencia
        -IArma arma
        -ITraccion traccion
        +NumeroSerie string
        +Resistencia int
        +Traccion ITraccion
        +PotenciaTraccionDisponibleHp int
        +EstaOperativo() bool
        +Atacar(Robot objetivo) void
        -RecibirDanio(int danio) void
    }
    class Combate {
        -Robot robot1
        -Robot robot2
        +Simular() Robot
    }
    class Program {
        +Main() void$
        -MostrarResultado(Robot primero, Robot segundo) void$
    }

    IArma <|.. Granadas
    IArma <|.. RayoLaser
    IArma <|.. Espada
    ITraccion <|.. Traccion
    Traccion <|-- RuedaCaucho
    Traccion <|-- Oruga
    ISensorTemperatura <|.. SensorMekeM0
    ISensorTemperatura <|.. AdaptadorSensorDigital

    Robot --> IArma : utiliza
    Robot --> ITraccion : utiliza
    Oruga --> ISensorTemperatura : lee temperatura
    AdaptadorSensorDigital --> SensorDigitalFahrenheit : convierte F a C
    Combate --> Robot : coordina dos
    Program ..> Combate : ejecuta
```

Constructores omitidos por legibilidad. El resultado de `Combate.Simular()` es `Robot?` en C# (puede no haber ganador si ambos quedan inoperativos en el mismo ataque).
