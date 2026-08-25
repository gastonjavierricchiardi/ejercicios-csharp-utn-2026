// /src/Guia01/EJ13/Caucho.cs
// Gastón Ricchiardi(Gastonj@hotmail.com)


// 1. CAMPOS / ATRIBUTOS
// Estado interno del objeto.
// Normalmente private.

// 2. CONSTRUCTOR
// Recibe los datos necesarios al crear el objeto.

// 3. PROPIEDADES / GETTERS Y SETTERS
// Formas de exponer o modificar el estado.

// 4. MÉTODOS
// Comportamiento del objeto.


public class Caucho : SistemaDeTraccion
{
    public override double AvanceMaximo()
    {
        return 100;
    }

    public override double Desgaste()
    {
        return 1;
    }

    public override string GetInfoExtra()
    {
        return "Sin información extra"; //return "";
    }
}