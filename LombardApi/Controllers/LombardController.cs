using LombardApi.Context;
using LombardApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LombardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LombardController : ControllerBase
    {
        private readonly ILombardService _lombardService;

        public LombardController(ILombardService lombardService) => 
            this._lombardService = lombardService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClient()
        {
            return Ok(await _lombardService.GetClients());
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(Client _client)
        {
            await _lombardService.AddClient(_client);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employees employees)
        {
            await _lombardService.AddEmployee(employees);
            return Ok();
        }

        [HttpPut($"{{clientId}}")]
        public async Task<IActionResult> UpdateClient(Guid clientId, Client newData)
        {
            await _lombardService.UpdateClient(clientId, newData);
            return Ok();
        }

        [HttpPut($"{{employeesId}}")]
        public async Task<IActionResult> UpdateEmployee(Guid employeesId, Employees newData)
        {
            await _lombardService.UpdateEmployee(employeesId, newData);
            return Ok();
        }

        [HttpDelete($"{{clientId}}")]
        public async Task<OkResult> DeleteClientAsync(Guid clientId) 
        {
            await _lombardService.DeleteClient(clientId);
            return Ok();
        }


        [HttpDelete($"{{employeesId}}")]
        public async Task<OkResult> DeleteEmployeeAsync(Guid employeesId)
        {
            await _lombardService.DeleteEmployee(employeesId);
            return Ok();
        }
    }
}
