// /Program.cs
Persona unaPersona = new Persona("pepe", "loco");

// tenemos que usarlo como un método (llamándolo)
//unaPersona.SetName("    gastón     "); // Si hago    _uu no borra porque entiende que los espacios deberían estar.

//unaPersona.LastName = "    ricchi"; // tenerlo como {get; set;}
// Nos permite usarlo como un método entonces podemos guardar
// Variables así

string apellido = unaPersona.LastName;

Console.WriteLine("Hola " + unaPersona.GetName() + " !");
Console.WriteLine("Hola " + unaPersona.LastName + ", " + unaPersona.GetName() + " !");

// Sting interpolletion se puede armar una cadena metiendo variables entre medio
// Expresiones que generan un sting
unaPersona = new Persona();

unaPersona.SetName("Juancito");

Console.WriteLine($"Hola {unaPersona.LastName}, {unaPersona.GetName()} !");

Empleado unEmpleado = new Empleado();
