using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sample1.Models;


namespace sample1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaskChaskaController : ControllerBase
    {
        public SqliteDDFC db { get; set; }
        public ISingleTonUtility sin ;
        public IScopedTonUtility sco;
        public ITransientUtility tra;

        public MaskChaskaController(SqliteDDFC db, ISingleTonUtility sin, IScopedTonUtility sco, ITransientUtility tra)
        {

            this.db = db;
            this.sin = sin;
            this.sco = sco;
            this.tra = tra;

        }


        [HttpGet("migrate")]
        public IActionResult Migrate()
        {
            db.Database.Migrate();
            return Ok("Db Updated");
        }


            [HttpGet("sin")]
        public IActionResult Get()
        {

            db.Database.EnsureCreated();
            db.Dept.Add(new Depts
            {
                dname = "Kiger",
                location = "Karimnagar",
                location_type = "static",
                location_id = "0101"
            });
            db.SaveChanges();

            return Ok(new
            {
                RequestInsertedCount = sin.GetTheCount(),
                data = db.Dept.OrderByDescending(t => t.deptid).ToList(),
                
            }); 
        }

        [HttpGet("sco")]
        public IActionResult Scop()
        {

            db.Database.EnsureCreated();
            db.Dept.Add(new Depts
            {
                dname = "Kiger",
                location = "Karimnagar"
            });
            db.SaveChanges();

            return Ok(new
            {
                RequestInsertedCount = sco.GetScopedTheCount(),
                data = db.Dept.OrderByDescending(t => t.deptid).ToList(),

            });
        }


        [HttpGet("tra")]
        public IActionResult tran()
        {

            db.Database.EnsureCreated();
            db.Dept.Add(new Depts
            {
                dname = "Kiger",
                location = "Karimnagar"
            });
            db.SaveChanges();

            return Ok(new
            {
                RequestInsertedCount = tra.GetTransientTheCount(),
                data = db.Dept.OrderByDescending(t => t.deptid).ToList(),

            });
        }

    }
}
