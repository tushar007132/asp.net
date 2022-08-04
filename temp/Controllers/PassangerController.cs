using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PassangerManagmentServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassangerController : ControllerBase
    {
        // GET: api/<PassangerController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public IEnumerable<PassangerModel> Get()
        {
            PassangerModel psg1 = new PassangerModel();
            PassangerModel psg2 = new PassangerModel();

            psg1.PassangerId = 101;
            psg1.PassangerName = "Tushar";


            psg1.PassangerId = 102;
            psg1.PassangerName = "Akash";

            List<PassangerModel> psglist = new List<PassangerModel>();
            psglist.Add(psg1);
            psglist.Add(psg2);
            return psglist;
        }


        // GET api/<PassangerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PassangerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PassangerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PassangerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
