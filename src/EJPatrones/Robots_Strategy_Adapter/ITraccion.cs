public interface ITraccion
{
    int ConsumoHp { get; }
    int AutonomiaKm { get; }
    int DeterioroPorcentaje { get; }

    void Deteriorar();
    bool RequiereReemplazo();
}
