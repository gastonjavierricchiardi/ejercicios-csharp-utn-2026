// EJ-TiendaOnLine (Abstract Factory)

public class FabricaStarter : IFabricaCombo
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public Headset CrearHeandset()
    {
        //throw new NotImplementedException();
        return new HeadsetStarted();
    }

    public Kit CrearKit()
    {
        //throw new NotImplementedException();
        return new KitStarter();
    }

    public Webcam CrearWebcam()
    {
        //throw new NotImplementedException();
        return new WebcamStarter();
    }

    public string ObtenerVersion()
    {
        //throw new NotImplementedException();
        return "Starter";
    }
}