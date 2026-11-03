//EJ03-AbstractFactory
using System;
public class FabricaClasica : IFabricaLiving
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public ISilla CrearSilla()
    {
        //throw new NotImplementedException();
        return new SillaClasica();
    }
    public IMesa CrearMesa()
    {
        //throw new NotImplementedException();
        return new MesaClasica();
    }
}