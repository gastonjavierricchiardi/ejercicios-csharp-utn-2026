
Persona unaPersona = new Empleado("    leo     ", "Pinkas   ");
string apellido = unaPersona.LastName;

Console.WriteLine($"Hola {unaPersona.LastName}, {unaPersona.GetName()} !");

unaPersona = new Empleado();
unaPersona.SetName("Juancito");
Console.WriteLine($"Hola {unaPersona.LastName}, {unaPersona.GetName()} !");

// Casteo implicito
Persona unEmpleado = new Empleado("Leo", "Pinkas", 1213121,20);

Empleado otroEmpleado = new Empleado("Juan", "Perez", 11222333,20);
DatosContacto datosContacto = new DatosContacto("4555666","leo@mail.com");
otroEmpleado.Contacto = datosContacto;

Proveedor otraPersona = new Proveedor();

Console.WriteLine(otraPersona.Saludar());
Console.WriteLine(otroEmpleado.Saludar());

ICosteable costeable = otraPersona;
Console.WriteLine(costeable.CalcularCosto());
Console.WriteLine(otroEmpleado.CalcularCosto());
Console.WriteLine(new Empresa().CalcularCosto());

var items = new List<ICosteable>();
items.Add(otraPersona);

Dictionary<int, Empleado> empleados = new Dictionary<int, Empleado>();
empleados.Add(otroEmpleado.Legajo, otroEmpleado);

int legjoBuscado = otroEmpleado.Legajo;

Console.WriteLine(empleados[legjoBuscado].Saludar());

foreach(var empleado in empleados)
{
    Console.WriteLine($"clave:{empleado.Key} valor: {empleado.Value}");
}

HashSet<Empleado> listaUnicaEmpleados = new HashSet<Empleado>();
listaUnicaEmpleados.Add((Empleado) unEmpleado);
listaUnicaEmpleados.Add(otroEmpleado);
Console.WriteLine($"Empleados agregados: {listaUnicaEmpleados.Count}");

var tercerEmpleado = new Empleado("Roberto", "Sanchez", 11222333, 50);
var result = listaUnicaEmpleados.Add(tercerEmpleado);
Console.WriteLine($"Empleados agregados: {listaUnicaEmpleados.Count}");

var esElMismo = tercerEmpleado == otroEmpleado;
var esIgual = tercerEmpleado.Equals(otroEmpleado);

Console.WriteLine($"Las cargas sociales son {Empleado.CargasSociales}");

Empleado.FormatearTexto("dsfsdfsd");