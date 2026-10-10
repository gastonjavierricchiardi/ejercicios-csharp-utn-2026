[Refactoring.Guru — Adapter](https://refactoring.guru/es/design-patterns/adapter).

## 1. ¿Qué cambia con Adapter?

Refactoring.Guru propone que un adaptador envuelva un objeto existente, implemente una interfaz común y traduzca las solicitudes para que el cliente pueda utilizarlo sin conocer su estructura original.&#x20;

En nuestro ejercicio, los roles serían:

| Rol del patrón                | Nuestro EJ21                                       |
| ----------------------------- | -------------------------------------------------- |
| Cliente                       | `AnalizadorDocumentos`                             |
| Target (interfaz común)       | `IDocument`                                        |
| Adaptees (objetos originales) | `Escrito`, `Documento`, `Ley`                      |
| Adapters                      | `EscritoAdapter`, `DocumentoAdapter`, `LeyAdapter` |

Modelo propuesto

```

Escrito ──── EscritoAdapter ────┐
                               │
Documento ── DocumentoAdapter ─┼── IDocument
                               │       │
Ley ──────── LeyAdapter ───────┘       │
                                       ▼
                               AnalizadorDocumentos

```

Conservamos las tres clases originales y sus properties completas. `Document` también podrá implementar `IDocument`. La clase `NormalizadorDocumentos` se retirará cuando terminemos la migración y validemos las pruebas.

---

# EJ22 - Revisión final

|       Clase / interfaz | Responsabilidad                                             |
| ---------------------: | :---------------------------------------------------------- |
|            `IDocument` | Contrato común que permite consultar los cuatro datos       |
|              `Escrito` | Represente el documento original del primer organismo       |
|            `Documento` | Representa el documento original del segundo organismo      |
|                  `Ley` | Representa el documento original del tercer organismo       |
|       `EscritoAdapter` | Adapta `Escrito` a `IDocument`.                             |
|     `DocumentoAdapter` | Adapta `Documento` a `IDocument`.                           |
|           `LeyAdapter` | Adapta `Ley` a `IDocument`.                                 |
| `AnalizadorDocumentos` | Valida documentos sin conocer sus clases originales         |
|              `Program` | Crea los objetos, sus **adaptadores** y ejecuta el análisis |
