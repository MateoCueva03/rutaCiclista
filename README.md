 <h1 align="center"><b>LA RUTA DEL CICLISTA</b></h1>
 <br>
 
 
 <p align="center">
    <a>
        <img src="https://cdn-icons-png.flaticon.com/512/625/625387.png" alt="Logo" width="150" height="130">
        <br>
      <b>RutaCiclista</b>
    </a>
    <br>
 </p>
 
 <!-- TABLA DE CONTENIDO -->
<details>
    <summary><b>Contenido</b></summary>
    <br>
  <ol>
      <li>
      <a href="#sobre-el-proyecto">Sobre el proyecto 💻📳</a>
       <ul>
           <li><a href="#integrantes">Miembros que conforman el equipo de trabajo</a></li>
        </ul>
   </li>
    <li>
      <a href="#modulos">Módulos 🛢</a>
      <ul>
        <li><a href="#inicio-de-sesión">Inicio de sesión </a></li>
        <li><a href="#administración-de-usuarios">Administración de usuarios</a>
        <ul>
           <li><a href="#registrar-un-nuevo-usuario">Registrar un nuevo usuario</a></li>
           <li><a href="#eliminar-un-usuario">Eliminar un usuario</a></li>
        </ul>
        </li>
        <li>
        <a href="#geolocalización">Geolocalización</a>
     </li>
     <li>
        <a href="#acceso-a-la-aplicación">Acceso a la aplicación</a>
     </li>
     <li>
        <a href="#video-explicativo">Video explicativo</a>
     </li>
      </ul>
    </li>  
  </ol>
</details>

# Sobre el proyecto

El proyecto consiste en la implementación de un sistema que permita verificar la ubicación de un grupo de ciclistas en tiempo real, en donde:
<ul>
 <li> Cada usuario podrá ver donde se encuentran los demás ciclistas, para ello deberán acceder al sistema con sus credenciales</li>
 <li> El sistema cuenta con los usuarios: administrador y ciclista.<br>Algunos módulos implementados están restringidos dependiendo de esta clasificación</li>
 <li> Se generará un nuevo enlace cada cierto periodo de tiempo correspondiente a la ubicación del ciclista</li>
 <li> La ubicación de los ciclistas se seguirá almacenando a pesar de que se minimice la aplicación</li>
</ul>

Este proyecto fue creado con Xamarin.

### Integrantes: 

<p align="center">
    <a>
        <img src="https://cdn-icons-png.flaticon.com/512/1376/1376510.png" alt="integrantes" width="150" height="130">
        <br>
    </a>
    <br>
 </p>

Los integrantes que conforman el equipo de trabajo son: 

<ul>
 <li>María José Chalá</li>
 <li>Mateo Cueva</li>
 <li>Kevin Pulupa</li>
 <li>Bryan Tandazo</li>
 <li>Marlon Tuquerres</li>
</ul>

# Módulos

Como parte de los módulos principales del sistema se tiene: 
<ul>
    <li><a href="#inicio-de-sesión">Inicio de sesión </a></li>
    <li><a href="#administración-de-usuarios">Administración de usuarios</a></li>
    <li><a href="#geolocalización">Geolocalización</a></li>
    <li><a href="#acceso-a-la-aplicación">Acceso a la aplicación</a></li>
    <li><a href="#video-explicativo">Video explicativo</a></li>
</ul>

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079781/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_20.03.36_xg8ykx.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

## Inicio de sesión

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079141/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.46.57_g6yghv.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

Para el módulo de inicio de sesión, tanto en las configuraciones de Firebase como en el código respectivo para este módulo, se estableció la autenticación del usuario a través del correo electrónico y la contraseña. 

<p align="center">
    <a>
        <img src="https://cdn-icons-png.flaticon.com/512/625/625387.png" alt="codigo inicio de sesión" width="100" height="80">
        <br>
      <b>RutaCiclista</b>
    </a>
    <br>
 </p>

## Administración de usuarios

Como parte del módulo para la administración de usuarios se tienen los submódulos para: 

<ol>
   <ul>
       <li><a href="#registrar-un-nuevo-usuario">Registrar un nuevo usuario</a></li>
       <li><a href="#eliminar-un-usuario">Eliminar un usuario</a></li>
   </ul>
</ol>

### Registrar un nuevo usuario

Como parte de la lógica implementada para este submódulo, se estableció únicamente el usuario administrador pueda acceder al mismo, para ello, dentro del archivo ..., se añadió esta restricción.

Una vez dentro de este, el administrador debe completar los campos que se muestran en la imágen.

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079691/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_00.04.21_hua8ht.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

Luego dentro del listado de los usuarios se mostrará la información registrada. 

Importante❗❗: Cuando un usuario ciclista hace clic en el módulo para <a href="#registrar-un-nuevo-usuario">"Registrar un nuevo usuario"</a>, se le presenta la siguiente alerta: 

<p align="center">
    <a>
        <img src="https://cdn-icons-png.flaticon.com/512/625/625387.png" alt="alerta registro" width="100" height="80">
        <br>
      <b>RutaCiclista</b>
    </a>
    <br>
 </p>


### Eliminar un usuario

Dentro del módulo para eliminar un usuario, el administrador podrá visuualizar la lista de los usuarios registrados 

<p align="center">
    <a>
        <img src="https://cdn-icons-png.flaticon.com/512/625/625387.png" alt="lista eliminar" width="100" height="80">
        <br>
    </a>
    <br>
 </p>

En caso de que el usuario ciclista quiera acceder a este módulo, se presentará el mensaje que se muestra a continuación.
 
 <p align="center">
    <a>
        <img src="https://cdn-icons-png.flaticon.com/512/625/625387.png" alt="alerta eliminar" width="100" height="80">
        <br>
      <b>RutaCiclista</b>
    </a>
    <br>
 </p>

## Geolocalización

Como parte de la geolocalización, dentro del archivo ..., se implemento la lógica para que el usuario, una vez que  

## Video explicativo
 
A continuación se presenta un video explicativo tanto del funcionamiento como la implementación del código.

## Acceso a la aplicación


