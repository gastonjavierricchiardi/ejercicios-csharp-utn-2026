using System;

public class Analizador
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public void Analizar(Objeto objeto)
    {
        Analizar(objeto, false);
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    private void Analizar(
        Objeto objeto,
        bool estaContenido
    )
    {
        bool tieneContenido = objeto.TieneContenido();

        TipoObjeto tipoObjeto;

        if (!estaContenido && !tieneContenido)
        {
            tipoObjeto = TipoObjeto.Simple;
        }
        else if (!estaContenido && tieneContenido)
        {
            tipoObjeto = TipoObjeto.Contenedor;
        }
        else
        {
            tipoObjeto = TipoObjeto.Sambuchito;
        }

        System.Console.WriteLine($"Material   : {objeto.Material}");
        System.Console.WriteLine($"Volumen    : {objeto.Volumen} cm3");
        System.Console.WriteLine($"Tipo Objeto: {tipoObjeto}");
        System.Console.WriteLine();

        foreach (Objeto objetoContenido in objeto.ObtenerContenido())
        {
            Analizar(objetoContenido, true);
        }
    }
}