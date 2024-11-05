using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace IndividualInsuranceAPIMembership.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MembershipController : Controller
    {
        private IConfiguration _configuration;
        private readonly IBOMembership _boMembership;
        private readonly MembershipContext _membershipContext;

        BResInsertMembership result = new BResInsertMembership();

        public MembershipController(IConfiguration configuration, MembershipContext membershipContext)
        {
            _configuration= configuration;
            _membershipContext = membershipContext;
            _boMembership = new BOMembership(_membershipContext);
        }

        [HttpPost]
        public async Task<IActionResult> InsertMembership(BReqInsertMembership request)
        {
            result = await _boMembership.Insert(request);
            return new OkObjectResult(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetMembership(string ID)
        {
            result = await _boMembership.Get(ID);
            return new OkObjectResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMembership(BReqInsertMembership request)
        {
            result = await _boMembership.Update(request);
            return new OkObjectResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMembership(string ID)
        {
            result = await _boMembership.Delete(ID);
            return new OkObjectResult(result);
        }
    }
}
