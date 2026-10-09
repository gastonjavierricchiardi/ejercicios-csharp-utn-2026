// EJ22
public class NormalizadorDocumentos
{
    // 1. CAMPOS / ATRIBUTOS                -> no almacenamos atributos
    // 2. CONSTRUCTOR                       -> no requiere un constructor explícito
    // 3. PROPIEDADES / GETTERS Y SETTERS   -> no necesita
    // 4. MÉTODOS

    // Normalizar un escrito
    public Document Normalizar(Escrito escrito)
    {
        return new Document(
            escrito.Legajo,
            escrito.Erogacion,
            escrito.Cuerpo,
            escrito.Autor
        );
    }

    // Normalizador documento
    public Document Normalizar(Documento documento)
    {
        return new Document(
            documento.Expediente,
            documento.Lanzamiento,
            documento.Contenido,
            documento.Nombre
        );
    }

    // Normalizador ley
    public Document Normalizar(Ley ley)
    {
        return new Document(
            ley.Folio,
            ley.Emision,
            ley.Desarrollo,
            ley.Firmante
        );
    }
}
