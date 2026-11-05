// EJ02-Observer
using System;

public class AppSubscriber : IObserver
{
    // 1. CAMPOS / ATRIBUTOS
    private string name;
    // 2. CONSTRUCTOR
    public AppSubscriber(string name)
    {
        this.name = name;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void Update(string news)
    {
        //throw new NotImplementedException();
        System.Console.WriteLine($"{name} recibió en la app: {news}");
    }
}