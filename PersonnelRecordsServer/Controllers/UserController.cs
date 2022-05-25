using Microsoft.AspNetCore.Mvc;
using ModelApi;
using PersonnelRecordsServer.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PersonnelRecordsServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
       
        public class UserController : ControllerBase
        {
            private readonly PersonnelRecordsContext dbContext;

            public UserController(PersonnelRecordsContext dbContext)
            {
                this.dbContext = dbContext;
            }

            // GET: api/<CompanyController>
            //[HttpGet]
            //public IEnumerable<CompanyApi> Get()
            //{
            //    return dbContext.Companies.Select(s => (CompanyApi)s);
            //    //return dbContext.Workers.Select(s => (WorkerApi)s);
            //}
            [HttpGet]
            public IEnumerable<UserApi> Get()
            {

                return dbContext.Users.Select(s => (UserApi)s); ;
                //return dbContext.Companies.Where(s => s.IsRemuved != 1).Select(s => (CompanyApi)s);
            }           


            // GET api/<CompanyController>/5
            [HttpGet("{id}")]
            public async Task<ActionResult<UserApi>> Get(int id)
            {
                var user = await dbContext.Users.FindAsync(id);
                if (user == null)
                    return NotFound();
                return Ok(user);
            }


            // POST api/<CompanyController>
            [HttpPost]
            public async Task<ActionResult<int>> Post([FromBody] UserApi value)
            {
                var newuser = (User)value;
                dbContext.Users.Add(newuser);
                await dbContext.SaveChangesAsync();
                return Ok(newuser.Id);
            }


            // PUT api/<CompanyController>/5
            [HttpPut("{id}")]
            public async Task<ActionResult> Put(int id, [FromBody] UserApi value)
            {
                var oldUser = await dbContext.Users.FindAsync(id);
                if (oldUser == null)
                    return NotFound();
                dbContext.Entry(oldUser).CurrentValues.SetValues(value);
                await dbContext.SaveChangesAsync();
                return Ok();
            }


            // DELETE api/<CompanyController>/5
            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(int id)
            {
                var oldUser = await dbContext.Users.FindAsync(id);
                if (oldUser == null)
                    return NotFound();
                dbContext.Users.Remove(oldUser);
                await dbContext.SaveChangesAsync();
                return Ok();
            }
        }
    }

