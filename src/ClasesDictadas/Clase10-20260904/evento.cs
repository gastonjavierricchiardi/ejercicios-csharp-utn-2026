/*
    =========================================================
    EVENTO
    =========================================================

    Evento es la clase encargada de administrar:

        - la información del evento;
        - los regalos disponibles;
        - los asistentes inscriptos;
        - los asistentes que realizaron check-in.

    En esta clase aparecen las dos colecciones centrales
    pedidas por el ejercicio:

        Dictionary<int, Asistente>
        HashSet<Asistente>
*/
public class Evento
{
    /*
        =====================================================
        INFORMACIÓN DEL EVENTO
        =====================================================

        Guarda información general del evento.

        El atributo es privado y se accede mediante
        una property pública.
    */
    private string informacion;

    public string Informacion
    {
        get { return informacion; }
        set { informacion = value; }
    }


    /*
        =====================================================
        REGALOS
        =====================================================

        Lista de regalos asociados al evento.

        La colección es de tipo:

            List<string>

        En el código trabajado en clase esta colección
        queda declarada, aunque todavía no interviene
        en AgregarParticipante(), RegistrarCheckIn()
        ni InformarResumen().
    */
    private List<string> regalos;

    public List<string> Regalos
    {
        get { return regalos; }
        set { regalos = value; }
    }


    /*
        =====================================================
        PARTICIPANTES
        =====================================================

        Guarda a todos los asistentes inscriptos.

        Se utiliza un Dictionary porque cada participante
        queda asociado directamente a una clave.

        La clave es:

            int -> DNI

        El valor es:

            Asistente -> objeto inscripto

        Conceptualmente:

            DNI -----> Asistente
    */
    private Dictionary<int, Asistente> participantes;

    public Dictionary<int, Asistente> Participantes
    {
        get { return participantes; }
        set { participantes = value; }
    }


    /*
        =====================================================
        PRESENTES
        =====================================================

        Guarda los asistentes que ya realizaron check-in.

        Se utiliza un HashSet porque necesitamos trabajar
        con elementos únicos y detectar si un asistente
        ya fue registrado.

        La comparación de los objetos Asistente se apoya
        en Equals() y GetHashCode(), que fueron redefinidos
        en la clase Asistente utilizando el DNI.
    */
    private HashSet<Asistente> presentes;

    public HashSet<Asistente> Presentes
    {
        get { return presentes; }
        set { presentes = value; }
    }


    /*
        =====================================================
        AGREGAR PARTICIPANTE
        =====================================================

        Recibe un Asistente y lo incorpora al Dictionary
        de participantes.

        Como el parámetro es del tipo Asistente,
        puede recibir cualquiera de sus subclases:

            - General
            - VIP
            - Orador
    */
    public void AgregarParticipante(Asistente asistente)
    {
        /*
            Si Participantes todavía no fue inicializado,
            se crea el Dictionary.

            Esta fue la estrategia utilizada en la
            implementación de clase.
        */
        if (this.Participantes == null)
        {
            this.Participantes = new Dictionary<int, Asistente>();
        }


        /*
            También se inicializa Presentes si todavía
            no existe.
        */
        if (this.Presentes == null)
        {
            this.Presentes = new HashSet<Asistente>();
        }


        /*
            ContainsKey() pregunta si el DNI ya existe
            como clave dentro del Dictionary.

            Solamente se agrega si todavía no existe.
        */
        if (!this.participantes.ContainsKey(asistente.DNI))
        {
            /*
                DNI del asistente -> clave
                asistente        -> valor
            */
            this.participantes.Add(asistente.DNI, asistente);
        }
    }


    /*
        =====================================================
        REGISTRAR CHECK-IN
        =====================================================

        Recibe un Asistente e intenta registrar
        su ingreso al evento.

        Debe resolver tres situaciones:

            1. No está inscripto.
            2. Ya había realizado check-in.
            3. Está inscripto y todavía no ingresó.
    */
    public void RegistrarCheckIn(Asistente asistente)
    {
        /*
            Igual que en AgregarParticipante(),
            primero se garantiza que las colecciones
            estén inicializadas.
        */
        if (this.Participantes == null)
        {
            this.Participantes = new Dictionary<int, Asistente>();
        }

        if (this.Presentes == null)
        {
            this.Presentes = new HashSet<Asistente>();
        }


        /*
            =================================================
            CASO 1: NO ESTÁ INSCRIPTO
            =================================================

            Se busca directamente el DNI dentro
            del Dictionary mediante ContainsKey().
        */
        if (!this.participantes.ContainsKey(asistente.DNI))
        {
            Console.WriteLine(
                $"El DNI {asistente.DNI} no está en la lista de inscriptos"
            );
        }
        else
        {
            /*
                =============================================
                CASO 2: YA REALIZÓ CHECK-IN
                =============================================

                El HashSet permite preguntar si ese
                asistente ya se encuentra registrado
                como presente.
            */
            if (this.presentes.Contains(asistente))
            {
                Console.WriteLine(
                    $"El DNI {asistente.DNI} ya ha realizado el check in."
                );
            }
            else
            {
                /*
                    =========================================
                    CASO 3: CHECK-IN CORRECTO
                    =========================================

                    El asistente estaba inscripto
                    y todavía no figuraba como presente.

                    Se agrega al HashSet.
                */
                this.presentes.Add(asistente);


                /*
                    Después se informa la bienvenida.

                    Acá aparece el polimorfismo:

                        asistente.InformarBeneficio()

                    Evento no necesita preguntar si el objeto
                    es General, VIP u Orador.

                    Cada objeto resuelve InformarBeneficio()
                    según su propia implementación.
                */
                Console.WriteLine(
                    $"El DNI {asistente.DNI} realizó el check in. " +
                    $"Le damos la bienvenida, estos son tus beneficios " +
                    $"{asistente.InformarBeneficio()}"
                );
            }
        }
    }


    /*
        =====================================================
        INFORMAR RESUMEN
        =====================================================

        Genera el resumen final del evento.

        Calcula:

            - cantidad de inscriptos;
            - cantidad de presentes;
            - cantidad de ausentes.
    */
    public string InformarResumen()
    {
        /*
            Contadores locales.
        */
        int totalInscriptos = 0;
        int totalPresentes = 0;


        /*
            Se recorre el Dictionary completo.

            Por cada participante encontrado,
            se aumenta el contador.
        */
        foreach (var unInscripto in participantes)
        {
            totalInscriptos++;
        }


        /*
            Se recorre el HashSet completo.

            Por cada asistente presente,
            se aumenta el contador.
        */
        foreach (var unPresente in presentes)
        {
            totalPresentes++;
        }


        /*
            Los ausentes se calculan como:

                inscriptos - presentes
        */
        int totalAusentes = totalInscriptos - totalPresentes;


        /*
            Se devuelve el resumen como string.
        */
        return $"El total de inscriptos es {totalInscriptos}, " +
               $"con un total de presentes de {totalPresentes}, " +
               $"con un total de ausentes de {totalAusentes}";
    }
}