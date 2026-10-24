public class Configuracion
{
    private static Configuracion instancia;

    public string Idioma { get; set; }
    public string Nombre { get; set; }

    private Configuracion()
    {
        Idioma = "es";
    }

    public static Configuracion GetInstance()
    {
        if(instancia == null)
        {
            instancia = new Configuracion();
        }

        return instancia;
    }
}