using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DriverManagmentServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        // GET: api/<DriverController>
        [HttpGet]
       

        public IEnumerable<DriverModel> Get()
        {
            DriverModel dr1 = new DriverModel();
            DriverModel dr2 = new DriverModel();

            dr1.DriverId = 101;
            dr1.DriverName = "Raju";

            dr2.DriverId = 102;
            dr2.DriverName = "Rajesh";


            List<DriverModel> drlist = new List<DriverModel>();
            drlist.Add(dr1);
            drlist.Add(dr2);
            return drlist;
        }



        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriverController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
