// Guia01\EJ03\articulo.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
using System;
public class Articulo
{
    // * 1) ATRIBUTOS
    public string _marca = "";
    // private string _marca = "";
    // public string _modelo = "";
    private string _modelo = "";

    // * 3) PROPIEDADES(GET / SET)

    public void SetMarca(string marca)
    {
        this._marca = marca;
    }

    public void SetModelo(string modelo)
    {
        this._modelo = modelo;
    }

}