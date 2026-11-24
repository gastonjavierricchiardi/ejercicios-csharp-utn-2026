using System;
public class Destino : IObservadorHora
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private int diferenciaHoraria;
    private DateTime fechaHoraActual;

    // 2. CONSTRUCTOR
    public Destino(string nombre, int diferenciaHoraria)
    {
        this.nombre = nombre;
        this.diferenciaHoraria = diferenciaHoraria;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Nombre
    {
        get { return nombre; }
    }

    public int DiferenciaHoraria
    {
        get { return diferenciaHoraria; }
    }

    public DateTime FechaHoraActual
    {
        get { return fechaHoraActual; }
    }

    // 4. MÉTODOS
    public void Actualizar(DateTime fechaHoraLocal)
    {
        fechaHoraActual =
            fechaHoraLocal.AddHours(diferenciaHoraria);
    }
}