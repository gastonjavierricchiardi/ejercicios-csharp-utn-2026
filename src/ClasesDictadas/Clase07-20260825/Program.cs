
Persona unaPersona = new Empleado("    leo     ", "Pinkas   ");
string apellido = unaPersona.LastName;

Console.WriteLine($"Hola {unaPersona.LastName}, {unaPersona.GetName()} !");

unaPersona = new Empleado();
unaPersona.SetName("Juancito");
Console.WriteLine($"Hola {unaPersona.LastName}, {unaPersona.GetName()} !");

// Casteo implicito
Persona unEmpleado = new Empleado("Leo", "Pinkas", 1213121,20);

Empleado otroEmpleado = new Empleado();
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


