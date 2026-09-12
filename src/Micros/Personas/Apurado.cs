// /src/Micros/Apurado.cs

public class Apurado : Persona
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public Apurado() { }
    public Apurado(Persona jefe) : base(jefe) { }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override bool AceptaSubir(Micro micro)
    {
        return true;
    }
}