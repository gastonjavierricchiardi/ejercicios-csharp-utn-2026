// Gimnasio_Strategy
using System.Collections.Generic;

public class Socio
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private string apellido;
    private string dni;
    private string direccion;
    private string telefono;
    private string email;

    private List<Actividad> actividades;
    private ICalculoCuota modalidad;

    // 2. CONSTRUCTOR
    public Socio(
        string nombre,
        string apellido,
        string dni,
        string direccion,
        string telefono,
        string email,
        ICalculoCuota modalidad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.direccion = direccion;
        this.telefono = telefono;
        this.email = email;

        this.modalidad = modalidad;
        actividades = new List<Actividad>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void Inscribirse(Actividad actividad)
    {
        actividades.Add(actividad);
    }

    public void CambiarModalidad(ICalculoCuota modalidad)
    {
        this.modalidad = modalidad;
    }

    public decimal CalcularCuota(Promocion? promocion)
    {
        return modalidad.CalcularCuota(actividades, promocion);
    }
}