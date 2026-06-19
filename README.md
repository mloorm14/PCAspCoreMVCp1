# GA - Práctica en Clase: Proyecto ASP.NET Core MVC

Este repositorio contiene la implementación de una aplicación web funcional utilizando el patrón arquitectónico **Modelo-Vista-Controlador (MVC)** sobre el framework **ASP.NET Core 8**. El proyecto fue desarrollado como práctica formativa para comprender el procesamiento de formularios del lado del servidor.

## 🚀 Características y Conceptos Aplicados

* **Arquitectura MVC:** Separación estricta de responsabilidades entre Modelos, Vistas y Controladores.
* **Data Annotations:** Validación declarativa de datos directamente en el modelo `Producto` utilizando atributos como `[Required]`, `[StringLength]`, `[Range]` y `[DataType]`.
* **Validación Server-Side:** Manejo y verificación de la integridad de los datos en el controlador a través de `ModelState.IsValid`.
* **Seguridad CSRF:** Implementación del patrón Synchronizer Token utilizando el Tag Helper `asp-antiforgery="true"` y el atributo `[ValidateAntiForgeryToken]`.
* **Mitigación XSS:** Demostración del escape automático de caracteres peligrosos manejado nativamente por el motor Razor.
* **Patrón PRG (Post/Redirect/Get):** Prevención del reenvío accidental de formularios utilizando `TempData` para notificaciones.

## 🛠️ Tecnologías Utilizadas

* C# 12
* .NET 8 SDK
* ASP.NET Core MVC
* Motor de Vistas Razor
* HTML5 / Bootstrap 5 (UI y validación reactiva en cliente)

## ⚙️ Instrucciones de Ejecución

Para correr este proyecto localmente, asegúrate de tener instalado el [SDK de .NET 8](https://dotnet.microsoft.com/download/dotnet/8.0).

1. Clona el repositorio:
   ```bash
   git clone https://github.com/mloorm14/PCAspCoreMVCp1.git
   ```

2. Navega al directorio del proyecto:
   ```bash
   cd PCAspCoreMVCp1/MiPrimerMVC
   ```

3. Compila y ejecuta la aplicación:
   ```bash
   dotnet run
   ```

4. Abre tu navegador y accede a la URL indicada en la terminal (por defecto: https://localhost:5069).

## 👨‍💻 Autor

**Loor Medranda Marlon Taylor**

* **Asignatura:** Aplicaciones Web | SOFT-R-A
* **Nivel:** 5to Nivel - Ingeniería en Software
* **Institución:** Universidad Técnica Estatal de Quevedo (UTEQ)
* **Período:** 2026 - Corte 1
