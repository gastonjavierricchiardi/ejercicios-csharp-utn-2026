public class EstadoHambrienta : EstadoMascota
{
    public override void Comer(Mascota mascota)
    {
        mascota.CambiarEstado(new EstadoContenta());
    }

    public override void Jugar(Mascota mascota)
    {
        // No produce ningun efecto.
    }

    public override bool PuedeJugar()
    {
        return false;
    }
}
