using System;
using System.Collections.Generic;

public class Departamento : Inmueble
{
    // 1. CAMPOS / ATRIBUTOS

    private int piso;
    private string numeroLetra;
    private bool admiteMascotas;


    // 2. CONSTRUCTOR

    public Departamento(
        DatosCatastrales datosCatastrales,
        List<Ambiente> ambientes,
        Contacto contacto,
        string observacion,
        bool barrioPrivado,
        bool tieneGas,
        bool tieneCloacas,
        int piso,
        string numeroLetra,
        bool admiteMascotas)
        : base(
            datosCatastrales,
            ambientes,
            contacto,
            observacion,
            barrioPrivado,
            tieneGas,
            tieneCloacas)
    {
        this.piso = piso;
        this.numeroLetra = numeroLetra;
        this.admiteMascotas = admiteMascotas;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS

    public int Piso
    {
        get { return piso; }
    }

    public string NumeroLetra
    {
        get { return numeroLetra; }
    }

    public bool AdmiteMascotas
    {
        get { return admiteMascotas; }
    }


    // 4. MÉTODOS

    public override bool EstaCompleto()
    {
        if (!base.EstaCompleto())
        {
            return false;
        }

        if (numeroLetra == null)
        {
            return false;
        }

        if (numeroLetra == "")
        {
            return false;
        }

        return true;
    }

    public override string ObtenerDescripcion()
    {
        string descripcion = "DEPARTAMENTO" + Environment.NewLine;

        descripcion += base.ObtenerDescripcion();

        descripcion += "Piso: "
            + piso
            + Environment.NewLine;

        descripcion += "Número / letra: "
            + numeroLetra
            + Environment.NewLine;

        descripcion += "Admite mascotas: "
            + (admiteMascotas ? "Sí" : "No")
            + Environment.NewLine;

        return descripcion;
    }
}