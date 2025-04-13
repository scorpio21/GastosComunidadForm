# GastosComunidadForm

## Descripción

**GastosComunidadForm** es una aplicación desarrollada en Visual Basic .NET (VB.NET) que permite gestionar y controlar los gastos y deudas de una comunidad, como "Casa" y "Garaje". La aplicación se conecta a una base de datos MySQL llamada `gastos_db`, donde se almacenan los registros de los gastos y las deudas, permitiendo llevar un control claro de los saldos pendientes.

## Funcionalidades

- **Registrar Gasto**: Permite agregar un gasto con una descripción, monto y fecha.
- **Registrar Deuda**: Puedes registrar deudas específicas para cada comunidad, indicando la deuda total y el saldo pendiente.
- **Visualización de Datos**: Muestra una tabla con las deudas y gastos registrados, permitiendo ver el saldo pendiente por comunidad.
- **Base de Datos**: Utiliza MySQL para almacenar de manera estructurada los datos de los gastos y las deudas.

## Requisitos

- **Sistema operativo**: Windows (se recomienda Windows 10 o superior).
- **Lenguaje**: Visual Basic .NET (VB.NET).
- **Base de Datos**: MySQL (con una base de datos llamada `gastos_db`).
- **IDE**: Visual Studio (Cualquier versión que soporte VB.NET).
- **Bibliotecas necesarias**: MySQL.Data (conector MySQL para .NET).

## Configuración de la Base de Datos MySQL

### 1. Crear la Base de Datos

Para comenzar, debes tener una instancia de MySQL en funcionamiento. Sigue estos pasos para crear la base de datos:

1. Abre **MySQL Workbench** o cualquier otro cliente de base de datos compatible con MySQL.
2. Ejecuta el siguiente script SQL para crear la base de datos `gastos_db` y las tablas necesarias:

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
=======
# GastosComunidadForm
