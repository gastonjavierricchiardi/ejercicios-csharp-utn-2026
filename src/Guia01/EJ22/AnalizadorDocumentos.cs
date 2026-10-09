// EJ22
using System;
using System.Collections.Generic;
public class AnalizadorDocumentos
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void Analizar(List<Document> documentos)
    {
        foreach (Document documento in documentos)
        {
            // Verificamos el identificador
            bool idValido = documento.Id > 0;

            // Verificamos la fecha
            bool fechaValida =
                documento.IssueDate != DateTime.MinValue &&
                documento.IssueDate.Date <= DateTime.Today;

            // Verificar cuerpo
            bool cuerpoValido =
                documento.Body != null &&
                documento.Body.Trim().Length > 0 &&
                documento.Body.Length >= 100;

            // Verificar responsable
            bool responsableValido =
                documento.Responsible != null &&
                documento.Responsible.Trim().Length > 0;

            // Resultado
            if (idValido && fechaValida && cuerpoValido && responsableValido)
            {
                System.Console.WriteLine("aprobado");
            }
            else
            {
                System.Console.WriteLine("rechazado");
            }
        }
    }
}
