// EJ-TiendaOnLine (Abstract Factory)
public interface IFabricaCombo
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS

    Headset CrearHeandset();
    Webcam CrearWebcam();
    Kit CrearKit();
    string ObtenerVersion();
}
