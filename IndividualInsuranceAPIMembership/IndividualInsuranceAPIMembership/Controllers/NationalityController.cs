using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using IndividualInsuranceAPIMembership.DataAccess.Models.Membership;
using Microsoft.AspNetCore.Mvc;

namespace IndividualInsuranceAPIMembership.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NationalityController : Controller
    {
        private IConfiguration _configuration;
        List<msNationality> result = new List<msNationality>();
        IBONationality _boNationality;
        public MembershipContext _membershipContext;

        public NationalityController(IConfiguration configuration, MembershipContext membershipContext)
        {
            _configuration = configuration;
            _membershipContext = membershipContext;
            _boNationality = new BONationality(_membershipContext);
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
