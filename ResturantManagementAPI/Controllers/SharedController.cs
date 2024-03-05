using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResturantManagementAPI.Implmentations;
using ResturantManagementAPI.Interfaces;

namespace ResturantManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        readonly ISharedInterface _sharedInterface;
        public SharedController(ISharedInterface sharedInterface) {

            _sharedInterface = sharedInterface;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetIngredintesFromDatabase() {
            var result = await _sharedInterface.GetAllIngratiatesInDb();
            return Ok(result);
        }
    }
}
