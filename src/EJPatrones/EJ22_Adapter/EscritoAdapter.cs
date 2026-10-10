// EJ21
using System;
public class EscritoAdapter : IDocument
{
    // 1. CAMPOS / ATRIBUTOS
    private Escrito escrito;
    // 2. CONSTRUCTOR
    public EscritoAdapter(Escrito escrito) { this.escrito = escrito; }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Id { get { return escrito.Legajo; } }
    public DateTime IssueDate { get { return escrito.Erogacion; } }
    public string Body { get { return escrito.Cuerpo; } }
    public string Responsible { get { return escrito.Autor; } }
    // 4. MÉTODOS
}
/*¿qué conseguimos?
el adaptador traduce los nombres
--------------------------
IDocument   ---> Escrito
--------------------------
Id          ---> Legajo
IssueDate   ---> Erogacion
Body        ---> Cuerpo
Responsible ---> Autor
*/
