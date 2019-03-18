using System;
using System.Collections.Generic;
using System.Linq;
using LinqKit;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreEnumToStringTest
{
    [Route("test")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private MyDbContext MyDbContext { get; }

        public MyController(MyDbContext myDbContext)
        {
            MyDbContext = myDbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var getOverdueFilter = MyExpressions.GetOverdue(DateTime.UtcNow);
            var entities = MyDbContext.MyEntities.AsExpandable().Where(getOverdueFilter).ToList();

            return Ok(entities);
        }
    }
}
