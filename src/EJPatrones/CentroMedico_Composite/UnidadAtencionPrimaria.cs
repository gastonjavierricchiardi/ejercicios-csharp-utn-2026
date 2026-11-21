// CentroMedico
public class UnidadAtencionPrimaria : CentroAtencion
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public UnidadAtencionPrimaria(
        string nombre,
        string direccion,
        int personal,
        decimal tiempoMedio
        ) : base(nombre, direccion, personal, tiempoMedio)
    {
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override int ObtenerCantidadAmbulancias()
    {
        //throw new NotImplementedException();
        return 0;
    }
}