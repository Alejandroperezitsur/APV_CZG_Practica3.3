# 🛡️ Proyecto de Login y Mensajes Conectado a Base de Datos 🛡️

<p align="center">
  <img src="[https://www.tecnm.mx/images/logos/tecnm_logo.png](https://iztapalapa3.tecnm.mx/departamentos/planeacion/comuydif/LOGO-VERTICAL.png)" alt="TECNM Logo" width="200"/>
  &nbsp;&nbsp;&nbsp;&nbsp;
</p>

## 📜 Descripción

Este proyecto es un sistema de login y registro de usuarios, conectado a una base de datos. Los usuarios pueden registrarse, y sus datos (nombre, apellidos, usuario y contraseña) se guardan de manera segura en la base de datos utilizando **hash** para proteger las contraseñas. Además, el sistema permite crear y almacenar mensajes, los cuales también se guardan en una tabla dentro de la base de datos.

## 🔑 Características

- **Registro de usuarios**: Los usuarios pueden registrarse proporcionando su nombre, apellidos, nombre de usuario y contraseña.
- **Contraseña segura**: Se utiliza hashing para asegurar que las contraseñas no sean almacenadas en texto plano.
- **Login seguro**: Inicia sesión utilizando el nombre de usuario y la contraseña previamente registrados.
- **Mensajes**: Los usuarios pueden crear mensajes, los cuales se guardan en la base de datos.
- **Base de datos**: Todos los datos de usuarios y mensajes se almacenan en una base de datos SQL.

## ⚙️ Instalación

1. Clona este repositorio:
    ```bash
    git clone https://github.com/tu_usuario/login-db-mensajes.git
    ```
2. Instala las dependencias:
    ```bash
    pip install -r requirements.txt
    ```
3. Configura tu base de datos en el archivo `config.py`.

4. Ejecuta el proyecto:
    ```bash
    python app.py
    ```

## 🖼️ Capturas de Pantalla

<p align="center">
  <img src="ruta/a/tu_captura1.png" alt="Pantalla de login" width="400"/>
  &nbsp;&nbsp;&nbsp;&nbsp;
  <img src="ruta/a/tu_captura2.png" alt="Pantalla de registro" width="400"/>
</p>

## 🚀 Tecnologías Utilizadas

- **Python**: Lenguaje de programación principal.
- **Flask**: Framework web ligero.
- **SQLAlchemy**: ORM para manejar la base de datos.
- **MySQL/PostgreSQL/SQLite**: Dependiendo de tu configuración de base de datos.

## 🛠️ Herramientas de Seguridad

- **Hashing de contraseñas**: Se utiliza `bcrypt` para proteger las contraseñas.
- **Autenticación segura**: Login con validación de credenciales hashadas.

## 🗂️ Estructura del Proyecto

```bash
📦 APV_CZG_Practica 3.3
📲 Conéctate Conmigo
<p align="center"> <a href="https://facebook.com/elcaleb10"> <img src="https://img.icons8.com/fluent/48/000000/facebook-new.png"/> </a> <a href="https://instagram.com/elcaleb10"> <img src="https://img.icons8.com/fluent/48/000000/instagram-new.png"/> </a> </p>
<p align="center">Hecho con 💻 y ☕ por <strong>@elcaleb10</strong></p> ```
