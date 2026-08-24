Console.WriteLine("¡Bienvenidos a Programación II!");
int dia = 7;

Console.WriteLine("El día de hoy es: " + dia.ToString());

string unaCadena = "Hola, estamos en Programación II";
Console.WriteLine(unaCadena);

Persona leonardo = new Persona();

//Auto unAuto = new Auto();

leonardo.apellido = "Pinkas";
leonardo.nombre = "Leonardo";

//Console.WriteLine(leonardo.apellido + ", " + leonardo.nombre);
leonardo.Presentarse();


Persona andres = new Persona();
andres.apellido = "Chimuris";
andres.nombre = "Andrés";


andres.Saludar(leonardo);
andres.SaludarA("Mauro");


class Persona
{
    public string nombre;
    public string apellido;

    public void Presentarse()
    {

        Console.WriteLine(this.apellido + ", " + this.nombre);
    }

    public void Saludar(Persona aQuienSaludo)
    {
        Console.WriteLine("Hola " + aQuienSaludo.nombre + ", me llamo " + this.nombre);
    }

    public void SaludarA(string nombre)
    {
        Console.WriteLine("Hola " + nombre + ", me llamo " + this.nombre);
    }
}