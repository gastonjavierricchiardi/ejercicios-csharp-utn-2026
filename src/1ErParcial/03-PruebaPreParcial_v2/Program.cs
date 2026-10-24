// gastonj@hotmail.com

using System;

Empresa empresa = new Empresa();

Auto auto = new Auto(
    "AA111AA",
    "Toyota",
    "Corolla",
    10000,
    300);

Moto moto = new Moto(
    "BB222BB",
    "Honda",
    "Wave",
    5000,
    50);

Camioneta camioneta = new Camioneta(
    "CC333CC",
    "Ford",
    "Ranger",
    15000,
    1000,
    200);


// Registrar vehículos

empresa.RegistrarVehiculo(auto);
empresa.RegistrarVehiculo(moto);
empresa.RegistrarVehiculo(camioneta);


// Alquileres

Alquiler alquilerAuto =
    empresa.RegistrarAlquiler(auto, 2, 100);

Alquiler alquilerMoto =
    empresa.RegistrarAlquiler(moto, 3, 80);

Alquiler alquilerCamioneta =
    empresa.RegistrarAlquiler(camioneta, 2, 250);

Console.WriteLine(
    "Costo auto: $" + alquilerAuto.CalcularCosto());

Console.WriteLine(
    "Costo moto: $" + alquilerMoto.CalcularCosto());

Console.WriteLine(
    "Costo camioneta: $" + alquilerCamioneta.CalcularCosto());


// Buscar vehículo

Vehiculo? encontrado =
    empresa.BuscarVehiculo("AA111AA");

if (encontrado != null)
{
    Console.WriteLine(
        "Vehículo encontrado: "
        + encontrado.ObtenerDescripcion());
}


// Intentar registrar patente duplicada

Auto autoDuplicado = new Auto(
    "AA111AA",
    "Ford",
    "Focus",
    12000,
    350);

bool registrado =
    empresa.RegistrarVehiculo(autoDuplicado);

Console.WriteLine(
    "Vehículo duplicado registrado: "
    + registrado);


// Entrega válida

Entrega entrega =
    empresa.RegistrarEntrega(auto, 200);

Console.WriteLine(
    "Entrega registrada para: "
    + entrega.GetVehiculo().ObtenerDescripcion());


// Entrega que supera la capacidad

try
{
    empresa.RegistrarEntrega(moto, 100);
}
catch (CapacidadCargaExcedidaException ex)
{
    Console.WriteLine(ex.Message);
}


// Consultar vehículos registrados

Console.WriteLine("Vehículos registrados:");

foreach (Vehiculo vehiculo in empresa.ObtenerVehiculos())
{
    Console.WriteLine(
        vehiculo.ObtenerDescripcion());
}