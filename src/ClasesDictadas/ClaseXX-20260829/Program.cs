Persona objAlguienInformal = new Informal("Andrés", "Chimuris");
objAlguienInformal.FechaNacimiento = new DateOnly(2000, 8, 29);


Persona otroFormal = new Formal("Leonardo", "Pinkas");
System.Console.WriteLine(objAlguienInformal.FechaNacimiento);

List<Persona> personas = new  List<Persona>();

personas.Add(new Informal("Gregorio", "Roche"));
personas.Add(objAlguienInformal);
personas.Add(otroFormal);
personas.Add(new Formal("Edgardo", "Grego"));

// personas.RemoveAt(0);
// personas.Remove(otroFormal);

int i = 0;
foreach (Persona unaPersona in personas)
{
    System.Console.WriteLine(unaPersona. Presentarse());
    System.Console.WriteLine($"La posición es {i}");
    i++;
}



//Console.WriteLine((objAlguienInformal).Saludar(otroFormal));
//Console.WriteLine(otroFormal.Saludar(objAlguienInformal));
