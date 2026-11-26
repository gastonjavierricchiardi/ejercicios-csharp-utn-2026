public class EstadoContenta : EstadoMascota
{
    public override void Comer(Mascota mascota)
    {
        mascota.AumentarNivel(1);
    }

    public override void Jugar(Mascota mascota)
    {
        mascota.AumentarNivel(2);
    }

    public override bool PuedeJugar()
    {
        return true;
    }
}
