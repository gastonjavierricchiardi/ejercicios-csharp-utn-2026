// EJ03-COMPOSITE
using System;

public class Program
{
    public static void Main() // static void Main(string[] args) { }
    {
        SubMenu archivo = new SubMenu("Archivo");
        SubMenu recientes = new SubMenu("Recientes");

        archivo.AddItem(new MenuOption("Nuevo"));
        archivo.AddItem(new MenuOption("Abrir"));

        recientes.AddItem(new MenuOption("informe.txt"));
        recientes.AddItem(new MenuOption("notas.txt"));

        archivo.AddItem(recientes);
        archivo.AddItem(new MenuOption("Salir"));

        archivo.Show(0);
    }
}