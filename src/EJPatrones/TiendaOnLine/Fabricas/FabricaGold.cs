// EJ-TiendaOnLine (Abstract Factory)

public class FabricaGold : IFabricaCombo
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public Headset CrearHeandset()
    {
        //throw new NotImplementedException();
        return new HeadsetGold();
    }

    public Webcam CrearWebcam()
    {
        //throw new NotImplementedException();
        return new WebcamGold();
    }

    public Kit CrearKit()
    {
        //throw new NotImplementedException();
        return new KitGold();
    }

    public string ObtenerVersion()
    {
        //throw new NotImplementedException();
        return "Gold";
    }
}
