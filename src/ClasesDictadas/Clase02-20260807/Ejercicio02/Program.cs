Console.WriteLine("Hello, World!");

Vehiculo vehiculo = new Vehiculo("Ford", "AA000AA", "Fiesta");
vehiculo.Info();
//vehiculo.pantete = "AA000AA";


public class Vehiculo
{
    public string marca;
    private string patente;
    public string modelo;

    public Vehiculo(string marca, string p_patente, string modelo)
    {
        this.marca=marca;
        this.patente=p_patente;
        this.modelo=modelo;
    }
    
    public void Info ()
    {
        Console.WriteLine("Marca: " + this.marca + " Modelo: " + this.modelo + " Patente: " + patente); 
    }

}