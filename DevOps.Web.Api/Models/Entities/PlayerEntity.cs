using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOps.Web.Api.Models.Entities
{
    // Definición de atributos para un “Player”:
    // Name: string
    // Last name: string
    // Birthday: int
    // La visualización del atributo birthday debe ser en formato dd/mm/yyyy)

    public class PlayerEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Birthday { get; set; }
    }
}