using System.Collections.Generic;

namespace MisClases;

public class TransportesDelLitoral
{
    private List<Envio> historial;
    private List<Envio> pendientes;
    private Dictionary<int, Envio> enviosPorGuia;

    public TransportesDelLitoral()
    {
        historial = new List<Envio>();
        pendientes = new List<Envio>();
        enviosPorGuia = new Dictionary<int, Envio>();
    }

    public bool RegistrarEnvio(Envio envio)
    {
        if (enviosPorGuia.ContainsKey(envio.NumeroGuia))
        {
            return false;
        }

        enviosPorGuia.Add(envio.NumeroGuia, envio);
        historial.Add(envio);
        pendientes.Add(envio);

        return true;
    }

    public Envio? BuscarPorGuia(int numeroGuia)
    {
        if (enviosPorGuia.ContainsKey(numeroGuia))
        {
            return enviosPorGuia[numeroGuia];
        }

        return null;
    }

    public void ContratarSeguro(
        Envio envio,
        double valorDeclarado,
        string descripcionCobertura)
    {
        if (envio is IAsegurable)
        {
            IAsegurable asegurable = (IAsegurable)envio;

            asegurable.ContratarSeguro(
                valorDeclarado,
                descripcionCobertura);

            return;
        }

        throw new EnvioNoAsegurableException(
            "El envío " + envio.NumeroGuia + " no admite seguro.");
    }

    public Envio? ConsultarProximo()
    {
        if (pendientes.Count == 0)
        {
            return null;
        }

        return pendientes[0];
    }

    public Envio? Despachar()
    {
        if (pendientes.Count == 0)
        {
            return null;
        }

        Envio envio = pendientes[0];

        pendientes.RemoveAt(0);

        return envio;
    }

    public List<Envio> ObtenerHistorial()
    {
        List<Envio> copiaHistorial = new List<Envio>();

        foreach (Envio envio in historial)
        {
            copiaHistorial.Add(envio);
        }

        return copiaHistorial;
    }

    public double CalcularFacturacion()
    {
        double total = 0;

        foreach (Envio envio in historial)
        {
            total += envio.CalcularCosto();
        }

        return total;
    }

    public double CalcularCostoPromedioAsegurados()
    {
        double total = 0;
        int cantidad = 0;

        foreach (Envio envio in historial)
        {
            if (envio is IAsegurable)
            {
                IAsegurable asegurable = (IAsegurable)envio;

                if (asegurable.TieneSeguroContratado())
                {
                    total += envio.CalcularCosto();
                    cantidad++;
                }
            }
        }

        if (cantidad == 0)
        {
            return 0;
        }

        return total / cantidad;
    }
}