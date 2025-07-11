# Tour Reservations API

API desarrollada en ASP.NET Core para gestionar reservas de tours, con validación de reglas de negocio y arquitectura limpia (DDD + CQRS).

## DESARROLLADO POR:

Diego Seijas Vasquez
GitHub: @NotSeijas
https://www.linkedin.com/in/diego-antonio-seijas-vasquez-a798a9303/

## 📖 Descripción

Esta API permite a los turistas reservar tours, asegurando que se cumplan las reglas de negocio establecidas. Utiliza una arquitectura basada en DDD y CQRS para una mejor organización del código y separación de responsabilidades.

## 🚀 Tecnologías

- ASP.NET Core Web API
- C#
- Arquitectura DDD + CQRS
- REST Client (pruebas locales)
- GitHub para versionado

---

## 📌 Requisitos de Negocio

1. El tour **"inca-trail"** solo está disponible entre **marzo y octubre**.
2. Turistas mayores de **65 años con condición física "low"** no pueden reservar tours exigentes.
3. Turistas de nacionalidad **USA** deben reservar con al menos **30 días de anticipación**.

---

## 📦 Cómo ejecutar

```bash
dotnet run
```
