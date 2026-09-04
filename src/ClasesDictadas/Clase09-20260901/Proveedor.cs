using System.Runtime.InteropServices;

public class Proveedor : Persona, ICosteable
{
    public double ValorHora {get; set;}

    public int CantidadHoras { get; set; }
    public int Cuit { get; set; }
    public bool Exento { get; set; }
    public int NumeroIIBB { get; set; }

    public double CalcularCosto()
    {
        var total = CantidadHoras * ValorHora;
        if(total >= 1000000)
        {
            return 1000000;
        }
        return total;
    }

    public override string Saludar()
    {
        return $"{GetFullName()} CUIT: {Cuit} {(Exento ? "Soy" : "No Soy")} Exento NRO IIBB: {NumeroIIBB}";
    }

   
}