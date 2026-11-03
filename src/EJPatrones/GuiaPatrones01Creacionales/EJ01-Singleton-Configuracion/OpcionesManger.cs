public class OpcionesManager
{
    private Configuracion config;

    public OpcionesManager()
    {
        config = Configuracion.GetInstance();
    }

    public void CambiarIdioma(string newLang)
    {
        config.Idioma = newLang;
    }

    public override string ToString()
    {
        return $"Opciones Actuales: Nombre: {config.Nombre} - Idioma: {config.Idioma}";
    }
}