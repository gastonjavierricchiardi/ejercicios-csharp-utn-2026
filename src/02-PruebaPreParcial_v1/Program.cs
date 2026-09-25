// Gastón Ricchiardi (gastonj@hotmail.com)

using System;

Empresa empresa = new Empresa();

Auto auto = new Auto(
    "AA111AA",
    "Toyota",
    "Corolla",
    10000);

Camioneta camioneta = new Camioneta(
    "BB222BB",
    "Ford",
    "Ranger",
    15000,
    200);

Moto moto = new Moto(
    "CC333CC",
    "Honda",
    "Wave",
    5000);


// REGISTRO DE VEHÍCULOS

empresa.RegistrarVehiculo(auto);
empresa.RegistrarVehiculo(camioneta);
empresa.RegistrarVehiculo(moto);


// CONSULTA DE VEHÍCULOS

Console.WriteLine("=== VEHÍCULOS REGISTRADOS ===");

foreach (Vehiculo vehiculo in empresa.ConsultarVehiculos())
{
    Console.WriteLine(
        $"{vehiculo.Patente} - {vehiculo.Marca} {vehiculo.Modelo}");
}


// BÚSQUEDA POR PATENTE

Console.WriteLine("\n=== BÚSQUEDA ===");

Vehiculo? encontrado = empresa.BuscarVehiculo("BB222BB");

if (encontrado != null)
{
    Console.WriteLine(
        $"Encontrado: {encontrado.Marca} {encontrado.Modelo}");
}


// ALQUILERES

Console.WriteLine("\n=== ALQUILERES ===");

Alquiler alquilerAuto =
    empresa.RegistrarAlquiler(auto, 3, 100);

Alquiler alquilerCamioneta =
    empresa.RegistrarAlquiler(camioneta, 2, 250);

Alquiler alquilerMoto =
    empresa.RegistrarAlquiler(moto, 4, 80);

Console.WriteLine(
    $"Costo auto: ${alquilerAuto.CalcularCostoTotal()}");

Console.WriteLine(
    $"Costo camioneta: ${alquilerCamioneta.CalcularCostoTotal()}");

Console.WriteLine(
    $"Costo moto: ${alquilerMoto.CalcularCostoTotal()}");


// VEHÍCULO DUPLICADO

Console.WriteLine("\n=== PATENTE DUPLICADA ===");

try
{
    Auto autoDuplicado = new Auto(
        "AA111AA",
        "Fiat",
        "Cronos",
        9000);

    empresa.RegistrarVehiculo(autoDuplicado);
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}


// ENTREGA VÁLIDA

Console.WriteLine("\n=== ENTREGA VÁLIDA ===");

try
{
    Entrega entrega =
        empresa.RegistrarEntrega(auto, 150);

    Console.WriteLine(
        $"Entrega registrada: {entrega.Vehiculo.ObtenerDescripcion()}");
}
catch (CapacidadCargaExcedidaException exception)
{
    Console.WriteLine(exception.Message);
}


// ENTREGA QUE SUPERA LA CAPACIDAD

Console.WriteLine("\n=== ENTREGA CON EXCESO DE CARGA ===");

try
{
    empresa.RegistrarEntrega(camioneta, 1200);
}
catch (CapacidadCargaExcedidaException exception)
{
    Console.WriteLine(exception.Message);
}