using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.BusinessLayer.Helper;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using IndividualInsuranceAPIMembership.DataAccess.Models.Membership;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject
{
    public class BONationality : IBONationality
    {
        private MembershipContext _membershipContext;
        RepoNationality repo;
        public BONationality(MembershipContext membershipContext)
        {
            _membershipContext = membershipContext;
            repo= new RepoNationality(membershipContext);
        }
        public async Task<List<msNationality>> Get()
        {
            List<msNationality> result = new List<msNationality>();
            try
            {
                result = await repo.Get();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<msNationality> GetById(Guid ID)
        {
            msNationality result = new msNationality();
            try
            {
                result = await repo.GetByID(ID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
