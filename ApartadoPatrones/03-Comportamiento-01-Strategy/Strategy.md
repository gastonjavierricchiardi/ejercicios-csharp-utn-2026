Sí. En el apunte, **Strategy** se baja como: un **Context** que guarda una referencia a una **interfaz Strategy**, y varias **ConcreteStrategy** que implementan el mismo método para que el comportamiento pueda cambiar incluso en tiempo de ejecución. El ejemplo que da la cursada es justamente **SortStrategy / QuickSort / ShellSort / SortedList**.

1. **Mapa 1:1 del apunte**
   - `Strategy` → `SortStrategy`
   - `ConcreteStrategy` → `QuickSort` y `ShellSort`
   - `Context` → `SortedList`

2. **Código base, separado por archivo**

```ts
// ==============================
// SortStrategy.ts
// ==============================
export interface SortStrategy {
  sort(data: number[]): number[];
}

// ==============================
// QuickSort.ts
// ==============================
import { SortStrategy } from "./SortStrategy";

export class QuickSort implements SortStrategy {
  public sort(data: number[]): number[] {
    const copy = [...data];
    return this.quickSort(copy);
  }

  private quickSort(data: number[]): number[] {
    if (data.length <= 1) {
      return data;
    }

    const pivot = data[data.length - 1];
    const left: number[] = [];
    const right: number[] = [];

    for (let i = 0; i < data.length - 1; i++) {
      if (data[i] <= pivot) {
        left.push(data[i]);
      } else {
        right.push(data[i]);
      }
    }

    return [...this.quickSort(left), pivot, ...this.quickSort(right)];
  }
}

// ==============================
// ShellSort.ts
// ==============================
import { SortStrategy } from "./SortStrategy";

export class ShellSort implements SortStrategy {
  public sort(data: number[]): number[] {
    const copy = [...data];
    let gap = Math.floor(copy.length / 2);

    while (gap > 0) {
      for (let i = gap; i < copy.length; i++) {
        const temp = copy[i];
        let j = i;

        while (j >= gap && copy[j - gap] > temp) {
          copy[j] = copy[j - gap];
          j -= gap;
        }

        copy[j] = temp;
      }

      gap = Math.floor(gap / 2);
    }

    return copy;
  }
}

// ==============================
// SortedList.ts
// ==============================
import { SortStrategy } from "./SortStrategy";

export class SortedList {
  private strategy: SortStrategy;

  constructor(strategy: SortStrategy) {
    this.strategy = strategy;
  }

  public setStrategy(strategy: SortStrategy): void {
    this.strategy = strategy;
  }

  public sort(data: number[]): number[] {
    return this.strategy.sort(data);
  }
}

// ==============================
// index.ts
// ==============================
import { QuickSort } from "./QuickSort";
import { ShellSort } from "./ShellSort";
import { SortedList } from "./SortedList";

function main(): void {
  const numbers: number[] = [8, 3, 1, 9, 7, 2, 5, 4, 6];

  const sortedList = new SortedList(new QuickSort());

  console.log("Original:", numbers);
  console.log("QuickSort:", sortedList.sort(numbers));

  sortedList.setStrategy(new ShellSort());
  console.log("ShellSort:", sortedList.sort(numbers));
}

main();
```

3. **Qué se ve acá**
   - `SortedList` **no sabe ordenar por sí sola**: delega.
   - `QuickSort` y `ShellSort` comparten la misma interfaz.
   - el cliente puede **cambiar la estrategia en runtime** con `setStrategy(...)`, que es exactamente la idea central del patrón en el apunte.

En la próxima te lo armamos didácticamente **archivo por archivo**, arrancando por `SortStrategy.ts`.

---

Sí, en **nuestro Strategy** queda así:

1. **Correspondencia 1:1**
   - **Context** → `SortedList.ts`
   - **<<interface>> Strategy** → `SortStrategy.ts`
   - **ConcreteStrategyA** → `QuickSort.ts`
   - **ConcreteStrategyB** → `ShellSort.ts`
     Eso coincide con el apunte/PPT: `Strategy (SortStrategy)`, `ConcreteStrategy (QuickSort, ShellSort)` y `Context (SortedList)`.

2. **Y `index.ts` qué sería**
   - `index.ts` **no forma parte del diagrama central**.
   - cumple el rol de **cliente / prueba**, porque crea el `SortedList`, le asigna una estrategia y ejecuta el ejemplo.
     En el PPT dice que los clientes usualmente crean y asignan el strategy al contexto y luego interactúan con el contexto.

3. **Resumen corto**

```ts
Context -> SortedList.ts
Strategy -> SortStrategy.ts
ConcreteStrategyA -> QuickSort.ts
ConcreteStrategyB -> ShellSort.ts
Client/prueba -> index.ts
```
