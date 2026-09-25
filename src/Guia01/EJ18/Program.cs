// gastonj@hotmail.com
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        RepositorioInmueblesMemoria repositorio =
            new RepositorioInmueblesMemoria();

        GestorInmuebles gestor =
            new GestorInmuebles(repositorio);


        DatosCatastrales datosCasa =
            new DatosCatastrales(
                "Buenos Aires",
                "Centro",
                "San Martín",
                1250,
                "B1708"
            );

        Contacto contactoCasa =
            new Contacto(
                "María",
                "Gómez",
                "1122334455",
                ""
            );

        List<Ambiente> ambientesCasa =
            new List<Ambiente>();

        ambientesCasa.Add(
            new Ambiente(
                "Living",
                5.5,
                4.0,
                true
            )
        );

        ambientesCasa.Add(
            new Ambiente(
                "Dormitorio",
                3.5,
                3.0,
                true
            )
        );

        Casa casa =
            new Casa(
                datosCasa,
                ambientesCasa,
                contactoCasa,
                "Casa recientemente refaccionada.",
                false,
                true,
                true,
                true,
                true
            );


        DatosCatastrales datosDepartamento =
            new DatosCatastrales(
                "Córdoba",
                "Nueva Córdoba",
                "Obispo Trejo",
                650,
                "X5000"
            );

        Contacto contactoDepartamento =
            new Contacto(
                "Juan",
                "Pérez",
                "",
                "juan@email.com"
            );

        List<Ambiente> ambientesDepartamento =
            new List<Ambiente>();

        ambientesDepartamento.Add(
            new Ambiente(
                "Living comedor",
                4.5,
                3.5,
                true
            )
        );

        ambientesDepartamento.Add(
            new Ambiente(
                "Dormitorio",
                3.0,
                3.0,
                false
            )
        );

        Departamento departamento =
            new Departamento(
                datosDepartamento,
                ambientesDepartamento,
                contactoDepartamento,
                "",
                false,
                true,
                true,
                0,
                "A",
                true
            );


        bool altaCasa = gestor.DarDeAlta(casa);
        bool altaDepartamento = gestor.DarDeAlta(departamento);

        Console.WriteLine(
            "Alta de casa: "
            + (altaCasa ? "realizada" : "rechazada")
        );

        Console.WriteLine(
            "Alta de departamento: "
            + (altaDepartamento ? "realizada" : "rechazada")
        );

        Console.WriteLine();
        Console.WriteLine("=== INMUEBLES REGISTRADOS ===");
        Console.WriteLine();

        foreach (Inmueble inmueble in gestor.ObtenerInmuebles())
        {
            Console.WriteLine(inmueble.ObtenerDescripcion());
            Console.WriteLine("--------------------------------");
        }
    }
}