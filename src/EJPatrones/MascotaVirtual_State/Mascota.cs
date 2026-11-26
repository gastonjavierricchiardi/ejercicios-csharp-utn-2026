using System;

public class Mascota
{
    private EstadoMascota estado;
    private int nivelContenta;

    public Mascota(EstadoMascota estadoInicial)
    {
        if (estadoInicial == null)
        {
            throw new ArgumentNullException(nameof(estadoInicial));
        }

        estado = estadoInicial;
        nivelContenta = 0;
    }

    public int NivelContenta
    {
        get { return nivelContenta; }
    }

    public void Comer()
    {
        estado.Comer(this);
    }

    public void Jugar()
    {
        estado.Jugar(this);
    }

    public bool PuedeJugar()
    {
        return estado.PuedeJugar();
    }

    internal void CambiarEstado(EstadoMascota nuevoEstado)
    {
        estado = nuevoEstado;
    }

    internal void AumentarNivel(int incremento)
    {
        nivelContenta += incremento;
    }
}
