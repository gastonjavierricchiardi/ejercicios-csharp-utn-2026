//SRP
/*
Book unLibro = new Book("Cervantes", "Don Quijote", "Bla bla bla bla...");

ILibroPersistible libroPersistido = new LibroPersistidoEnBBDD();
libroPersistido.Guardar(unLibro);

LibroEnPDF guardarLibroEnPDF = new LibroEnPDF();
guardarLibroEnPDF.Guardar(unLibro);
*/

//OCP
Cuenta unaCuenta = new Cuenta();
unaCuenta.TipoCuenta = new CuentaSueldo();
unaCuenta.TipoCuenta.Nombre = "Cuenta sueldo...";
System.Console.WriteLine(unaCuenta.ImprimirInfo());

unaCuenta.Retirar(4440);
System.Console.WriteLine(unaCuenta.ImprimirInfo());

unaCuenta.TipoCuenta.IngresarMonto(100000);

System.Console.WriteLine(unaCuenta.ImprimirInfo());