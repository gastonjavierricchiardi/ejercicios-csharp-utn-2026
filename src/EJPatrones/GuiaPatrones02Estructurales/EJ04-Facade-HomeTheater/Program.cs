// EJ04-FACADE

public class Program
{
    public static void Main() // static void Main(string[] args) { }
    {
        Lights lights = new Lights();
        Projector projector = new Projector();
        SoundSystem soundSystem = new SoundSystem();

        IHomeTheater homeTheater = new HomeTheaterFacade(
            lights,
            projector,
            soundSystem
        );

        // Lanzamos el combo
        homeTheater.WatchMovie();

        homeTheater.EndMovie();
    }
}