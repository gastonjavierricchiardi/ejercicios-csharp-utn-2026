using System.Collections.Generic;

public class Casa : Inmueble
{
    // 1. CAMPOS / ATRIBUTOS

    private bool tieneQuincho;
    private bool tienePileta;


    // 2. CONSTRUCTOR

    public Casa(
        DatosCatastrales datosCatastrales,
        List<Ambiente> ambientes,
        Contacto contacto,
        string observacion,
        bool barrioPrivado,
        bool tieneGas,
        bool tieneCloacas,
        bool tieneQuincho,
        bool tienePileta)
        : base(
            datosCatastrales,
            ambientes,
            contacto,
            observacion,
            barrioPrivado,
            tieneGas,
            tieneCloacas)
    {
        this.tieneQuincho = tieneQuincho;
        this.tienePileta = tienePileta;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS

    public bool TieneQuincho
    {
        get { return tieneQuincho; }
    }

    public bool TienePileta
    {
        get { return tienePileta; }
    }


    // 4. MÉTODOS

    public override string ObtenerDescripcion()
    {
        string descripcion = "CASA\n";

        descripcion += base.ObtenerDescripcion();

        descripcion += "Quincho: ";

        if (tieneQuincho)
        {
            descripcion += "Sí\n";
        }
        else
        {
            descripcion += "No\n";
        }

        descripcion += "Pileta: ";

        if (tienePileta)
        {
            descripcion += "Sí\n";
        }
        else
        {
            descripcion += "No\n";
        }

        return descripcion;
    }
}