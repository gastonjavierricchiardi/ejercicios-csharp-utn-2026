// EJ-TiendaOnLine (Abstract Factory)

public class FabricaPlatinum : IFabricaCombo
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public Headset CrearHeandset()
    {
        //throw new NotImplementedException();
        return new HeadsetPlatinum();
    }

    public Kit CrearKit()
    {
        //throw new NotImplementedException();
        return new KitPlatinum();
    }

    public Webcam CrearWebcam()
    {
        //throw new NotImplementedException();
        return new WebcamPlatinum();
    }

    public string ObtenerVersion()
    {
        //throw new NotImplementedException();
        return "Platinum";
    }
}
