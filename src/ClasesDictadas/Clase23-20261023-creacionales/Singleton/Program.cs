var config1 = Configuracion.GetInstance();
config1.Nombre = "Aplicacion de prueba";

var factura = new Facturador();
var opciones = new OpcionesManager();

Console.WriteLine("Imprimo estado inicial");

Console.WriteLine(opciones.ToString());
factura.Facturar();

Console.WriteLine("Cambio idioma y vuelvo a Imprimir");

opciones.CambiarIdioma("en");
factura.Facturar();

var config2 = Configuracion.GetInstance();

if(config1 == config2)
{
    Console.WriteLine("Las instancias son iguales");
}
else
{
    Console.WriteLine("Las instancias NO son iguales");
}