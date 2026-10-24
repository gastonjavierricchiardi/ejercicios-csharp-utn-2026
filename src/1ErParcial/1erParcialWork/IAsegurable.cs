namespace MisClases;

public interface IAsegurable
{
    // 1. CAMPOS / ATRIBUTOS
    double ObtenerValorDeclarado();

    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS

    string ObtenerDescripcionCobertura();
    bool TieneSeguroContratado();
    void ContratarSeguro(
        double valorDeclarado,
        string descripcionCobertura);
}