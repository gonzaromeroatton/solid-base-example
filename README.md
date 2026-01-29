Este proyecto muestra ejemplos sencillos de cómo aplicar los principios de SOLID en C# mediante ejemplos "buenos" y "malos" que destacan las diferencias entre una mala y una buena implementación.

## Principios incluidos en el proyecto

### Single Responsibility Principle (SRP)
El principio de responsabilidad única establece que una clase debe tener una, y solo una, razón para cambiar. Estas responsabilidades deben ser completamente necesarias para describir el propósito de la clase.

- Ejemplo "malo": La clase `InvoiceService` realiza múltiples tareas como validación, persistencia y logging en una sola clase.
- Ejemplo "bueno": Una solución que incluye las interfaces `IInvoiceRepository` e `ILogger`, delegando responsabilidades específicas.

### Open-Closed Principle (OCP)
El principio de abierto/cerrado establece que los módulos de software deben estar abiertos a la extensión pero cerrados a la modificación, lo que fomenta la reutilización y reduce el riesgo a errores al cambiar el código existente.

- Ejemplo "malo": La clase `Discounts` calcula distintos tipos de descuentos con un `switch` basado en cadenas de texto.
- Ejemplo "bueno": La clase `Discounts` implementa una interfaz común `IDiscount`, permitiendo agregar nuevos tipos de descuentos sin modificar la lógica ya existente.

### Liskov Substitution Principle (LSP)
El principio de sustitución de Liskov indica que los objetos deben ser reemplazables por instancias de sus subtipos sin alterar el comportamiento esperado del programa.

- Ejemplo "malo": La clase `Ostrich` (avestruz) hereda de `Bird` pero lanza una excepción al intentar volar, violando el principio.
- Ejemplo "bueno": Se definen interfaces específicas como `IFlyingBird` para cumplir adecuadamente este principio.

## Ejemplo de estructura

```
Solid.DotNET.Howto
├── 1.SRP
│   ├── Bad
│   │   └── InvoiceService.cs
│   ├── Good
│       ├── Interface
│       │   └── ...

├── 2.OCP...

```
