using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OwnerRegistration.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OwnerRegistration.Controller
{
    [Route("api/[Controller]")]
    [ApiController]
    public class OwnerRetrieveController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Owner> GetAllOwners()
        {
            return OwnRegistration.getInstance().getAllOwner();
        }
        [HttpGet("GetAllOwnerRecords")]
        public JsonResult GetAllOwnerRecords()
        {
            return Json(OwnRegistration.getInstance().getAllOwner());
        }

        private JsonResult Json(List<Owner> list)
        {
            throw new NotImplementedException();
        }
    }
}
