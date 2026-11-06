// EJ03-CHAIN OF RESPONSIBILITY
using System;
public class Program
{
    public static void Main()//static void Main(string[] args) // si tiene que recibir datos por consola
    {
        // Crear los niveles de aprobación
        Supervisor supervisor = new Supervisor();
        Manager manager = new Manager();
        Director director = new Director();

        // Configuramos la cadena
        supervisor.SetNext(manager);
        manager.SetNext(director);

        // Presentar los gastos al supervisor
        supervisor.Approve(30000m);
        supervisor.Approve(120000m);
        supervisor.Approve(500000m);
    }
}