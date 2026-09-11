
try
{
    Persona persona = new Persona(123123, "Leonardo", "Perez");

    System.Console.WriteLine(persona.Saludar());
}
catch(ExcepcionPersona bpersonaException)
{
    System.Console.WriteLine(bpersonaException.Mensaje + " - " + bpersonaException.StackTrace);
}
catch(Exception unaExcepcion)
{
    System.Console.WriteLine("Ha ocurrido un error generico - " + unaExcepcion.Message + unaExcepcion.StackTrace);
}
finally
{
    
}



/*
Operaciones operacion = Operaciones.Sumar;
int numero1, numero2;

numero1 = 3;
numero2 = 5;

double resultado = 0;


try
{
    switch (operacion)
    {
        case Operaciones.Sumar:
            resultado = numero1 + numero2;
        break;

        case Operaciones.Restar:
            resultado = numero1 - numero2;
        break;


        case Operaciones.Multiplicar:
            resultado = numero1 * numero2;
        break;

        case Operaciones.Dividir:
            resultado = numero1 / (numero2 - numero2);
        break;
        
    }

    //throw new System.DivideByZeroException();
    
    System.Console.WriteLine($"El resultado de la operacion {operacion} es {resultado}");

   // throw new Exception("Lanzamos una excepción!!!!!");

}
catch (System.DivideByZeroException dbze)
{
    
    System.Console.WriteLine("Usted intentó dividir por cero. Eso no se puede...." + dbze.StackTrace);
}
catch (System.Exception unaExcepcion)
{
    
    System.Console.WriteLine("Ha ocurrido un problema.... " + unaExcepcion.Message + " " + unaExcepcion.StackTrace);
}
finally
{
    System.Console.WriteLine("Esto se ejecuta siempre.");
}






// switch (hoy)
// {
//     case DiaSemana.Sabado:
//     case DiaSemana.Domingo:
//         Console.WriteLine("Fin de semana");
//     break;
//     default:
//         Console.WriteLine("Día laboral");
//     break;
// }

// System.Console.WriteLine((int)hoy);
*/