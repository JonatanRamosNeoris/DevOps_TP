# TP #2
A partir del TP anterior, dockerizar la API desarrollada y almacenar los jugadores en una base de datos.
Los contenedores tienen que tener una única responsabilidad por lo cual uno tiene que actuar de aplicación y el otro de ejecutar la instancia de la base de datos. El puerto de acceso desde la máquina host tiene que el 8081. Es decir se tiene que poder acceder através de http://localhost:8081/players.
Además tienen que agregar un test unitario que pueda ejecutarse por la terminal de comandos

## Requisitos
 - Docker y docker-compose
 - .Net Framework >= 4.8.
 - Newtonsoft.Json >= 13.0.1
 - Microsoft.AspNet.WebApi.Core >= 5.2.9
 - Microsoft.AspNet.WebApi.WebHost >= 5.2.9
 - Microsoft.AspNet.WebApi.Client >=5.2.9
 - System.Data.SqlClient >= 4.8.4
 - MSBuild.Microsoft.VisualStudio.Web_WebApplication.Targets >= 12.0.2

### Instalación y ejecución
```
docker-compose build
docker-compose up -d
```

Abrir la url http://localhost:8081/players para visualizar el resultado