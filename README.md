# TP #1
Crear una API (web service) que se ejecute en su dispositivo. La API debe exponer un recurso llamado players ("/players").
Debe tener dos "jugadores" distintos pre cargados sin necesidad de usar una base de datos.
Al hacer un HTTP request mediante el méthodo GET a /players debe devolver los jugadores con formato de respuesta JSON.
Los atributos de un jugador son los siguientes:
 - id: int
 - first name: string
 - last name: string
 - birthday: long (ticks)

 La visualizacion del atributo birthday debe ser en formato dd/mm/yyyy

## Requisitos
 - .Net Framework >= 4.6.
 - Newtonsoft.Json >= 12.0.2
 - Microsoft.AspNet.WebApi.Core >= 5.2.9
 - Microsoft.AspNet.WebApi.WebHost >= 5.2.9

Abrir la url http://localhost:8081/api/Players para visualizar el resultado