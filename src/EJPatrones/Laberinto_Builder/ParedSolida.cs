using System;

public class ParedSolida : Pared
{
    // 1. CAMPOS / ATRIBUTOS
    private MaterialPared material;
    private bool tienePuerta;

    // 2. CONSTRUCTOR
    public ParedSolida(MaterialPared material, bool tienePuerta)
    {
        if (material == MaterialPared.Agua)
        {
            throw new ArgumentException(
                "El agua debe representarse mediante ParedAgua.");
        }

        this.material = material;
        this.tienePuerta = tienePuerta;
    }

    // 3. PROPIEDADES
    public MaterialPared Material
    {
        get { return material; }
    }

    public bool TienePuerta
    {
        get { return tienePuerta; }
    }

    // 4. MÉTODOS
    public override bool EsAtravesable()
    {
        return tienePuerta;
    }
}