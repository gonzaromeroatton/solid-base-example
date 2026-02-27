# SOLID en .NET (C#) — Solid.DotNET.Howto

![.NET](https://img.shields.io/badge/.NET-8%2B-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Learning-239120?logo=csharp&logoColor=white)
![SOLID](https://img.shields.io/badge/Principios-SOLID-blue)
![Status](https://img.shields.io/badge/Status-Educational-success)

Repositorio educativo con ejemplos **sencillos y directos** para aprender a aplicar los principios **SOLID** en **C#** mediante comparaciones **Bad vs Good** (mala implementación vs refactor recomendado).

---

## Tabla de contenidos

- [¿Qué vas a encontrar?](#qué-vas-a-encontrar)
- [Principios SOLID incluidos](#principios-solid-incluidos)
  - [SRP — Single Responsibility Principle](#srp--single-responsibility-principle)
  - [OCP — Open-Closed Principle](#ocp--open-closed-principle)
  - [LSP — Liskov Substitution Principle](#lsp--liskov-substitution-principle)
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
  A -->

