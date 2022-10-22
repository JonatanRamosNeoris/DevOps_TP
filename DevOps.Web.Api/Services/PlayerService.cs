using DevOps.Web.Api.Adapters;
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
            this.adapter = new SqlAdapter();

            this.Respository = this.adapter.ReadAll();
        }

        protected SqlAdapter adapter = null;

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