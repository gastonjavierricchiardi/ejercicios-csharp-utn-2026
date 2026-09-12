// /src/Micros/Obsecuente.cs

public class Obsecuente : Persona
{
    // 1. CAMPOS / ATRIBUTOS

    // 2. CONSTRUCTOR
    public Obsecuente(Persona jefe) : base(jefe) { }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override bool AceptaSubir(Micro micro)
    {
        Persona? jefe = GetJefe();
        if (jefe != null)
        {
            return jefe.AceptaSubir(micro);
        }
        throw new Exception("El obsecuente debe tener un jefe");
    }
}