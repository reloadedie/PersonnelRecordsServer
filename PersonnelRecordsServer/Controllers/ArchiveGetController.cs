using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelApi;
using PersonnelRecordsServer.db;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchiveGetController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public ArchiveGetController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET api/<ArchiveController>/5
        [HttpPost]
        public async Task<ActionResult<WorkerExp>> Post([FromBody] WorkerExpGetDates dates)
        {
            //var worker = dbContext.Workers.FirstOrDefault(s => s.Id == dates.Worker.Id);
            //if (worker == null)
            //    return NotFound();
            var result = new WorkerExp();
            //var expList = dbContext.Archives.
            //    Where(s=>s.WorkerId == worker.Id).
            //    Include(s=>s.StaffingID).
            //    Where(s=>s.StaffingID.Position == dates.Postion).
            //    Include(s => s.staffingID.Company).
            //    OrderBy(s=>s.MakedDate).
            //    ToList();
            result.Worker = dates.Worker;
            //foreach (var exp in expList)
            //{
            //    var row = new WorkerCompanyExp { 
            //        Company = (CompanyApi)exp.Staffing.Company,
            //        Start = exp.DateStart,
            //        End = exp.DateEnd
            //    };
            //    result.History.Add(row);
            //}
            return Ok(result);
        }
    }
}
