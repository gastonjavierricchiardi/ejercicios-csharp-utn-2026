//Console.WriteLine("Hello, World!");

SistemaDeTraccion objUnSistemaDeTraccion = new Caucho();

Robot objMiRobot = new Robot(objUnSistemaDeTraccion, "KT-2020-P");

Console.WriteLine(objMiRobot.GetInfo());

Console.WriteLine("Ahora le cambiamos el sistema de tracción");

objMiRobot.SistemaDeTraccion = new Oruga();
Console.WriteLine(objMiRobot.GetInfo());