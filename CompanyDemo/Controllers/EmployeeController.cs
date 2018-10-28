using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyDemo.Context;
using CompanyDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly EmployeeContext ctx;

        public EmployeeController(EmployeeContext context)
        {
            ctx = context;

            if (ctx.employees.Count() == 0)
            {
                ctx.employees.Add(new Employee { Name = "Lionel" });
                ctx.SaveChanges();
            }
        }

        // Create
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            ctx.employees.Add(employee);
            ctx.SaveChanges();
        }

        // Read
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return ctx.employees.ToList();
        }

        [HttpGet("{id}")]
        public Employee Get(string id)
        {
            return ctx.employees.Find(id);
        }


        // Update
        [HttpPut]
        public void Put([FromBody] Employee employee)
        {
            var emp = ctx.employees.Find(employee.EmployeeId);
            emp.Name = employee.Name;
            ctx.SaveChanges();
        }

        // Delete
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            ctx.employees.Remove(ctx.employees.Find(id));
            ctx.SaveChanges();
        }
    }
}
