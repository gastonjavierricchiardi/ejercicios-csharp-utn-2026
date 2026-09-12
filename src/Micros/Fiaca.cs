// /src/Micros/Fiaca.cs

public class Fiaca : Persona
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public Fiaca() { }
    public Fiaca(Persona jefe) : base(jefe) { }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override bool AceptaSubir(Micro micro)
    {
        return micro.HayLugarSentado();
    }
}