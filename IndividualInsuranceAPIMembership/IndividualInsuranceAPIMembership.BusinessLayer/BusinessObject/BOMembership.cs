using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.BusinessLayer.Helper;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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

            }
            return result;
        }

        public async Task<BResInsertMembership> Get(string ID)
        {
            BResInsertMembership result = new BResInsertMembership();
            try
            {

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<BResInsertMembership> Update(BReqInsertMembership request)
        {
            BResInsertMembership result = new BResInsertMembership();
            try
            {

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public async Task<BResInsertMembership> Delete(string ID)
        {
            BResInsertMembership result = new BResInsertMembership();
            try
            {

            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
