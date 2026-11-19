// EJ-TiendaOnLine (Abstract Factory)
using System.Collections.Generic;

public class FabricaStarter : IFabricaCombo
{
    public Headset CrearHeadset()
    {
        return new HeadsetStarter();
    }

    public Webcam CrearWebcam()
    {
        return new WebcamStarter();
    }

    public Kit CrearKit()
    {
        return new KitStarter();
    }

    public string ObtenerVersion()
    {
        return "Starter";
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
