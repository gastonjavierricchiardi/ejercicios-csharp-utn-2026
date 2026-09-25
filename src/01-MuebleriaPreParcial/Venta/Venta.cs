using System.Collections.Generic;
public class Venta
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public double RealizarVenta(List<ItemVenta> items)
    {
        Cronometro.Iniciar();
        double total = 0;

        foreach (ItemVenta item in items)
        {
            total += item.CalcularSubtotal();
        }

        double minutos = Cronometro.Detener();

        if (minutos > 180)
        {
            total += 100000;
        }
        else if (minutos > 60)
        {
            total += 10000;
        }
        return total;
    }
}