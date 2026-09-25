using System;

public class Contacto
{
    // 1. CAMPOS / ATRIBUTOS

    private string nombre;
    private string apellido;
    private string telefono;
    private string correoElectronico;


    // 2. CONSTRUCTOR

    public Contacto(
        string nombre,
        string apellido,
        string telefono,
        string correoElectronico)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.telefono = telefono;
        this.correoElectronico = correoElectronico;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS

    public string Nombre
    {
        get { return nombre; }
    }

    public string Apellido
    {
        get { return apellido; }
    }

    public string Telefono
    {
        get { return telefono; }
    }

    public string CorreoElectronico
    {
        get { return correoElectronico; }
    }


    // 4. MÉTODOS
    public bool EstaCompleto()
    {
        bool tieneNombreCompleto =
            nombre != null
            && nombre != ""
            && apellido != null
            && apellido != "";

        bool tieneMedioDeContacto =
            (telefono != null && telefono != "")
            || (correoElectronico != null && correoElectronico != "");

        return tieneNombreCompleto && tieneMedioDeContacto;
    }
}