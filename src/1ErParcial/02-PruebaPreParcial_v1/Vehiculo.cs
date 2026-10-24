public abstract class Vehiculo
{
    public string Patente { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double PrecioBasePorDia { get; set; }

    public Vehiculo(
        string patente,
        string marca,
        string modelo,
        double precioBasePorDia)
    {
        Patente = patente;
        Marca = marca;
        Modelo = modelo;
        PrecioBasePorDia = precioBasePorDia;
    }

    public abstract double CalcularCosto(int dias, double kilometrosRecorridos);
}