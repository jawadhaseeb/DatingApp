using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{//http://localhost:5000/api/values
     [Route("api/[controller]")]
     [ApiController]
   
    public class ValuesController:ControllerBase

    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context=context;
        }
        //get api/value
        [HttpGet]
         public async Task <IActionResult> GetValues()
         {
            //  throw new Exception("Test Exception");
             var values = await _context.Value.ToListAsync();
             return Ok(values);
         }
        //get api/values/5
        [HttpGet("{id}")]

        public async Task <IActionResult> GetValue(int id)
        {
                var value =await _context.Value.FirstOrDefaultAsync(x=>x.Id==id);

                return Ok(value);
        }

        //post api/values 
        [HttpPost]
        public void Post([FromBody] string value){

        }
        //put api/values/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody]string value){

        }
        //delete api/values/5
        public void Delete(int id){

        }
    }
}











