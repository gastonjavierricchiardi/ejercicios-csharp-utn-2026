/*
    =========================================================
    PROGRAM
    =========================================================

    Este archivo funciona como punto de entrada del programa.

    Acá se crean los objetos concretos y se los hace
    interactuar entre sí para probar el modelo desarrollado:

        - Orador
        - General
        - VIP
        - Evento

    Después se realizan inscripciones, check-in
    y finalmente se solicita el resumen del evento.
*/


/*
    Código generado originalmente por la plantilla
    de consola de .NET.

    Queda comentado porque ya no lo necesitamos.
*/
//Console.WriteLine("Hello, World!");



/*
    =========================================================
    CREACIÓN DE UN ORADOR
    =========================================================

    Se crea un objeto concreto de tipo Orador.

    El constructor recibe:

        - DNI       -> 123
        - nombre    -> "Leonardo"
        - tema      -> "POO"

    Los datos DNI y nombre serán enviados por Orador
    al constructor de Asistente mediante base().

    El tema queda como dato particular de Orador.
*/
Orador orador = new Orador(123, "Leonardo", "POO");



/*
    =========================================================
    CREACIÓN DE UN ASISTENTE GENERAL
    =========================================================

    Se crea un objeto concreto de tipo General.

    El constructor recibe:

        - DNI
        - nombre

    General no agrega ningún atributo particular.
*/
General unGeneral = new General(1234, "Un asistente general");



/*
    =========================================================
    CREACIÓN DE UN VIP
    =========================================================

    Se crea un objeto concreto de tipo VIP.

    El constructor recibe:

        - DNI
        - nombre
        - regalo

    El regalo es el dato particular de VIP.
*/
VIP unVIP = new VIP(987, "Un asistente VIP", "Un termo");



/*
    =========================================================
    CREACIÓN DEL EVENTO
    =========================================================

    Se crea el objeto que será responsable de administrar:

        - participantes;
        - presentes;
        - inscripción;
        - check-in;
        - resumen.
*/
Evento elEvento = new Evento();



/*
    =========================================================
    INFORMACIÓN DEL EVENTO
    =========================================================

    Se asigna un valor a la property Informacion
    del objeto elEvento.
*/
elEvento.Informacion = "Clase de POO";



/*
    =========================================================
    INSCRIPCIÓN DEL ORADOR
    =========================================================

    Se envía el objeto orador al método
    AgregarParticipante().

    Aunque el objeto real es Orador,
    el método recibe un parámetro de tipo Asistente:

        AgregarParticipante(Asistente asistente)

    Esto es posible porque Orador ES UN Asistente.
*/
elEvento.AgregarParticipante(orador);



/*
    =========================================================
    INSCRIPCIÓN DEL VIP
    =========================================================

    También se agrega el objeto VIP.

    Nuevamente, VIP puede ser tratado como Asistente
    porque pertenece a la misma jerarquía.
*/
elEvento.AgregarParticipante(unVIP);



/*
    =========================================================
    CHECK-IN DEL ORADOR
    =========================================================

    Evento verifica:

        1. si el DNI está inscripto;
        2. si ya había realizado check-in;
        3. si puede registrarlo como presente.

    Si el ingreso es correcto, también ejecutará:

        asistente.InformarBeneficio()

    Como el objeto real es Orador, responderá
    con la implementación de Orador.
*/
elEvento.RegistrarCheckIn(orador);



/*
    =========================================================
    CHECK-IN DEL VIP
    =========================================================

    Se realiza el mismo procedimiento con el VIP.

    El llamado dentro de Evento será exactamente el mismo:

        asistente.InformarBeneficio()

    pero esta vez responderá la implementación de VIP.

    Ahí vemos el polimorfismo en funcionamiento.
*/
elEvento.RegistrarCheckIn(unVIP);



/*
    =========================================================
    RESUMEN FINAL
    =========================================================

    Evento calcula:

        - cantidad de inscriptos;
        - cantidad de presentes;
        - cantidad de ausentes.

    InformarResumen() devuelve un string.

    Console.WriteLine() muestra ese string en pantalla.
*/
System.Console.WriteLine(elEvento.InformarResumen());