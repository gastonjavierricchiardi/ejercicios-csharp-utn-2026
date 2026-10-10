// EJ22
using System;
public class LeyAdapter : IDocument
{
    // 1. CAMPOS / ATRIBUTOS
    private Ley ley;
    // 2. CONSTRUCTOR
    public LeyAdapter(Ley ley) { this.ley = ley; }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Id { get { return ley.Folio; } }
    public DateTime IssueDate { get { return ley.Emision; } }
    public string Body { get { return ley.Desarrollo; } }
    public string Responsible { get { return ley.Firmante; } }
    // 4. MÉTODOS
}
/*¿qué conseguimos?
el adaptador traduce los nombres
---------------------------
IDocument   ---> Ley
---------------------------
Id          ---> Folio
IssueDate   ---> Emision
Body        ---> Desarrollo
Responsible ---> Firmante
*/
