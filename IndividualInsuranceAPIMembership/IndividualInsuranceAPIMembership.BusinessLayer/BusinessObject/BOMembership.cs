using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.BusinessLayer.Helper;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject
{
    public class BOMembership : IBOMembership
    {
        private MembershipContext _membershipContext;
        RepoMembership repo;
        
        public BOMembership(MembershipContext membershipContext)
        {
            _membershipContext = membershipContext;
            repo = new RepoMembership(membershipContext);
        }
        public async Task<BResInsertMembership> Insert(BReqInsertMembership request)
        {
            BResInsertMembership result = new BResInsertMembership();
            try
            {
                result = await repo.Insert(request);
            }
            catch (Exception ex)
            {
                result.ResultCode = "00";
                result.ResultMessage = ex.Message.ToString();
                result.Data = null;
            }
            return result;
        }
        public async Task<BResInsertMembership> GetById(string ID)
        {
            BResInsertMembership result = new BResInsertMembership();
            try
            {
                result = await repo.GetById(ID);
            }
            catch (Exception ex)
            {
                result.ResultCode = "00";
                result.ResultMessage = ex.Message.ToString();
                result.Data = null;
            }
            return result;
        }
        public async Task<BResInsertMembership> Get()
        {
            BResInsertMembership result = new BResInsertMembership();
            try
            {
                result = await repo.Get();
            }
            catch (Exception ex)
            {
                result.ResultCode = "00";
                result.ResultMessage = ex.Message.ToString();
                result.Data = null;
            }
            return result;

        }
        public async Task<BResUpdateMembership> Update(BReqUpdateMembership request)
        {
            BResUpdateMembership result = new BResUpdateMembership();
            try
            {
                result = await repo.Update(request);
            }
            catch (Exception ex)
            {
                result.ResultCode = "00";
                result.ResultMessage = ex.Message.ToString();
                result.Data = null;
            }
            return result;
        }
        public async Task<BResInsertMembership> Delete(Guid ID)
        {
            BResInsertMembership result = new BResInsertMembership();
            try
            {
                result = await repo.Delete(ID);
            }
            catch (Exception ex)
            {
                result.ResultCode = "00";
                result.ResultMessage = ex.Message.ToString();
                result.Data = null;
            }
            return result;
        }
    }
}
