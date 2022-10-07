using DevOps.Web.Api.Models.Entities;
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

            this.Respository.Add(new PlayerEntity() { Name = "Pedro", LastName = "Perez", Birthday = 1 });

            this.Respository.Add(new PlayerEntity() { Name = "Juan", LastName = "Gonsalez", Birthday = 1 });
        }

        public List<PlayerEntity> Respository { get; set; }

        public PlayerEntity[] GetAll()
        {
            return this.Respository.ToArray();
        }
    }
}