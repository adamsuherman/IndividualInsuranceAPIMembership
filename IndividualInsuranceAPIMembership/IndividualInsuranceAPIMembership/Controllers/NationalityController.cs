using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace IndividualInsuranceAPIMembership.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NationalityController : Controller
    {
        private IConfiguration _configuration;
        BResNationality result = new BResNationality();
        IBONationality _boNationality;

        public NationalityController(IConfiguration configuration)
        {
            _configuration = configuration;
            _boNationality = new BONationality();
        }

        [HttpGet]
        public async Task<IActionResult> GetNationality()
        {
            result = await _boNationality.Get();
            return new OkObjectResult(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetNationalityById(string ID)
        {
            result = await _boNationality.GetById(ID);
            return new OkObjectResult(result);
        }
    }
}
