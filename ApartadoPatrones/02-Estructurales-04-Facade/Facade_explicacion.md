1. Sí. En el apunte, **Facade** es de los más simples conceptualmente: propone **esconder la complejidad de un sistema** detrás de una clase o interfaz de alto nivel, para ofrecerle al cliente **un conjunto acotado de funciones** más fáciles de usar.

2. **Cuándo usarlo**, según la cursada:

- cuando necesitás **una interfaz simple** para acceder a un sistema complejo
- cuando hay **muchas dependencias** entre los clientes y las implementaciones del subsistema.

3. **Participantes e idea mental**

- **Client**: no habla con todo el subsistema
- **Facade / Fachada**: recibe el pedido y sabe a qué clases del subsistema delegar
- **Clases del subsistema**: hacen el trabajo real y **no conocen a la fachada**.
  Consecuencias importantes:
- oculta componentes del subsistema
- reduce acoplamiento con el cliente
- pero **no impide** usar directamente las clases internas si alguna vez hiciera falta.

Si querés, en la próxima lo bajamos a un ejemplo didáctico antes del código.

---

1. Sí. El apunte lo plantea **conceptual**: una **Facade** oculta la complejidad de varias clases del subsistema y le ofrece al cliente una interfaz simple de alto nivel. Las clases internas hacen el trabajo real; el cliente habla con la fachada.

2. Te lo bajo a código con un ejemplo simple de **compra online**:

```ts
// ==============================
// ProductoService.ts
// Subsistema
// ==============================
export class ProductoService {
  public verificarStock(producto: string): boolean {
    console.log(`Verificando stock de: ${producto}`);
    return true;
  }
}

// ==============================
// PagoService.ts
// Subsistema
// ==============================
export class PagoService {
  public procesarPago(monto: number): boolean {
    console.log(`Procesando pago de: $${monto}`);
    return true;
  }
}

// ==============================
// EnvioService.ts
// Subsistema
// ==============================
export class EnvioService {
  public generarEnvio(direccion: string): string {
    console.log(`Generando envío a: ${direccion}`);
    return "ENVIO-001";
  }
}

// ==============================
// NotificacionService.ts
// Subsistema
// ==============================
export class NotificacionService {
  public enviarConfirmacion(mensaje: string): void {
    console.log(`Notificación: ${mensaje}`);
  }
}

// ==============================
// TiendaFacade.ts
// Fachada
// ==============================
import { ProductoService } from "./ProductoService";
import { PagoService } from "./PagoService";
import { EnvioService } from "./EnvioService";
import { NotificacionService } from "./NotificacionService";

export class TiendaFacade {
  private productoService: ProductoService;
  private pagoService: PagoService;
  private envioService: EnvioService;
  private notificacionService: NotificacionService;

  constructor() {
    this.productoService = new ProductoService();
    this.pagoService = new PagoService();
    this.envioService = new EnvioService();
    this.notificacionService = new NotificacionService();
  }

  public realizarCompra(
    producto: string,
    monto: number,
    direccion: string,
  ): void {
    const hayStock = this.productoService.verificarStock(producto);

    if (!hayStock) {
      console.log("No hay stock disponible.");
      return;
    }

    const pagoOk = this.pagoService.procesarPago(monto);

    if (!pagoOk) {
      console.log("El pago no pudo procesarse.");
      return;
    }

    const codigoEnvio = this.envioService.generarEnvio(direccion);

    this.notificacionService.enviarConfirmacion(
      `Compra realizada con éxito. Código de envío: ${codigoEnvio}`,
    );
  }
}

// ==============================
// Client.ts
// ==============================
import { TiendaFacade } from "./TiendaFacade";

export class Client {
  public execute(): void {
    const tienda = new TiendaFacade();
    tienda.realizarCompra("Teclado mecánico", 25000, "Av. Rivadavia 1234");
  }
}

// ==============================
// index.ts
// ==============================
import { Client } from "./Client";

function main(): void {
  const client = new Client();
  client.execute();
}

main();
```

3. La idea del patrón acá es:

- el **Client** no usa `ProductoService`, `PagoService`, `EnvioService` ni `NotificacionService` por separado
- llama solo a **`TiendaFacade.realizarCompra(...)`**
- la **Facade** coordina todo por adentro
  Eso coincide con el apunte: una clase de alto nivel que encapsula la lógica del subsistema y ofrece pocas funciones simples al cliente.

Si querés, el próximo paso lo hacemos **archivo por archivo y línea por línea**.
