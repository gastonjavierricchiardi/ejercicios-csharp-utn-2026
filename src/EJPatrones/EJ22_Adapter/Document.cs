// EJ22
using System;
public class Document
{
    // 1. CAMPOS / ATRIBUTOS
    private int id;
    private DateTime issueDate;
    private string body;
    private string responsible;

    // 2. CONSTRUCTOR
    public Document(
        int id,
        DateTime issueDate,
        string body,
        string responsible
    )
    {
        this.id = id;
        this.issueDate = issueDate;
        this.body = body;
        this.responsible = responsible;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Responsible
    {
        get { return responsible; }
        //set { responsible = value; }
    }

    public string Body
    {
        get { return body; }
        // set { body = value; }
    }
    public DateTime IssueDate
    {
        get { return issueDate; }
        // set { issueDate = value; }
    }
    public int Id
    {
        get { return id; }
        //    set { id = value; }
    }

    // 4. MÉTODOS
}
