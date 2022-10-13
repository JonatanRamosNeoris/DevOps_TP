using DevOps.Web.Api.Models.Entities;
using DevOps.Web.Api.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOps.Web.Api.Services
{
    public class PlayerService
    {
        public PlayerService()
        {
            this.Respository = new List<PlayerEntity>();

            this.Respository.Add(new PlayerEntity() { ID = 1, Name = "Pedro", LastName = "Perez", Birthday = new DateTime(1978, 5, 24).Ticks });

            this.Respository.Add(new PlayerEntity() { ID = 2, Name = "Juan", LastName = "Gonsalez", Birthday = new DateTime(1997, 7, 12).Ticks });
        }

        public List<PlayerEntity> Respository { get; set; }

        public PlayerResponseEntity[] GetAll()
        {
            var list = this.Respository.ToArray();

            return list.Select(i =>
            new PlayerResponseEntity()
            {
                ID = i.ID.ToString(),
                Name = i.Name,
                LastName = i.LastName,
                Birthday = (new DateTime(i.Birthday)).ToString("dd/MM/yyyy")
            }).ToArray();
        }
    }
}