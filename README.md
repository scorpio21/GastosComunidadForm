# GastosComunidadForm

## Descripción

**GastosComunidadForm** es una aplicación de escritorio desarrollada en Visual Basic .NET (VB.NET) que permite gestionar y controlar las deudas y gastos de una comunidad, como "Casa" y "Garaje". La aplicación se conecta a una base de datos MySQL llamada `gastos_db` para almacenar los registros de los gastos y las deudas.

## Funcionalidades

- **Registrar Gasto**: Permite agregar un gasto con una descripción, monto y fecha.
- **Registrar Deuda**: Puedes registrar deudas relacionadas con las comunidades.
- **Visualización**: Muestra una tabla con las deudas pendientes, incluyendo la comunidad, la fecha, el monto pagado, la deuda total y el saldo pendiente.
- **Base de Datos**: Utiliza MySQL para almacenar los datos.

## Requisitos

- **Sistema operativo**: Windows (se recomienda Windows 10 o superior).
- **Lenguaje**: Visual Basic .NET ![Visual Basic](https://img.icons8.com/color/48/000000/visual-basic.png)
- **Base de datos**: MySQL ![MySQL](https://img.icons8.com/ios/50/000000/mysql-logo.png) (con una base de datos llamada `gastos_db`).
- **Visual Studio**: Cualquier versión que soporte VB.NET ![Visual Studio](https://img.icons8.com/ios/50/000000/visual-studio.png)

## Instalación

1. Clona este repositorio en tu máquina local:

    ```bash
    git clone https://github.com/scorpio21/GastosComunidadForm.git
    ```

2. Abre el proyecto en Visual Studio.

3. Configura la base de datos MySQL (ver sección a continuación).

4. Ejecuta el proyecto y empieza a gestionar los gastos y deudas.

## Configuración de la base de datos MySQL

### Crear la base de datos

1. Abre MySQL Workbench o cualquier cliente de base de datos MySQL.
2. Ejecuta el siguiente script SQL para crear la base de datos:

    ```sql
    CREATE DATABASE gastos_db;

    USE gastos_db;

    CREATE TABLE Gastos (
        id INT AUTO_INCREMENT PRIMARY KEY,
        descripcion VARCHAR(255),
        monto DECIMAL(10, 2),
        fecha DATE
    );

    CREATE TABLE Deudas (
        id INT AUTO_INCREMENT PRIMARY KEY,
        comunidad VARCHAR(255),
        deuda DECIMAL(10, 2),
        saldo DECIMAL(10, 2),
        fecha DATE
    );
    ```

### Configuración de la conexión

En tu proyecto de Visual Basic, configura la cadena de conexión a la base de datos MySQL. Esto lo puedes hacer desde el archivo de configuración o directamente en el código fuente. La cadena de conexión debe ser similar a la siguiente:

```vb
Dim conn As New MySqlConnection("Server=localhost;Database=gastos_db;Uid=root;Pwd=tu_contraseña;")

 ```
### Ejecutar la aplicación
Abre el proyecto en Visual Studio.

Configura la base de datos como se describe arriba.

Ejecuta la aplicación, y podrás registrar gastos, ver las deudas y hacer un seguimiento del saldo pendiente.

### Contribuciones
Las contribuciones son bienvenidas. Si tienes alguna sugerencia, corrección o mejora, no dudes en abrir un pull request.

### Licencia
Este proyecto está bajo la Licencia MIT - consulta el archivo LICENSE para más detalles.

### Desarrollado por Lopera

Repositorio: https://github.com/scorpio21/GastosComunidadForm
