public class Facturador
{
    private Configuracion config;

    public Facturador()
    {
        config = Configuracion.GetInstance();
    }

    public void Facturar()
    {
        // Hace algo y lee el idioma y nombre de la App
        Console.WriteLine($"Aplicacion: {config.Nombre} - Idioma Actual: {config.Idioma}");
    }
}