using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject
{
    public interface IBONationality
    {
        Task<BResNationality> Get();
        Task<BResNationality> GetById(string ID);
    }
}