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
        List<msNationality> ArrResult = new List<msNationality>();
        msNationality result = new msNationality();
        IBONationality _boNationality;
        private readonly MembershipContext _membershipContext;

        public NationalityController(IConfiguration configuration, MembershipContext membershipContext)
        {
            _configuration = configuration;
            _membershipContext = membershipContext;
            _boNationality = new BONationality(_membershipContext);
        }

        [HttpGet]
        public async Task<IActionResult> GetNationality()
        {
            ArrResult = await _boNationality.Get();
            return new OkObjectResult(ArrResult);
        }

        [HttpGet]
        public async Task<IActionResult> GetNationalityById(Guid ID)
        {
            result = await _boNationality.GetById(ID);
            return new OkObjectResult(result);
        }
    }
}
