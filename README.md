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
      <a href="#sobre-el-proyecto">Sobre el proyecto 馃捇馃摮</a>
       <ul>
           <li><a href="#integrantes">Miembros que conforman el equipo de trabajo</a></li>
        </ul>
   </li>
    <li>
      <a href="#modulos">M贸dulos 馃洟</a>
      <ul>
        <li><a href="#inicio-de-sesi贸n">Inicio de sesi贸n </a></li>
        <li><a href="#administraci贸n-de-usuarios">Administraci贸n de usuarios</a>
        <ul>
           <li><a href="#registrar-un-nuevo-usuario">Registrar un nuevo usuario</a></li>
           <li><a href="#eliminar-un-usuario">Eliminar un usuario</a></li>
        </ul>
        </li>
        <li>
        <a href="#geolocalizaci贸n">Geolocalizaci贸n</a>
     </li>
     <li>
        <a href="#video-explicativo">Video explicativo</a>
     </li>
      <li>
       <a href="#publicaci贸n-en-una-tienda-de-aplicaciones">Publicaci贸n en una tienda de aplicaciones</a>
      </li>
      </ul>
    </li>  
  </ol>
</details>

# Sobre el proyecto

El proyecto consiste en la implementaci贸n de un sistema que permita verificar la ubicaci贸n de un grupo de ciclistas en tiempo real, en donde:
<ul>
 <li> Cada usuario podr谩 ver donde se encuentran los dem谩s ciclistas, para ello deber谩n acceder al sistema con sus credenciales</li>
 <li> El sistema cuenta con los usuarios: administrador y ciclista.<br>Algunos m贸dulos implementados est谩n restringidos dependiendo de esta clasificaci贸n</li>
 <li> Se generar谩 un nuevo enlace cada cierto periodo de tiempo correspondiente a la ubicaci贸n del ciclista</li>
 <li> La ubicaci贸n de los ciclistas se seguir谩 almacenando a pesar de que se minimice la aplicaci贸n</li>
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
 <li>Mar铆a Jos茅 Chal谩</li>
 <li>Mateo Cueva</li>
 <li>Kevin Pulupa</li>
 <li>Bryan Tandazo</li>
 <li>Marlon Tuquerres</li>
</ul>

# M贸dulos

Como parte de los m贸dulos principales del sistema se tiene: 
<ul>
    <li><a href="#inicio-de-sesi贸n">Inicio de sesi贸n </a></li>
    <li><a href="#administraci贸n-de-usuarios">Administraci贸n de usuarios</a></li>
    <li><a href="#geolocalizaci贸n">Geolocalizaci贸n</a></li>
    <li><a href="#video-explicativo">Video explicativo</a></li>
    <li><a href="#publicaci贸n-en-una-tienda-de-aplicaciones">Publicaci贸n en una tienda de aplicaciones</a></li>
</ul>

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079781/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_20.03.36_xg8ykx.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

## Inicio de sesi贸n

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079141/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.46.57_g6yghv.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

Para el m贸dulo de inicio de sesi贸n, tanto en las configuraciones de Firebase como en el c贸digo respectivo para este m贸dulo, se estableci贸 la autenticaci贸n del usuario a trav茅s del correo electr贸nico y la contrase帽a. 

