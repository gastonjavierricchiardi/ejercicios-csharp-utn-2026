/*
EJ21
Como este servicio real no existe, dentro de nuestro proyecto, lo vamos a simular
para hacer pruebas
*/
using System;
public class PersonIdentity
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public Person getInfo(string dni)
    {
        Person person = Person(
            "Juan",
            "Perez",
            new DateTime(1990, 5, 15)
        );
        return person;
    }
}