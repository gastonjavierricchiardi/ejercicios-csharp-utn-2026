// EJ-TiendaOnLine (Abstract Factory)
using System.Collections.Generic;

public class FabricaPlatinum : IFabricaCombo
{
    public Headset CrearHeadset()
    {
        return new HeadsetPlatinum();
    }

    public Webcam CrearWebcam()
    {
        return new WebcamPlatinum();
    }

    public Kit CrearKit()
    {
        return new KitPlatinum();
    }

    public string ObtenerVersion()
    {
        return "Platinum";
    }

    public List<Producto> ObtenerProductos()
    {
        List<Producto> productos = new List<Producto>();

        productos.Add(CrearHeadset());
        productos.Add(CrearWebcam());
        productos.Add(CrearKit());

        return productos;
    }
}