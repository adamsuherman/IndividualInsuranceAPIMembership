using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.DataAccess.Models.Membership;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject
{
    public interface IBONationality
    {
        Task<List<msNationality>> Get();
        Task<List<msNationality>> GetById(string ID);
    }
}