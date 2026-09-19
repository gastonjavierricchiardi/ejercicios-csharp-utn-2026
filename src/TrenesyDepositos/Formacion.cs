// TrenesyDepositos\Formacion.cs
using System.Collections.Generic;
public class Formacion
{
    // 1. CAMPOS / ATRIBUTOS
    private List<Locomotora> locomotoras;
    private List<Vagon> vagones;
    private bool estaEnMovimiento;

    /*
    2. CONSTRUCTOR
    el enunciado dice: "una formación, tiene una o más locomotoras y uno o mas
    Vagones, por lo que conceptualmente no debería nacer vacía.
    */
    public Formacion(
        List<Locomotora> locomotoras,
        List<Vagon> vagones
    )
    {
        this.locomotoras = locomotoras;
        this.vagones = vagones;
        this.estaEnMovimiento = false;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public double TotalPasajeros()
    {
        double totalPasajeros = 0;
        foreach (Vagon vagon in vagones)
        {
            totalPasajeros += vagon.CantidadPasajeros();
        }
        return totalPasajeros;
    }

    public int CantidadVagonesLivianos()
    {
        int cantidadVagonesLivianos = 0;

        foreach (Vagon vagon in vagones)
        {
            if (vagon.PesoMaximo() < 2500)
            {
                cantidadVagonesLivianos++;
            }
        }
        return cantidadVagonesLivianos;
    }

    public double VelocidadMaxima()
    {
        double velocidadMaxima = locomotoras[0].VelocidadMaxima;
        foreach (Locomotora locomotora in locomotoras)
        {
            if (locomotora.VelocidadMaxima < velocidadMaxima)
            {
                velocidadMaxima = locomotora.VelocidadMaxima;
            }
        }
        return velocidadMaxima;
    }

    public bool EsEficiente()
    {
        foreach (Locomotora locomotora in locomotoras)
        {
            if (!locomotora.EsEficiente())
            {
                return false;
            }
        }
        return true;
    }

    public bool PuedeMoverse()
    {
        double arrastreUtilTotal = 0;

        foreach (Locomotora locomotora in locomotoras)
        {
            arrastreUtilTotal += locomotora.ArrastreUtil();
        }
        double pesoMaximoVagones = 0;

        foreach (Vagon vagon in vagones)
        {
            pesoMaximoVagones += vagon.PesoMaximo();
        }
        return arrastreUtilTotal >= pesoMaximoVagones;
    }
    public double KilosEmpujeFaltantes()
    {
        double arrastreUtilTotal = 0;

        foreach (Locomotora locomotora in locomotoras)
        {
            arrastreUtilTotal += locomotora.ArrastreUtil();
        }
        double pesoMaximoVagones = 0;
        foreach (Vagon vagon in vagones)
        {
            pesoMaximoVagones += vagon.PesoMaximo();
        }
        if (arrastreUtilTotal >= pesoMaximoVagones)
        {
            return 0;
        }
        return pesoMaximoVagones - arrastreUtilTotal;
    }

    // Vemos si una formación es compleja

    public bool EsCompleja()
    {
        int cantidadUnidades = 0;
        double pesoTotal = 0;

        foreach (Locomotora locomotora in locomotoras)
        {
            cantidadUnidades++;
            pesoTotal += locomotora.Peso;
        }

        foreach (Vagon vagon in vagones)
        {
            cantidadUnidades++;
            pesoTotal += vagon.PesoMaximo();
        }
        return cantidadUnidades > 20 || pesoTotal > 10000;


    }




}