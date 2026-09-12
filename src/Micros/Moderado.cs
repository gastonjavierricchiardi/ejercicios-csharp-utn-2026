// /src/Micros/Moderado.cs

public class Moderado : Persona
{
    // 1. CAMPOS / ATRIBUTOS
    private int lugaresMinimosLibres;

    // 2. CONSTRUCTOR
    public Moderado(int lugaresMinimosLibres)
    {
        this.lugaresMinimosLibres = lugaresMinimosLibres;
    }
    // Constructor para que nazca con un jefe
    public Moderado(int lugaresMinimosLibres, Persona jefe) : base(jefe)
    {
        this.lugaresMinimosLibres = lugaresMinimosLibres;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override bool AceptaSubir(Micro micro)
    {
        return micro.LugaresLibres() >= lugaresMinimosLibres;
    }
}