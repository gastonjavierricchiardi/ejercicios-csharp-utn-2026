// EJ04-FACADE
using System;
public class HomeTheaterFacade : IHomeTheater
{
    // 1. CAMPOS / ATRIBUTOS
    private Lights lights;
    private Projector projector;
    private SoundSystem soundSystem;
    // 2. CONSTRUCTOR
    public HomeTheaterFacade(
        Lights lights,
        Projector projector,
        SoundSystem soundSystem
    )
    {
        this.lights = lights;
        this.projector = projector;
        this.soundSystem = soundSystem;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS, no son necesarios para este ejercicio

    // 4. MÉTODOS
    public void WatchMovie()
    {
        //throw new NotImplementedException();
        lights.SetIntensity(10);

        projector.TurnOn();
        projector.SetInput("HDMI");

        soundSystem.TurnOn();
        soundSystem.SetVolume(15);

        System.Console.WriteLine("--> Disfruta de la película <--");
    }

    public void EndMovie()
    {
        //throw new NotImplementedException();
        soundSystem.TurnOff();
        projector.TurnOff();

        lights.SetIntensity(100);
    }
}