using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject
{
    public interface IBOMembership
    {
        Task<BResInsertMembership> Delete(string ID);
        Task<BResInsertMembership> Get(string ID);
        Task<BResInsertMembership> Insert(BReqInsertMembership request);
        Task<BResInsertMembership> Update(BReqInsertMembership request);
    }
}