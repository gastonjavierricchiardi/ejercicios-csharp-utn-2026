// EJ21 --> gastonj@hotmail.com
using System;

public class Program
{
    public static void Main()
    {
        // Crear banco
        KokumoBank kokumoBank = new KokumoBank(
            "Caballito"
        );

        Console.WriteLine("=== KOKUMO BANK - SUCURSAL " + kokumoBank.NombreSucursal + " ===");

        Console.WriteLine();

        // CASO 1 --> Salario entre 30.000 y 40.000        
        Person person1 = new Person(
            "Juan",
            "Perez",
            new DateTime(1990, 5, 15)
        );

        PersonIdentity personIdentity1 = new PersonIdentity(
            person1,
            true
        );

        Solicitante solicitante1 = new Solicitante(
            "26.407.003",
            35000,
            5
        );

        try
        {
            Prestamo prestamo1 = kokumoBank.EvaluarPrestamo(solicitante1, personIdentity1);

            Console.WriteLine("DNI      : " + solicitante1.Dni);
            Console.WriteLine("Préstamo : $" + prestamo1.Monto);
            Console.WriteLine("Interés  : " + prestamo1.Interes + "%");
        }
        catch (ExcepcionPrestamo ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine();

        // CASO 2 --> Salario mayor a 40.000 y hasta 60.000

        Person person2 = new Person(
            "Maria",
            "Gomez",
            new DateTime(1988, 8, 20)
        );

        PersonIdentity personIdentity2 = new PersonIdentity(
            person2,
            true
        );

        Solicitante solicitante2 = new Solicitante(
            "30.123.456",
            50000,
            3
        );

        try
        {
            Prestamo prestamo2 =
                kokumoBank.EvaluarPrestamo(
                    solicitante2,
                    personIdentity2
                );

            Console.WriteLine("DNI      : " + solicitante2.Dni);
            Console.WriteLine("Préstamo : $" + prestamo2.Monto);
            Console.WriteLine("Interés  : " + prestamo2.Interes + "%");
        }
        catch (ExcepcionPrestamo ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine();

        // CASO 3 --> Salario mayor a 60.000 y hasta 80.000

        Person person3 = new Person(
            "Pedro",
            "Lopez",
            new DateTime(1995, 3, 10)
        );

        PersonIdentity personIdentity3 = new PersonIdentity(
            person3,
            true
        );

        Solicitante solicitante3 = new Solicitante(
            "35.456.789",
            70000,
            2
        );

        try
        {
            Prestamo prestamo3 =
                kokumoBank.EvaluarPrestamo(
                    solicitante3,
                    personIdentity3
                );

            Console.WriteLine("DNI      : " + solicitante3.Dni);
            Console.WriteLine("Préstamo : $" + prestamo3.Monto);
            Console.WriteLine("Interés  : " + prestamo3.Interes + "%");
        }
        catch (ExcepcionPrestamo ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine();

        // CASO 4 --> Salario menor a 30.000

        Person person4 = new Person(
            "Laura",
            "Martinez",
            new DateTime(1998, 11, 2)
        );

        PersonIdentity personIdentity4 = new PersonIdentity(
            person4,
            true
        );

        Solicitante solicitante4 = new Solicitante(
            "40.123.456",
            25000,
            1
        );

        try
        {
            Prestamo prestamo4 =
                kokumoBank.EvaluarPrestamo(
                    solicitante4,
                    personIdentity4
                );

            Console.WriteLine("Préstamo : $" + prestamo4.Monto);
            Console.WriteLine("Interés  : " + prestamo4.Interes + "%");
        }
        catch (ExcepcionPrestamo ex)
        {
            Console.WriteLine("DNI   : " + solicitante4.Dni);
            Console.WriteLine("Error : " + ex.Message);
        }

        Console.WriteLine();

        // CASO 5 --> Salario mayor a 80.000

        Person person5 = new Person(
            "Carlos",
            "Fernandez",
            new DateTime(1992, 6, 25)
        );

        PersonIdentity personIdentity5 = new PersonIdentity(
            person5,
            true
        );

        Solicitante solicitante5 = new Solicitante(
            "45.789.123",
            90000,
            4
        );

        try
        {
            Prestamo prestamo5 =
                kokumoBank.EvaluarPrestamo(
                    solicitante5,
                    personIdentity5
                );

            Console.WriteLine("Préstamo : $" + prestamo5.Monto);
            Console.WriteLine("Interés  : " + prestamo5.Interes + "%");
        }
        catch (ExcepcionPrestamo ex)
        {
            Console.WriteLine("DNI   : " + solicitante5.Dni);
            Console.WriteLine("Error : " + ex.Message);
        }

        Console.WriteLine();

        // CASO 6 --> Datos de identidad incorrectos

        Person person6 = new Person(
            "Ana",
            "Suarez",
            new DateTime(1990, 1, 10)
        );

        PersonIdentity personIdentity6 = new PersonIdentity(
            person6,
            false
        );

        Solicitante solicitante6 = new Solicitante(
            "50.111.222",
            50000,
            6
        );

        try
        {
            Prestamo prestamo6 =
                kokumoBank.EvaluarPrestamo(
                    solicitante6,
                    personIdentity6
                );

            Console.WriteLine("Préstamo : $" + prestamo6.Monto);
            Console.WriteLine("Interés  : " + prestamo6.Interes + "%");
        }
        catch (Exception ex)
        {
            Console.WriteLine("DNI   : " + solicitante6.Dni);
            Console.WriteLine("Error : " + ex.Message);
        }
        Console.WriteLine();

        // CASO 7 --> Persona menor de 21 años

        Person person7 = new Person(
            "Sofia",
            "Ramirez",
            new DateTime(2010, 4, 12)
        );

        PersonIdentity personIdentity7 = new PersonIdentity(
            person7,
            true
        );

        Solicitante solicitante7 = new Solicitante(
            "50.222.333",
            50000,
            1
        );

        try
        {
            Prestamo prestamo7 =
                kokumoBank.EvaluarPrestamo(
                    solicitante7,
                    personIdentity7
                );

            Console.WriteLine("Préstamo : $" + prestamo7.Monto);
            Console.WriteLine("Interés  : " + prestamo7.Interes + "%"
            );
        }
        catch (ExcepcionPrestamo ex)
        {
            Console.WriteLine("DNI   : " + solicitante7.Dni);
            Console.WriteLine("Error : " + ex.Message);
        }
    }
}