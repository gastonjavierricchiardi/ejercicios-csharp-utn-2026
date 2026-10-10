// EJ22
using System;
public class DocumentoAdapter : IDocument
{
    // 1. CAMPOS / ATRIBUTOS
    private Documento documento;
    // 2. CONSTRUCTOR
    public DocumentoAdapter(Documento documento) { this.documento = documento; }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Id { get { return documento.Expediente; } }
    public DateTime IssueDate { get { return documento.Lanzamiento; } }
    public string Body { get { return documento.Contenido; } }
    public string Responsible { get { return documento.Nombre; } }
    // 4. MÉTODOS
}
/*¿qué conseguimos?
el adaptador traduce los nombres
---------------------------
IDocument   ---> Escrito
---------------------------
Id          ---> Expediente
IssueDate   ---> Lanzamiento
Body        ---> Contenido
Responsible ---> Nombre
*/

