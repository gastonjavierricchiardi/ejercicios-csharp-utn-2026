// Gimnasio_Strategy
public class Actividad
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private string descripcion;
    private decimal precioMensual;
    private string instructor;
    private string diasYHorarios;
    // 2. CONSTRUCTOR
    public Actividad(
        string nombre,
        string descripcion,
        decimal precioMensual,
        string instructor,
        string diasYHorarios
    )
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precioMensual = precioMensual;
        this.instructor = instructor;
        this.diasYHorarios = diasYHorarios;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public decimal PrecioMensual
    {
        get { return precioMensual; }
    }
    // 4. MÉTODOS

}