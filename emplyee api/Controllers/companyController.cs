using emplyee_api.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using emplyee_api.services;

namespace companyControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class companyControllers : ControllerBase
    {
        public ICompany _companyserves;

        public companyControllers(ICompany companyservices)
        {
            _companyserves = companyservices;

            var x = 1;
        }
        [HttpGet("GetById/{id}")]
        public ActionResult<employee> GetById(int id)
        {
            return Ok(_companyserves.GetById(id));
        }
        [HttpGet]
        public async Task<ActionResult<List<company>>> GET()
        {
            return Ok(_companyserves.GET());
        }
        [HttpPost]

        public ActionResult Create(company company)
        {
            return Ok(_companyserves.Create(company));
        }
        [HttpPut("Update")]
        public ActionResult Update(company company)
        {
            return Ok(_companyserves.Update(company));
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_companyserves.Delete(id));


        }
    }
}


