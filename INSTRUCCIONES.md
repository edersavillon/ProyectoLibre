# ProyectoLibre
Proyecto CRUD para aplicacion de trabajo como developer en CRC Solutions

1.Se utilizo ASP.NET CORE MVC WEB APP 5 en Visual Studio para crear proyecto CRUD, es una aplicacion web de modelo, vista y controlador de escritura, lectura, eliminacion y actualizacion de datos.
2.Como base de datos se utilizo SQL SERVER MANAGEMENT y se hizo una base de datos llamado "ProyectoLibre" con una tabla "Clientes".
3.Es capaz de conectarse a un API, pero solamente a un API local no a una externa ya que se encontro con un problema de deserealizaion en JSON marcando un error que no era posible
hacer dicha serealizacion, esto puedser por la version del paquete o del .NET Framework como tal.

Para ejecutar el programa:
Abrir el archivo "ProyectoLibre.sln" en Visual Studio, luego en la barra superior presionar el boton "IIS Express" y luego la aplicacion se ejecutara.

Para ver el comportamiento de la API:
Dentro de la solucion en la barra derecha "Solution Explorer" ir a la carpeta "Properties" y se desplegara un archivo llamado "launchSettings.json", dentro del archivo ir a la
seccion "IIS EXPRESS" y descomentar la linea de codigo "launchUrl:"api/ClientesAPI".
