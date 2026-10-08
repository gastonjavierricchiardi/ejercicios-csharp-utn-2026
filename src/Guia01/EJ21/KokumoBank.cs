// EJ21
using System;
public class KokumoBank
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombreSucursal;

    // 2. CONSTRUCTOR
    public KokumoBank(string nombreSucursal)
    {
        this.nombreSucursal = nombreSucursal;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string NombreSucursal
    {
        get { return nombreSucursal; }
        // set { nombreSucursal = value; }
    }

    // 4. MÉTODOS
    public Prestamo EvaluarPrestamo(
        Solicitante solicitante,
        PersonIdentity personIdentity
    )
    {
        // Consultamos al servicio externo
        Person person = personIdentity.getInfo(
            solicitante.Dni
        );

        // Calcular edad
        int edad = CalcularEdad(
            person.BirthDate
        );

        // Validar la edad mínima
        if (edad < 21)
        {
            throw new ExcepcionPrestamo(
                "No es posible otorgar el préstamo porque no reúne la edad mínima"
            );
        }

        if (solicitante.SueldoBruto < 30000)
        {
            throw new ExcepcionPrestamo(
                "El salario es demasiado bajo para otorgar un préstamo"
            );
        }

        // Salario entre 30000 y 40000
        if (solicitante.SueldoBruto <= 40000)
        {
            return new Prestamo(
                80000,
                30
            );
        }

        // Salario mayor a 40000 y hasta 60000
        if (solicitante.SueldoBruto <= 60000)
        {
            return new Prestamo(
                120000,
                35
            );
        }

        // Salario mayor a 60000 y hasta 80000
        if (solicitante.SueldoBruto <= 80000)
        {
            return new Prestamo(
                140000,
                39
            );
        }

        // Salario mayor a 80000
        throw new ExcepcionPrestamo(
            "No se otorgan préstamos a salarios mayores a 80000"
        );
    }

    /*
    Para mantener el ejercicio simple y acorde a lo trabajado,
    la edad se calcula solamente con los años.

    No se verifica si la persona ya cumplió años durante 2026.
    */
    private int CalcularEdad(
        DateTime birthDate
    )
    {
        int edad = 2026 - birthDate.Year;

        return edad;
    }
}