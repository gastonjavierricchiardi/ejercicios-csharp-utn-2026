// EJ22 gastonj@hotmail.com
using System;
using System.Collections.Generic;
public class Program
{
    public static void Main() //static void Main(string[] args){}
    {
        // Texto con mas de 100 caracteres
        string textoLargo =
        "Este es un documento de prueba cuyo contenido " +
        "supera los cien caracteres requeridos por la " +
        "consigna, para que pueda ser analizado y aprobado " +
        "por el sistema.";

        // Prueba de límite: exactamente 100 caracteres
        string texto100 =
            "1234567890" +
            "1234567890" +
            "1234567890" +
            "1234567890" +
            "1234567890" +
            "1234567890" +
            "1234567890" +
            "1234567890" +
            "1234567890" +
            "1234567890";

        // Creamos documentos originales
        Escrito escrito = new Escrito(
            101, // 0, (otra prueba)
            DateTime.Today,
            texto100, //textoLargo, (probamos con otro)
            "Ana" // "" (prueba)
        );

        Documento documento = new Documento(
            202,
            DateTime.Today,
            "Texto corto",
            "Luis"
        );

        Ley ley = new Ley(
            303,
            new DateTime(2099, 1, 1),
            textoLargo,
            "Marta"
        );

        // NORMALIZAMOS DOCUMENTOS
        NormalizadorDocumentos normalizador = new NormalizadorDocumentos();

        List<Document> documentos = new List<Document>();

        documentos.Add(normalizador.Normalizar(escrito));
        documentos.Add(normalizador.Normalizar(documento));
        documentos.Add(normalizador.Normalizar(ley));

        // Analizar Docuemtos
        AnalizadorDocumentos analizador = new AnalizadorDocumentos();

        analizador.Analizar(documentos);
    }
}