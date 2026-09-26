// (gastonj@hotmail.com)

using System;
using System.Collections.Generic;
using MisClases;

TransportesDelLitoral transportes = new TransportesDelLitoral();

Documentacion documentacion = new Documentacion(
    1001,
    "Rosario",
    300,
    2,
    10);

Paquete paquete = new Paquete(
    1002,
    "Cordoba",
    500,
    10,
    12);

CargaPesada cargaPesada = new CargaPesada(
    1003,
    "Mendoza",
    1000,
    120,
    15,
    100);

Console.WriteLine("=== Registro ===");

Console.WriteLine("Guía 1001 registrada: " + transportes.RegistrarEnvio(documentacion));

Console.WriteLine("Guía 1002 registrada: " + transportes.RegistrarEnvio(paquete));

Console.WriteLine("Guía 1003 registrada: " + transportes.RegistrarEnvio(cargaPesada));


Console.WriteLine();
Console.WriteLine("=== Guía duplicada ===");

Paquete paqueteDuplicado = new Paquete(
    1002,
    "Santa Fe",
    200,
    5,
    10);

bool registroDuplicado = transportes.RegistrarEnvio(paqueteDuplicado);

Console.WriteLine("Segundo registro de guía 1002 aceptado: " + registroDuplicado);


Console.WriteLine();
Console.WriteLine("=== Búsqueda por guía ===");

Envio? encontrado = transportes.BuscarPorGuia(1003);

if (encontrado != null)
{
    Console.WriteLine(
        "Encontrado: "
        + encontrado.NumeroGuia
        + " - "
        + encontrado.Destino);
}


Console.WriteLine();
Console.WriteLine("=== Costos ===");

Console.WriteLine("Documentación: $" + documentacion.CalcularCosto());

Console.WriteLine("Paquete: $" + paquete.CalcularCosto());

Console.WriteLine("Carga pesada: $" + cargaPesada.CalcularCosto());


Console.WriteLine();
Console.WriteLine("=== Seguros ===");

transportes.ContratarSeguro(
    paquete,
    50000,
    "Cobertura de mercadería");

transportes.ContratarSeguro(
    cargaPesada,
    200000,
    "Cobertura de carga pesada");

Console.WriteLine("Paquete asegurado: " + paquete.TieneSeguroContratado());

Console.WriteLine("Carga pesada asegurada: " + cargaPesada.TieneSeguroContratado());


Console.WriteLine();
Console.WriteLine("=== Intento de asegurar documertancion ===");

try
{
    transportes.ContratarSeguro(
        documentacion,
        10000,
        "Cobertura documental");
}
catch (EnvioNoAsegurableException ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine();
Console.WriteLine("=== Proximo envío ===");

Envio? proximo = transportes.ConsultarProximo();

if (proximo != null)
{
    Console.WriteLine("Próximo: " + proximo.NumeroGuia);
}


Console.WriteLine();
Console.WriteLine("=== Despachos ===");

Envio? primerDespacho = transportes.Despachar();
Envio? segundoDespacho = transportes.Despachar();

if (primerDespacho != null)
{
    Console.WriteLine("Primer despacho: " + primerDespacho.NumeroGuia);
}

if (segundoDespacho != null)
{
    Console.WriteLine("Segundo despacho: " + segundoDespacho.NumeroGuia);
}

Envio? nuevoProximo = transportes.ConsultarProximo();

if (nuevoProximo != null)
{
    Console.WriteLine("Ahora queda primero: " + nuevoProximo.NumeroGuia);
}


Console.WriteLine();
Console.WriteLine("=== Historia completo ===");

List<Envio> historial = transportes.ObtenerHistorial();

foreach (Envio envio in historial)
{
    Console.WriteLine(
        envio.NumeroGuia
        + " - "
        + envio.Destino
        + " - $"
        + envio.CalcularCosto());
}


Console.WriteLine();
Console.WriteLine("=== Totales ===");

Console.WriteLine("Facturación total: $" + transportes.CalcularFacturacion());

Console.WriteLine("Promedio de envíos asegurados: $" + transportes.CalcularCostoPromedioAsegurados());