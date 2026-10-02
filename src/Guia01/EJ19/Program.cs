// EJ19
using System;
public class Program
{
    public static void Main() //static void Main(string[] args){}
    {

        // CREAR EMPRESA
        Empresa empresa = new Empresa();

        // CREAR ARTÍCULOS
        Articulo silla = new Articulo(
            "Silla",
            20000
        );

        Articulo mesa = new Articulo(
            "Mesa",
            45000,
            "Mesa de madera"
        );

        Articulo biblioteca = new Articulo(
            "Biblioteca",
            60000,
            "Cinco estantes"
        );

        // DAR DE ALTA LOS ARTÍCULOS
        empresa.DarDeAlta(silla);
        empresa.DarDeAlta(mesa);
        empresa.DarDeAlta(biblioteca);

        // CREAR LISTA MAYORISTA
        ListaPrecio listaMayorista = new ListaPrecio(
            "Lista Mayorista",
            "31/12/2026",
            TipoListaPrecio.MAYORISTA
        );

        listaMayorista.AgregarArticulo(
            silla,
            30000
        );

        listaMayorista.AgregarArticulo(
            mesa,
            65000
        );

        listaMayorista.AgregarArticulo(
            biblioteca,
            85000
        );

        // CREAR LISTA MINORISTA
        ListaPrecio listaMinorista = new ListaPrecio(
            "Lista Minorista",
            "31/12/2026",
            TipoListaPrecio.MINORISTA
        );

        listaMinorista.AgregarArticulo(
            silla,
            35000
        );

        listaMinorista.AgregarArticulo(
            mesa,
            75000
        );

        listaMinorista.AgregarArticulo(
            biblioteca,
            95000
        );


        // AGREGAR LAS LISTAS A LA EMPRESA
        empresa.AgregarListaPrecio(listaMayorista);
        empresa.AgregarListaPrecio(listaMinorista);


        // MOSTRAR ARTÍCULOS
        Console.WriteLine("=== ARTÍCULOS ===");

        foreach (Articulo articulo in empresa.Articulos)
        {
            Console.WriteLine("Nombre               : " + articulo.Nombre);
            Console.WriteLine("Costo de producción  : " + articulo.CostoProduccion);

            if (articulo.Observacion != "")
            {
                Console.WriteLine("Observación          : " + articulo.Observacion);
            }

            Console.WriteLine();
        }


        // MOSTRAR LISTAS DE PRECIO

        Console.WriteLine("=== LISTAS DE PRECIO ===");

        foreach (ListaPrecio lista in empresa.ListasDePrecio)
        {
            Console.WriteLine("Nombre         : " + lista.Nombre);
            Console.WriteLine("Vigencia       : " + lista.FechaTopeVigencia);
            Console.WriteLine("Tipo           : " + lista.Tipo);

            Console.WriteLine("Detalle        :");

            foreach (DetalleListaPrecio detalle in lista.Detalles)
            {
                Console.WriteLine("Artículo       : " + detalle.Articulo.Nombre);
                Console.WriteLine("Precio de venta: " + detalle.PrecioVenta);

                if (detalle.Articulo.Observacion != "")
                {
                    Console.WriteLine(
                        "Observación    : " + detalle.Articulo.Observacion
                    );
                }
            }
            Console.WriteLine();
        }
    }
}