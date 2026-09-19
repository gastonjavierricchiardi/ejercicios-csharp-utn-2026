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
}