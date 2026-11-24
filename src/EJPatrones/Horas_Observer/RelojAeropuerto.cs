using System;
using System.Collections.Generic;
public class RelojAeropuerto
{
    // 1. CAMPOS / ATRIBUTOS
    private DateTime fechaHoraLocal;
    private List<IObservadorHora> destinos;

    // 2. CONSTRUCTOR
    public RelojAeropuerto(DateTime fechaHoraLocal)
    {
        this.fechaHoraLocal = fechaHoraLocal;
        destinos = new List<IObservadorHora>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public DateTime FechaHoraLocal
    {
        get { return fechaHoraLocal; }
    }

    // 4. MÉTODOS
    public void EstablecerFechaHoraLocal(DateTime nuevaFechaHora)
    {
        fechaHoraLocal = nuevaFechaHora;
        NotificarDestinos();
    }

    public void AgregarDestino(IObservadorHora destino)
    {
        if (!destinos.Contains(destino))
        {
            destinos.Add(destino);
            destino.Actualizar(fechaHoraLocal);
        }
    }

    public void EliminarDestino(IObservadorHora destino)
    {
        destinos.Remove(destino);
    }

    private void NotificarDestinos()
    {
        foreach (IObservadorHora destino in destinos)
        {
            destino.Actualizar(fechaHoraLocal);
        }
    }
}