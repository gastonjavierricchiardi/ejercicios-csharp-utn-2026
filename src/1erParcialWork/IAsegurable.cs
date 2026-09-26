namespace MisClases;

public interface IAsegurable
{
    double ObtenerValorDeclarado();

    string ObtenerDescripcionCobertura();

    bool TieneSeguroContratado();

    void ContratarSeguro(
        double valorDeclarado,
        string descripcionCobertura);
}