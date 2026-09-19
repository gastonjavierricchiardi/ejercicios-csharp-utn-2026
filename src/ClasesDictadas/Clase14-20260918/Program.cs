using System.Net.WebSockets;
using System.Runtime.InteropServices;

ReinoDeCaballito objImperio = new ReinoDeCaballito();

Acorazado objAcorazado = new Acorazado();
objAcorazado.Nombre = "ACORAZADO 1";

Lancha objLancha= new Lancha();
objLancha.Nombre = "El Gaucho";

Destructor objDesctructor = new Destructor("El destructor", 600);

if (objLancha.Acarrear(objDesctructor))
    Console.WriteLine("Pudo acarrear al desctructor");
else
    Console.WriteLine("NO PUDO acarrear al desctructor");


objDesctructor = new Destructor("El destructor 2", 200);
if (objLancha.Acarrear(objDesctructor))
    Console.WriteLine("Pudo acarrear al desctructor");
else
    Console.WriteLine("NO PUDO acarrear al desctructor");


objImperio.AgregarNavio(objAcorazado);
objImperio.AgregarNavio(objLancha);
objImperio.AgregarNavio(objDesctructor);

try
{
    System.Console.WriteLine(objImperio.PresentarArmada());
}
catch (System.NotImplementedException nie)
{
    System.Console.WriteLine("Usted esta llamadno a una funcionalidad que todavía no tenemos disponbile. En nuestra próxima actualización estaremos brindando este nuevo servicio...");
}
catch (System.Exception)
{
    
    System.Console.WriteLine("Ocurrió un error no esperado...");
}


