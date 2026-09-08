/*
Console.WriteLine("Hello, World!");
Clase 05-09-2026
Las interfaces son habilidades. <i>costeable, calculable
*/

/* Clase 11

*/
// 1. Primero el código ejecutable
DiaSemana hoy = DiaSemana.Sabado;

switch (hoy)
{
    case DiaSemana.Sabado:
    case DiaSemana.Domingo:
        Console.WriteLine("Fin de semana");
        break;
    default:
        Console.WriteLine("Día laboral");
        break;
}

// 2. Al final las declaraciones de tipos
enum DiaSemana { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo }