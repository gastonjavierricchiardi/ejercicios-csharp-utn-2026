// /src/Micros/Claustrofobico.cs

public class Claustrofobico : Persona
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public Claustrofobico() { }
    public Claustrofobico(Persona jefe) : base(jefe) { }
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override bool AceptaSubir(Micro micro)
    {
        return micro.GetVolumenM3() > 120;
    }
}