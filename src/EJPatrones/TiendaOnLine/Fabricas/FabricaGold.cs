// EJ-TiendaOnLine (Abstract Factory)
using System.Collections.Generic;

public class FabricaGold : IFabricaCombo
{
    public Headset CrearHeadset()
    {
        return new HeadsetGold();
    }

    public Webcam CrearWebcam()
    {
        return new WebcamGold();
    }

    public Kit CrearKit()
    {
        return new KitGold();
    }

    public string ObtenerVersion()
    {
        return "Gold";
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