# Diseño conceptual

```txt
Vagon <<abstract>>
+ PesoMaximo()

VagonPasajeros : Vagon
- largo
- anchoUtil
+ CantidadPasajeros()
+ PesoMaximo()

VagonCarga : Vagon
- cargaMaxima
+ PesoMaximo()

Locomotora
- peso
- pesoMaximoArrastre
- velocidadMaxima
+ ArrastreUtil()

Formacion
- locomotoras
- vagones
- estaEnMovimiento
+ TotalPasajeros()
+ CantidadVagonesLivianos()
+ VelocidadMaxima()
+ EsEficiente()
+ PuedeMoverse()
+ KilosEmpujeFaltantes()
+ EsCompleja()

Deposito
- formaciones
- locomotorasSueltas
+ VagonesMasPesados()
+ NecesitaConductorExperimentado()
+ AgregarLocomotora(Formacion)
```
