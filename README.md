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
        <img src="https://cdn-icons-png.flaticon.com/512/625/625387.png" alt="codigo inicio de sesión" width="300" height="500">
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

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079142/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.47.38_twzula.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

❗❗Importante: Cuando un usuario ciclista hace clic en el módulo para <a href="#registrar-un-nuevo-usuario">"Registrar un nuevo usuario"</a>, se le presenta la siguiente alerta: 

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079141/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_17.12.51_ypub4q.jpg" width="300" height="500">
    </a>
    <br>
 </p>

### Eliminar un usuario

Dentro del módulo para eliminar un usuario, el administrador podrá visualizar la lista de los usuarios registrados 

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678082256/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_19.44.11_vqx8kf.jpg" alt="lista eliminar" width="300" height="500">
        <br>
    </a>
    <br>
 </p>

En caso de que el usuario ciclista quiera acceder a este módulo, se presentará el mensaje que se muestra a continuación.
 
 <p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079141/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_17.12.51_ypub4q.jpg" alt="alerta eliminar" width="300" height="500">
    </a>
    <br>
 </p>

## Geolocalización

Como parte de la geolocalización, dentro del archivo ..., se implemento la lógica para que una vez que el usuario otorgue los permisos a la aplicación para acceder a su ubicación, esta guardará las coordenadas en donde se encuentra dicho usuario cada 5-10 segundos aproximadamente.

 <p align="center">
    <a>
        <img src="https://cdn-icons-png.flaticon.com/512/625/625387.png" alt="alerta eliminar" width="300" height="500">
        <br>
      <b>RutaCiclista</b>
    </a>
    <br>
 </p>

Los usuarios registrados podrán visualizar cada una de las ubicaciones obtenidas a través de la aplicación seleccionando de la lista el usuario del cual quieren saber su ubicación 

 <p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079142/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.47.49_hcmi13.jpg" alt="alerta eliminar" width="300" height="500">
    </a>
    <br>
 </p>
 
Finalmente se debe seleccionar las coordenadas para visualizar la ubicación en el mapa

 <p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079142/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.47.59_obj3dx.jpg" width="300" height="500">
    </a>
    <br>
 </p>

## Video explicativo
 
A continuación se presenta un video explicativo tanto del funcionamiento como la implementación del código.

## Publicación en una tienda de aplicaciones

Finalmente, para la publicación de nuestra aplicacion hemos utilizado la tienda de aplicaciones llamada "Aptoide" la cual nos permite descargar y subir aplicaciones. Como primer paso descargamos la aplicacion, nos registramos y creamos una tienda.
<br>
![image](https://user-images.githubusercontent.com/66330281/223036172-ef2c5aa4-79b7-41de-b266-f81895f58ba7.png)
![image](https://user-images.githubusercontent.com/66330281/223036684-dcec3491-c4d3-499a-aeb7-fd97e575576e.png)
<br>
Para subir una aplicacion necesitamos la app llamada "Aptoide Uploader", nos registramos con la cuenta que creamos anteriormente. Una vez realizado buscamos nuestra aplicacion y seleccionamos en "Enviar apps". Una vez completado nos mostrara un mensaje de confirmacion. 
<br>
![image](https://user-images.githubusercontent.com/66330281/223037626-509d5395-0c84-4712-a0b0-2f3ac9eba782.png)
![image](https://user-images.githubusercontent.com/66330281/223037717-7a10e117-290e-42b1-9176-4ae4d1d0f9d1.png)
![image](https://user-images.githubusercontent.com/66330281/223037933-305d56a6-200d-495b-b3b5-cc4212410a81.png)
<br>
Si nos dirigimos a nuestra tienda nos podemos dar cuenta que nuestra aplicacion se encuentra ahi
![image](https://user-images.githubusercontent.com/66330281/223038347-13f06aec-849d-4534-9e76-2122abbe2eba.png)
![image](https://user-images.githubusercontent.com/66330281/223038415-990383a6-d79b-4fb8-9e2e-73b6952a33e8.png)
<br>









