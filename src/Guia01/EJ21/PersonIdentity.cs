/*EJ21

PersonIdentity representa el servicio externo indicado
por el enunciado.

Como el servicio real no existe dentro del proyecto,
lo simulamos recibiendo:

- una Person;
- un bool que indica si la identidad fue validada.
*/

using System;

public class PersonIdentity
{
    // 1. CAMPOS / ATRIBUTOS
    private Person person;
    private bool datosValidos;

    // 2. CONSTRUCTOR
    public PersonIdentity(
        Person person,
        bool datosValidos
    )
    {
        this.person = person;
        this.datosValidos = datosValidos;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public Person getInfo(string dni)
    {
        if (datosValidos == false)
        {
            throw new Exception("Los datos de identidad no coinciden");
        }

        return person;
    }
}