// /src/Micros/Persona.cs
using System.Collections.Generic;
public abstract class Persona
{
    // 1. CAMPOS / ATRIBUTOS
    private Persona? jefe;
    private List<Persona> subordinados;

    // 2. CONSTRUCTOR
    protected Persona()
    {
        subordinados = new List<Persona>();
    }
    protected Persona(Persona jefe)
    {
        subordinados = new List<Persona>();
        this.jefe = jefe;
        jefe.AgregarSubordinado(this);
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS


    public Persona? GetJefe()
    {
        return jefe;
    }

    // 4. MÉTODOS
    public bool EsJefe()
    {
        return subordinados.Count > 0;
    }

    private void AgregarSubordinado(Persona subordinado)
    {
        subordinados.Add(subordinado);
    }
    public abstract bool AceptaSubir(Micro micro);
}