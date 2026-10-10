// EJ22 --> refactorizado --> Adapter
using System;
public interface IDocument
{
    int Id { get; }
    DateTime IssueDate { get; }
    string Body { get; }
    string Responsible { get; }
}
/*
Importante: { get; } dentro de una interfaz no es *syntactic sugar* de una propiedad implementada. Es la declaración
de un contrato.  Las clases que implementan IDocument deberán proporcionar estas propiedades.
*/