![image](https://user-images.githubusercontent.com/74751902/223043261-b3ec0dd5-51cb-4d64-97f0-2fd858a0b362.png)

## Administraci贸n de usuarios

Como parte del m贸dulo para la administraci贸n de usuarios se tienen los subm贸dulos para: 

<ol>
   <ul>
       <li><a href="#registrar-un-nuevo-usuario">Registrar un nuevo usuario</a></li>
       <li><a href="#eliminar-un-usuario">Eliminar un usuario</a></li>
   </ul>
</ol>

### Registrar un nuevo usuario

Como parte de la l贸gica implementada para este subm贸dulo, se estableci贸 煤nicamente el usuario administrador pueda acceder al mismo, para ello, en el archivo LocalizationPage.xaml, correspondiente a la p谩gina principal se a帽adi贸 esta restricci贸n.

![image](https://user-images.githubusercontent.com/74751902/223043127-78c0e1e6-3482-4c2c-a965-aa11c39bb03f.png)


Una vez dentro de este, el administrador debe completar los campos que se muestran en la im谩gen.

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079691/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_00.04.21_hua8ht.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

Luego dentro del listado de los usuarios se mostrar谩 la informaci贸n registrada. 

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079142/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.47.38_twzula.jpg" alt="modulos" width="300" height="500">
    </a>
    <br>
 </p>

鉂椻潡Importante: Cuando un usuario ciclista hace clic en el m贸dulo para <a href="#registrar-un-nuevo-usuario">"Registrar un nuevo usuario"</a>, se le presenta la siguiente alerta: 

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079141/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_17.12.51_ypub4q.jpg" width="300" height="500">
    </a>
    <br>
 </p>

### Eliminar un usuario

Dentro del m贸dulo para eliminar un usuario, el administrador podr谩 visualizar la lista de los usuarios registrados 

<p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678082256/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_19.44.11_vqx8kf.jpg" alt="lista eliminar" width="300" height="500">
        <br>
    </a>
    <br>
 </p>

En caso de que el usuario ciclista quiera acceder a este m贸dulo, se presentar谩 el mensaje que se muestra a continuaci贸n.
 
 <p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079141/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_17.12.51_ypub4q.jpg" alt="alerta eliminar" width="300" height="500">
    </a>
    <br>
 </p>

## Geolocalizaci贸n

Como parte de la geolocalizaci贸n, dentro del archivo CiclistaDetailsPage.xaml.cs se implemento la l贸gica para que una vez que el usuario otorgue los permisos a la aplicaci贸n para acceder a su ubicaci贸n, esta guardar谩 las coordenadas en donde se encuentra dicho usuario cada 5-10 segundos aproximadamente.

![image](https://user-images.githubusercontent.com/74751902/223042341-ea35b6ba-0053-43ed-9bf2-8ea9c55f2cbc.png)

Los usuarios registrados podr谩n visualizar cada una de las ubicaciones obtenidas a trav茅s de la aplicaci贸n seleccionando de la lista el usuario del cual quieren saber su ubicaci贸n 

 <p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079142/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.47.49_hcmi13.jpg" alt="alerta eliminar" width="300" height="500">
    </a>
    <br>
 </p>
 
Finalmente se debe seleccionar las coordenadas para visualizar la ubicaci贸n en el mapa

 <p align="center">
    <a>
        <img src="https://res.cloudinary.com/dm0qsdpr8/image/upload/v1678079142/moviles%20proyecto%20final/WhatsApp_Image_2023-03-05_at_10.47.59_obj3dx.jpg" width="300" height="500">
    </a>
    <br>
 </p>

## Video explicativo
 
A continuaci贸n se presenta un video explicativo tanto del funcionamiento como la implementaci贸n del c贸digo.

<p align="center"><a href="https://youtu.be/VkCsqOcxMdo" target="_blank"><strong>Aplicaci贸n M贸vil: RutaCiclista</strong></a></p>

## Publicaci贸n en una tienda de aplicaciones

Finalmente, para la publicaci贸n de nuestra aplicacion hemos utilizado la tienda de aplicaciones llamada "Aptoide" la cual nos permite descargar y subir aplicaciones. Como primer paso descargamos la aplicacion, nos registramos y creamos una tienda.
<br>
<br>
![image](https://user-images.githubusercontent.com/66330281/223039321-330bfdee-5d38-4316-bc8c-72aa67e0922f.png)
![image](https://user-images.githubusercontent.com/66330281/223039389-97a4b2fc-4cb1-4b7a-baa6-897542b336f6.png)
<br>
<br>
Para subir una aplicacion necesitamos la app llamada "Aptoide Uploader", nos registramos con la cuenta que creamos anteriormente. Una vez realizado buscamos nuestra aplicacion y seleccionamos en "Enviar apps". Una vez completado nos mostrara un mensaje de confirmacion. 
<br>
<br>
![image](https://user-images.githubusercontent.com/66330281/223037717-7a10e117-290e-42b1-9176-4ae4d1d0f9d1.png)
![image](https://user-images.githubusercontent.com/66330281/223037933-305d56a6-200d-495b-b3b5-cc4212410a81.png)
<br>
<br>
Una vez dentro de la aplicacion "Aptoide" nos dirigimos a la opcion "Tiendas" (Stores) y clicleamos en "Seguir tienda" (Follow store) 
<br>
<br>
![image](https://user-images.githubusercontent.com/66330281/223281384-7e7b34cc-7f04-43fc-9cce-c73b1c129d3c.png)
![image](https://user-images.githubusercontent.com/66330281/223281431-83210350-e381-4508-a231-b2c2b567cf3d.png)
<br>
<br>
Y buscamos nuestra tienda llamada "tuappcenter" y damos clic en "Seguir" (Follow) y apacera nuestra tienda tuappcenter como se muestra en la imagen
<br>
<br>
![image](https://user-images.githubusercontent.com/66330281/223281680-db363f61-bf02-432a-a7f6-e4699e84dee6.png)
![image](https://user-images.githubusercontent.com/66330281/223281699-33bb6335-706c-46c0-83f5-62a6e258ec80.png)
<br>
<br>
Si nos dirigimos a nuestra tienda nos podemos dar cuenta que nuestra aplicacion se encuentra ahi
<br>
<br>
![image](https://user-images.githubusercontent.com/66330281/223038993-d997b333-9239-4428-ae31-a070b39fb395.png)
![image](https://user-images.githubusercontent.com/66330281/223039138-ab30368d-80aa-4b98-9079-f138ad72f050.png)
<br>









