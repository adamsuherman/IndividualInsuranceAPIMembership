using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject
{
    public interface IBOMembership
    {
        Task<BResInsertMembership> Delete(Guid ID);
        Task<BResInsertMembership> GetById(string ID);
        Task<BResInsertMembership> Get();
        Task<BResInsertMembership> Insert(BReqInsertMembership request);
        Task<BResUpdateMembership> Update(BReqUpdateMembership request);
    }
}