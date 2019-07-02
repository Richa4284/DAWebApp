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
    public class OwnerRegistrationController : ControllerBase
    {
        // POST: api/<controller>
        [HttpPost]
        public OwnerRegistrationReply RegisterOwner(Owner Ownerregd)
        {
            Console.WriteLine("In registerOwner");
            OwnerRegistrationReply Ownerregreply = new OwnerRegistrationReply();
            OwnRegistration.getInstance().Add(Ownerregd);
            Ownerregreply.Name = Ownerregd.Name;
            Ownerregreply.Age = Ownerregd.Age;
            Ownerregreply.RegistrationNumber = Ownerregd.RegistrationNumber;
            Ownerregreply.RegistrationStatus = "Successful";
            return Ownerregreply;
        }
        [HttpPost("InsertOwner")]
        public IActionResult InsertOwner(Owner Ownerregd)
        {
            Console.WriteLine("In registerOwner");
            OwnerRegistrationReply Ownerregreply = new OwnerRegistrationReply();
            OwnRegistration.getInstance().Add(Ownerregd);
            Ownerregreply.Name = Ownerregd.Name;
            Ownerregreply.Age = Ownerregd.Age;
            Ownerregreply.RegistrationNumber = Ownerregd.RegistrationNumber;
            Ownerregreply.RegistrationStatus = "Successful";
            return Ok(Ownerregreply);
        }

        [HttpGet("GetDemo")]
        public IActionResult DemoGetting()
            {
            return null;
            }
        [Route("Owner/")]
        [HttpPost("AddOwner")]
        public JsonResult AddOwner(Owner Ownerregd)
        {
            Console.WriteLine("In registerOwner");
            OwnerRegistrationReply Ownerregreply = new OwnerRegistrationReply();
            OwnRegistration.getInstance().Add(Ownerregd);
            Ownerregreply.Name = Ownerregd.Name;
            Ownerregreply.Age = Ownerregd.Age;
            Ownerregreply.RegistrationNumber = Ownerregd.RegistrationNumber;
            Ownerregreply.RegistrationStatus = "Successful";
            return JsonResult(Ownerregreply);
        }

        private JsonResult JsonResult(OwnerRegistrationReply Ownerregreply)
        {
            throw new NotImplementedException();
        }
    }
}
