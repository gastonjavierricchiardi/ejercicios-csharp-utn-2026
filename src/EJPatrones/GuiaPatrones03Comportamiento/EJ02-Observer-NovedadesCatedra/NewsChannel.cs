// EJ02-Observer
using System.Collections.Generic;

public class NewsChannel
{
    // 1. CAMPOS / ATRIBUTOS
    private List<IObserver> observers;

    // 2. CONSTRUCTOR
    public NewsChannel()
    {
        observers = new List<IObserver>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void PublishNews(string news)
    {
        List<IObserver> recipients = new List<IObserver>(observers);

        foreach (IObserver observer in recipients)
        {
            observer.Update(news);
        }
    }
}
