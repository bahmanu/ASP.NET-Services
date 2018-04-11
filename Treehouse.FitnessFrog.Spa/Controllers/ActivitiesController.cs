using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class ActivitiesController : ApiController
    {
        private ActivitiesRepository _activitiesRespository = null;

        public ActivitiesController(ActivitiesRepository activitiesRepository)
        {
            _activitiesRespository = activitiesRepository;
        }

        public IHttpActionResult Get()
        {
            return Ok(_activitiesRespository.GetList());
        }
    }
}