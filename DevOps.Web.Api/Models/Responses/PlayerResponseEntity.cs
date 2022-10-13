using DevOps.Web.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOps.Web.Api.Models.Responses
{
    public class PlayerResponseEntity
    {
        public PlayerResponseEntity()
        {
            
        }

        public string ID { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Birthday { get; set; }
    }
}