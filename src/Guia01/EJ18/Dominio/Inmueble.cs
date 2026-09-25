using System;
using System.Collections.Generic;

public abstract class Inmueble
{
    // 1. CAMPOS / ATRIBUTOS

    private DatosCatastrales datosCatastrales;
    private List<Ambiente> ambientes;
    private Contacto contacto;
    private string observacion;
    private bool barrioPrivado;
    private bool tieneGas;
    private bool tieneCloacas;


    // 2. CONSTRUCTOR

    protected Inmueble(
        DatosCatastrales datosCatastrales,
        List<Ambiente> ambientes,
        Contacto contacto,
        string observacion,
        bool barrioPrivado,
        bool tieneGas,
        bool tieneCloacas)
    {
        this.datosCatastrales = datosCatastrales;
        this.ambientes = ambientes;
        this.contacto = contacto;
        this.observacion = observacion;
        this.barrioPrivado = barrioPrivado;
        this.tieneGas = tieneGas;
        this.tieneCloacas = tieneCloacas;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS

    public DatosCatastrales DatosCatastrales
    {
        get { return datosCatastrales; }
    }

    public List<Ambiente> Ambientes
    {
        get { return ambientes; }
    }

    public Contacto Contacto
    {
        get { return contacto; }
    }

    public string Observacion
    {
        get { return observacion; }
    }

    public bool BarrioPrivado
    {
        get { return barrioPrivado; }
    }

    public bool TieneGas
    {
        get { return tieneGas; }
    }

    public bool TieneCloacas
    {
        get { return tieneCloacas; }
    }


    // 4. MÉTODOS

    public virtual bool EstaCompleto()
    {
        if (!datosCatastrales.EstaCompleto())
        {
            return false;
        }

        if (!contacto.EstaCompleto())
        {
            return false;
        }

        if (ambientes.Count == 0)
        {
            return false;
        }

        foreach (Ambiente ambiente in ambientes)
        {
            if (!ambiente.EstaCompleto())
            {
                return false;
            }
        }

        return true;
    }

    public virtual string ObtenerDescripcion()
    {
        string descripcion = "";

        descripcion += "Provincia: " + datosCatastrales.Provincia + Environment.NewLine;
        descripcion += "Barrio: " + datosCatastrales.Barrio + Environment.NewLine;
        descripcion += "Dirección: "
            + datosCatastrales.Calle
            + " "
            + datosCatastrales.Altura
            + Environment.NewLine;

        descripcion += "Código postal: "
            + datosCatastrales.CodigoPostal
            + Environment.NewLine;

        descripcion += "Barrio privado: "
            + (barrioPrivado ? "Sí" : "No")
            + Environment.NewLine;

        descripcion += "Gas: "
            + (tieneGas ? "Sí" : "No")
            + Environment.NewLine;

        descripcion += "Cloacas: "
            + (tieneCloacas ? "Sí" : "No")
            + Environment.NewLine;

        descripcion += "Contacto: "
            + contacto.Nombre
            + " "
            + contacto.Apellido
            + Environment.NewLine;

        descripcion += "Teléfono: "
            + contacto.Telefono
            + Environment.NewLine;

        descripcion += "Correo electrónico: "
            + contacto.CorreoElectronico
            + Environment.NewLine;

        descripcion += "Ambientes: "
            + ambientes.Count
            + Environment.NewLine;

        int numeroAmbiente = 1;

        foreach (Ambiente ambiente in ambientes)
        {
            descripcion += "  Ambiente "
                + numeroAmbiente
                + ": "
                + ambiente.Tipo
                + " - "
                + ambiente.Ancho
                + " x "
                + ambiente.Largo
                + " - Luminoso: "
                + (ambiente.Luminoso ? "Sí" : "No")
                + Environment.NewLine;

            numeroAmbiente++;
        }

        if (observacion != null && observacion != "")
        {
            descripcion += "Observación: "
                + observacion
                + Environment.NewLine;
        }
        return descripcion;
    }
}