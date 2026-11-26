using System;
using System.Collections.Generic;

public class Hotel
{
    private string nombre;
    private List<Habitacion> habitaciones;
    private List<Reserva> reservas;
    private ITemporada temporadaActual;
    private int siguienteNumeroReserva;

    public Hotel(string nombre)
    {
        this.nombre = nombre;

        habitaciones = new List<Habitacion>();
        reservas = new List<Reserva>();

        temporadaActual = new TemporadaAlta();
        siguienteNumeroReserva = 1;
    }

    public string Nombre
    {
        get { return nombre; }
    }

    public string TemporadaActual
    {
        get { return temporadaActual.Nombre; }
    }

    public void AgregarHabitacion(Habitacion habitacion)
    {
        if (habitacion == null)
        {
            throw new ArgumentNullException(nameof(habitacion));
        }

        foreach (Habitacion existente in habitaciones)
        {
            if (existente.Numero == habitacion.Numero)
            {
                throw new ArgumentException(
                    "Ya existe una habitacion con ese numero.");
            }
        }

        habitaciones.Add(habitacion);
    }

    public List<Habitacion> ListarHabitaciones()
    {
        return new List<Habitacion>(habitaciones);
    }

    public void CambiarTemporada()
    {
        if (temporadaActual is TemporadaAlta)
        {
            temporadaActual = new TemporadaBaja();
        }
        else
        {
            temporadaActual = new TemporadaAlta();
        }
    }

    public Reserva CrearReserva(
        string cliente,
        DateTime fechaIngreso,
        DateTime fechaEgreso,
        List<DetalleReserva> detalles)
    {
        // 1. Validar los datos de la reserva.

        if (string.IsNullOrWhiteSpace(cliente))
        {
            throw new ArgumentException(
                "Debe indicarse un cliente.");
        }

        int dias =
            (fechaEgreso.Date - fechaIngreso.Date).Days;

        if (dias <= 0)
        {
            throw new ArgumentException(
                "La fecha de egreso debe ser posterior " +
                "a la fecha de ingreso.");
        }

        if (detalles == null || detalles.Count == 0)
        {
            throw new ArgumentException(
                "Debe seleccionarse al menos una habitacion.");
        }

        // 2. Verificar TODAS las habitaciones.

        List<int> numerosSeleccionados = new List<int>();

        foreach (DetalleReserva detalle in detalles)
        {
            if (detalle == null ||
                detalle.Habitacion == null ||
                detalle.Regimen == null)
            {
                throw new ArgumentException(
                    "Los detalles de la reserva son invalidos.");
            }

            Habitacion habitacion = detalle.Habitacion;

            if (!habitaciones.Contains(habitacion))
            {
                throw new ArgumentException(
                    "La habitacion no pertenece al hotel.");
            }

            if (numerosSeleccionados.Contains(habitacion.Numero))
            {
                throw new ArgumentException(
                    "Una habitacion no puede repetirse " +
                    "en la misma reserva.");
            }

            if (habitacion.Estado == EstadoHabitacion.Reservada)
            {
                throw new HabitacionReservadaException(
                    $"La habitacion {habitacion.Numero} " +
                    "ya esta reservada.");
            }

            if (!habitacion.AdmiteRegimen(detalle.Regimen))
            {
                throw new ArgumentException(
                    $"El regimen seleccionado no esta " +
                    $"disponible para la habitacion " +
                    $"{habitacion.Numero}.");
            }

            numerosSeleccionados.Add(habitacion.Numero);
        }

        // 3. Calcular el precio total.

        double precioTotal = 0;

        foreach (DetalleReserva detalle in detalles)
        {
            precioTotal += detalle.CalcularSubtotal(
                temporadaActual, dias);
        }

        // 4. Crear la reserva.

        Reserva reserva = new Reserva(
            siguienteNumeroReserva,
            fechaIngreso,
            fechaEgreso,
            cliente,
            detalles,
            precioTotal);

        // 5. Confirmar la ocupacion de las habitaciones.

        foreach (DetalleReserva detalle in detalles)
        {
            detalle.Habitacion.Reservar();
        }

        reservas.Add(reserva);
        siguienteNumeroReserva++;

        return reserva;
    }

    public void EliminarReserva(int numeroReserva)
    {
        Reserva? reservaEncontrada = null;

        foreach (Reserva reserva in reservas)
        {
            if (reserva.Numero == numeroReserva)
            {
                reservaEncontrada = reserva;
                break;
            }
        }

        if (reservaEncontrada == null)
        {
            throw new ArgumentException(
                "No existe una reserva con ese numero.");
        }

        foreach (DetalleReserva detalle
                in reservaEncontrada.ObtenerDetalles())
        {
            detalle.Habitacion.Liberar();
        }

        reservas.Remove(reservaEncontrada);
    }

    public List<Reserva> ListarReservas()
    {
        return new List<Reserva>(reservas);
    }
}