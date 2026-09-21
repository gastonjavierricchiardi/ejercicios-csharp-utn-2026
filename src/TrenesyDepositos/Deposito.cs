// TrenesyDepositos\Deposito.cs
using System;
using System.Collections.Generic;

public class Deposito
{
    // 1. CAMPOS / ATRIBUTOS
    private List<Formacion> formaciones;
    private List<Locomotora> locomotorasSueltas;

    // 2. CONSTRUCTOR
    public Deposito(List<Formacion> formaciones, List<Locomotora> locomotorasSueltas)
    {
        this.formaciones = formaciones;
        this.locomotorasSueltas = locomotorasSueltas;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS

    public List<Vagon> VagonesMasPesados()
    {
        List<Vagon> vagonesMasPesados = new List<Vagon>();

        foreach (Formacion formacion in formaciones)
        {
            vagonesMasPesados.Add(formacion.VagonMasPesado());
        }
        return vagonesMasPesados;
    }

    public bool NecesitaConductorExperimentado()
    {
        foreach (Formacion formacion in formaciones)
        {
            if (formacion.EsCompleja())
            {
                return true;
            }
        }
        return false;
    }

    // Punto 9:
    // agrega una locomotora disponible a una formación,
    // siempre que la formación no esté en movimiento.
    public void AgregarLocomotora(Formacion formacion)
    {
        bool formacionEnDeposito = false;

        foreach (Formacion formacionDelDeposito in formaciones)
        {
            if (formacionDelDeposito == formacion)
            {
                formacionEnDeposito = true;
            }
        }

        if (!formacionEnDeposito)
        {
            return;
        }

        if (formacion.EstaEnMovimiento)
        {
            return;
        }

        double empujeFaltante = formacion.KilosEmpujeFaltantes();

        foreach (Locomotora locomotora in locomotorasSueltas)
        {
            if (locomotora.ArrastreUtil() >= empujeFaltante)
            {
                formacion.AgregarLocomotora(locomotora);
                locomotorasSueltas.Remove(locomotora);
                return;
            }
        }
        throw new Exception("No hay locomotoras disponibles.");
    }
}