// EJ02-Observer
using System;
public class EmailSubscriber : IObserver
{
    // 1. CAMPOS / ATRIBUTOS
    private string name;
    // 2. CONSTRUCTOR
    public EmailSubscriber(string name)
    {
        this.name = name;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void Update(string news)
    {
        //throw new NotImplementedException();
        System.Console.WriteLine($"{name} recibió por email: {news}");
    }
}