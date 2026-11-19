// CentroMedico
public class Hospital : CentroAtencion
{
    // 1. CAMPOS / ATRIBUTOS
    private int ambulancias;

    // 2. CONSTRUCTOR
    public Hospital(
        string nombre,
        string direccion,
        int personal,
        decimal tiempoMedio,
        int ambulancias
        ) : base(nombre, direccion, personal, tiempoMedio)
    {
        this.ambulancias = ambulancias;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override int ObtenerCantidadAmbulancias()
    {
        //throw new NotImplementedException();
        return ambulancias;
    }

    public void ModificarAmbulancias(int cantidad)
    {
        ambulancias = cantidad;
    }
}