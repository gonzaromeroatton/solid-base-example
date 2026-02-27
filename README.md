# SOLID en .NET (C#) — Solid.DotNET.Howto

![.NET](https://img.shields.io/badge/.NET-8%2B-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Learning-239120?logo=csharp&logoColor=white)
![SOLID](https://img.shields.io/badge/Principios-SOLID-blue)
![Status](https://img.shields.io/badge/Status-Educational-success)

Repositorio educativo con ejemplos **sencillos y directos** para aprender a aplicar los principios **SOLID** en **C# (.NET)** mediante comparaciones **Bad vs Good** (mala implementación vs refactor recomendado).

---

## Tabla de contenidos

- [¿Qué vas a encontrar?](#qué-vas-a-encontrar)
- [Principios SOLID incluidos](#principios-solid-incluidos)
  - [SRP — Single Responsibility Principle](#srp--single-responsibility-principle)
  - [OCP — Open-Closed Principle](#ocp--open-closed-principle)
  - [LSP — Liskov Substitution Principle](#lsp--liskov-substitution-principle)
  - [ISP — Interface Segregation Principle](#isp--interface-segregation-principle)
  - [DIP — Dependency Inversion Principle](#dip--dependency-inversion-principle)
- [Estructura del repositorio](#estructura-del-repositorio)
- [Cómo ejecutar / explorar los ejemplos](#cómo-ejecutar--explorar-los-ejemplos)
- [Sugerencias de aprendizaje](#sugerencias-de-aprendizaje)
- [Licencia](#licencia)

---

## Qué vas a encontrar

✅ Ejemplos cortos y enfocados  
✅ Comparación **Bad** (anti-pattern típico) vs **Good** (solución con mejor diseño)  
✅ Código pensado para **leer y discutir**, no para “frameworkizar”  
✅ Estructura por principio para navegar rápido

> [!TIP]
> Si estás aprendiendo, te conviene abrir 2 archivos a la vez: `Bad/...` y `Good/...` para comparar línea por línea.

---

## Principios SOLID incluidos

> Nota: cada principio suele tener una carpeta (o sección) con implementaciones **Bad** y su equivalente **Good**.

### SRP — Single Responsibility Principle

**Idea:** una clase debe tener **una sola razón para cambiar**.  
Cuando una clase hace *validación + persistencia + logging + reglas de negocio*, se vuelve frágil, difícil de testear y costosa de modificar.

#### Anti-patrón común (Bad)
- Un `InvoiceService` que:
  - valida
  - guarda
  - loguea
  - decide reglas
  - y además “coordina” todo

```mermaid
flowchart LR
  A[InvoiceService (Bad)] --> B[Validación]
  A --> C[Persistencia]
  A --> D[Logging]
  A --> E[Reglas de negocio]
```

#### Refactor recomendado (Good)
Separar responsabilidades: validación, persistencia y logging en componentes específicos, y dejar un servicio “orquestador” fino.

```mermaid
flowchart LR
  A[InvoiceService (Good)] --> B[IInvoiceValidator]
  A --> C[IInvoiceRepository]
  A --> D[ILogger]
```

---

### OCP — Open-Closed Principle

**Idea:** el código debería estar **abierto a extensión** y **cerrado a modificación**.  
Cuando para agregar un caso nuevo (por ejemplo un método de pago, un tipo de descuento o una regla de envío) hay que tocar un `switch` gigante, se rompe OCP.

#### Anti-patrón común (Bad)
- `switch/if` por tipo que crece con cada nuevo caso.

#### Refactor recomendado (Good)
- Polimorfismo / estrategia: agregar nuevos comportamientos creando nuevas clases que implementan una interfaz, sin modificar las existentes.

---

### LSP — Liskov Substitution Principle

**Idea:** si `B` hereda de `A`, entonces debería poder usarse `B` donde se espera `A` **sin romper el programa**.  
Si una subclase cambia contratos (por ejemplo: lanza excepciones inesperadas, devuelve valores incompatibles o no soporta métodos del padre), se viola LSP.

#### Señales típicas de violación
- `NotSupportedException` en overrides.
- Subclases que requieren precondiciones más fuertes.

#### Refactor recomendado
- Replantear herencia vs composición.
- Separar interfaces más pequeñas.

---

### ISP — Interface Segregation Principle

**Idea:** es mejor tener **interfaces pequeñas y específicas** que una interfaz “god” que obliga a implementar métodos que no se usan.

#### Anti-patrón común (Bad)
- Una interfaz enorme (por ejemplo `IWorker`) con métodos que no aplican a todas las implementaciones.

#### Refactor recomendado (Good)
- Dividir en interfaces por capacidad: `IWork`, `IEat`, `ISleep`, etc.

---

### DIP — Dependency Inversion Principle

**Idea:** los módulos de alto nivel no deben depender de módulos de bajo nivel, ambos deben depender de **abstracciones**.  
Además, las abstracciones no deben depender de detalles: los detalles deben depender de las abstracciones.

#### Anti-patrón común (Bad)
- Instanciar dependencias concretas dentro de las clases (`new SqlInvoiceRepository()`), acoplando a infraestructura.

#### Refactor recomendado (Good)
- Inyectar interfaces (por constructor) y resolver implementaciones con DI (por ejemplo con `Microsoft.Extensions.DependencyInjection`).

---

## Estructura del repositorio

La estructura exacta puede variar, pero la idea es que puedas navegar por principio y comparar implementaciones.

Sugerencia típica:

```text
./
  src/
    Solid.DotNET.Howto/
      SRP/
        Bad/
        Good/
      OCP/
        Bad/
        Good/
      LSP/
        Bad/
        Good/
      ISP/
        Bad/
        Good/
      DIP/
        Bad/
        Good/
```

Si tu repo usa otra estructura (por ejemplo `SolidBaseExample/SRP/...`), mantené el mismo concepto: **principio → Bad/Good**.

---

## Cómo ejecutar / explorar los ejemplos

1. Clonar el repositorio
   ```bash
   git clone https://github.com/gonzaromeroatton/solid-base-example.git
   cd solid-base-example
   ```

2. Abrir en tu IDE
   - Visual Studio / Rider / VS Code.

3. Ejecutar
   - Si hay un proyecto consola o tests, podés correr:
     ```bash
     dotnet build
     dotnet test
     ```

> Si algún ejemplo no es ejecutable (por diseño), igual sirve para lectura y discusión.

---

## Sugerencias de aprendizaje

- Leé primero el caso **Bad** e intentá identificar el problema.
- Pasá a **Good** y buscá:
  - cómo se redujo el acoplamiento,
  - dónde quedaron las responsabilidades,
  - qué cambió en el contrato (interfaces / abstracciones).
- Tratá de imaginar “el próximo cambio”: ¿agregarías un caso nuevo sin tocar el código existente?

---

## Licencia

Ver [LICENSE](LICENSE) si aplica en el repositorio.