// EJ26
using System;
using System.Collections.Generic;

public class Dependencia : UnidadCorreo
{
    // 1. CAMPOS / ATRIBUTOS
    private List<UnidadCorreo> unidades;

    // 2. CONSTRUCTOR
    public Dependencia(int id, string nombre) : base(id, nombre)
    {
        unidades = new List<UnidadCorreo>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS

    public void AgregarDependencia(Dependencia dependencia)
    {
        unidades.Add(dependencia);
    }

    public void IncorporarSucursal(Sucursal nuevaSucursal)
    {
        // Prioridad 1: dependencia con cuatro sucursales.
        Dependencia? destino = BuscarDependencia(4, 4);

        if (destino != null)
        {
            destino.TransformarCuartaSucursal(nuevaSucursal);
            return;
        }

        // Prioridad 2: dependencia con menos de tres.
        destino = BuscarDependencia(0, 2);

        if (destino != null)
        {
            destino.unidades.Add(nuevaSucursal);

            /*
            Prueba temporal: Mostrar donde quedó incorporada la sucursal
            */
            System.Console.WriteLine($"{nuevaSucursal.Nombre} incorporada en {destino.Nombre}");
            return;
        }

        // Prioridad 3: dependencia con tres sucursales.
        destino = BuscarDependencia(3, 3);

        if (destino != null)
        {
            destino.unidades.Add(nuevaSucursal);

            // Prueba temporal: confirmar prioridad 3.
            System.Console.WriteLine($"{nuevaSucursal.Nombre} incorporada en {destino.Nombre} (prioridad 3)");

            return;
        }

        // No existe ninguna dependencia subordinada.
        throw new InvalidOperationException("No existen dependencias para incorporar la sucursal.");
    }

    private int ContarSucursales()
    {
        int cantidad = 0;

        foreach (UnidadCorreo unidad in unidades)
        {
            if (unidad is Sucursal)
            {
                cantidad++;
            }
        }

        return cantidad;
    }

    private Dependencia? BuscarDependencia(
        int cantidadMinima,
        int cantidadMaxima
    )
    {
        foreach (UnidadCorreo unidad in unidades)
        {
            if (unidad is Dependencia dependencia)
            {
                int cantidad = dependencia.ContarSucursales();

                if (cantidad >= cantidadMinima && cantidad <= cantidadMaxima)
                {
                    return dependencia;
                }

                Dependencia? encontrada =
                    dependencia.BuscarDependencia(
                        cantidadMinima,
                        cantidadMaxima
                    );

                if (encontrada != null)
                {
                    return encontrada;
                }
            }
        }

        return null;
    }

    private void TransformarCuartaSucursal(
        Sucursal nuevaSucursal
    )
    {
        int cantidad = 0;

        for (int i = 0; i < unidades.Count; i++)
        {
            if (unidades[i] is Sucursal sucursal)
            {
                cantidad++;

                if (cantidad == 4)
                {
                    Dependencia nuevaDependencia =
                        new Dependencia(
                            sucursal.Id,
                            sucursal.Nombre
                        );

                    nuevaDependencia.unidades.Add(nuevaSucursal);

                    unidades[i] = nuevaDependencia;

                    // Prueba temporal: confirmar la transformación.
                    Console.WriteLine($"{sucursal.Nombre} transformada en dependencia. " + $"{nuevaSucursal.Nombre} incorporada bajo su supervisión (prioridad 1)");

                    return;
                }
            }
        }
    }
}