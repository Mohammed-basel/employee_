using emplyee_api.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using emplyee_api.services;

namespace employeeControllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class employeeController : ControllerBase
        {
            public IEmplyee _employeeserves;

            public employeeController(IEmplyee employeeservice)
            {
                _employeeserves = employeeservice;

                var x = 1;
            }
            [HttpGet("GetById/{id}")]
            public ActionResult<employee> GetById(int id)
            {
                return Ok(_employeeserves.GetById(id));
            }
            [HttpGet]
            public async Task<ActionResult<List<employee>>> GET()
            {
                return Ok(_employeeserves.GET());
            }
            [HttpPost]

            public ActionResult Create(employee employee)
            {
                return Ok(_employeeserves.Create(employee));
            }
            [HttpPut("Update")]
            public ActionResult Update(employee employee)
            {
                return Ok(_employeeserves.Update(employee));
            }
            [HttpDelete("{id}")]
            public ActionResult Delete(int id)
            {
                return Ok(_employeeserves.Delete(id));


            }
        }
    }


