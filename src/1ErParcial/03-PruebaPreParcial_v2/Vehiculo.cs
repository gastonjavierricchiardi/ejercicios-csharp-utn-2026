public abstract class Vehiculo : IEntregable
{
    private string patente;
    private string marca;
    private string modelo;
    private double precioBasePorDia;
    private double capacidadCarga;

    public Vehiculo(
        string patente,
        string marca,
        string modelo,
        double precioBasePorDia,
        double capacidadCarga)
    {
        this.patente = patente;
        this.marca = marca;
        this.modelo = modelo;
        this.precioBasePorDia = precioBasePorDia;
        this.capacidadCarga = capacidadCarga;
    }

    public string GetPatente() { return patente; }

    public string GetMarca() { return marca; }

    public string GetModelo() { return modelo; }

    public double GetPrecioBasePorDia()
    {
        return precioBasePorDia;
    }

    public double GetCapacidadCarga()
    {
        return capacidadCarga;
    }

    public string ObtenerDescripcion()
    {
        return marca + " " + modelo + " - Patente: " + patente;
    }

    public abstract double CalcularCosto(
        int dias,
        double kilometrosRecorridos);
}