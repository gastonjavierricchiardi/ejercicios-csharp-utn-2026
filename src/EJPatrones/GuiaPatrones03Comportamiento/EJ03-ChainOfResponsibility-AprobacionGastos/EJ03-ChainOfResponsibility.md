### Ejercicio 3 - Chain of Responsibility: aprobación de gastos

En una empresa, cada gasto lo aprueba el primer nivel con autoridad suficiente: el supervisor hasta $50.000, el gerente hasta $200.000 y el director sin límite. Quien carga un gasto siempre se lo presenta al supervisor y no sabe quién lo va a terminar aprobando.

La empresa planea sumar un nivel "jefe de área" entre el supervisor y el gerente. Ese cambio debe resolverse agregando el nivel nuevo y armando la secuencia de otra forma, sin modificar los niveles existentes.

**Para verificar:** presentar al supervisor gastos de $30.000, $120.000 y $500.000.

```text
$30000 aprobado por Supervisor
$120000 aprobado por Gerente
$500000 aprobado por Director
```

> **Para pensar:** ¿qué pasa si ningún nivel puede atender un gasto? Proponer una forma de avisarlo.
