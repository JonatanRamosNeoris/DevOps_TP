using DevOps.Web.Api.Models.Entities;
using DevOps.Web.Api.Models.Responses;
using DevOps.Web.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DevOps.Web.Api.Controllers
{
    public class PlayersController : ApiController
    {
        public PlayersController() : base()
        {

        }

        protected PlayerService service = null;

        protected PlayerService Service
        {
            get
            {
                if (this.service == null)
                    this.service = new PlayerService();
                return this.service;
            }
        }

        [Route("api/Players")]
        public IHttpActionResult Get()
        {
            try {
                return Ok<PlayerResponseEntity[]>(this.Service.GetAll());
            }
            catch (Exception ex)
            {
                return Ok<string>(ex.Message);
            }            
        }
    }
}