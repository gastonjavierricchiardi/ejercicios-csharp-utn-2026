// CentroMedico
public abstract class CentroAtencion : BaseSanitaria
{
    // 1. CAMPOS / ATRIBUTOS
    private int personal;
    private decimal tiempoMedio;

    // 2. CONSTRUCTOR
    protected CentroAtencion(
        string nombre,      // Heredado
        string direccion,   // Heredado
        int personal,       // propio
        decimal tiempoMedio     // propio
        ) : base(nombre, direccion)
    {
        this.personal = personal;
        this.tiempoMedio = tiempoMedio;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override int ObtenerPersonal()
    {
        //throw new NotImplementedException();
        return personal;
    }

    public override decimal ObtenerTiempoMedio()
    {
        //throw new NotImplementedException();
        return tiempoMedio;
    }

    public void ModificarTiempoMedio(decimal tiempoMedio)
    {
        this.tiempoMedio = tiempoMedio;
    }
}