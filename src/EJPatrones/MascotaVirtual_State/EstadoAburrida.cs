using System;

public class EstadoAburrida : EstadoMascota
{
    private DateTime inicioAburrimiento;

    public EstadoAburrida(DateTime inicioAburrimiento)
    {
        this.inicioAburrimiento = inicioAburrimiento;
    }

    public override void Comer(Mascota mascota)
    {
        TimeSpan tiempoAburrida = DateTime.Now - inicioAburrimiento;

        if (tiempoAburrida > TimeSpan.FromMinutes(80))
        {
            mascota.CambiarEstado(new EstadoContenta());
        }
    }

    public override void Jugar(Mascota mascota)
    {
        mascota.CambiarEstado(new EstadoContenta());
    }

    public override bool PuedeJugar()
    {
        return true;
    }
}
