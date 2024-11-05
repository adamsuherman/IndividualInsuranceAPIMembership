using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.BusinessLayer.Helper;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using IndividualInsuranceAPIMembership.DataAccess.Models.Membership;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BusinessObject
{
    public class BONationality : IBONationality
    {
        private MembershipContext _membershipContext;
        public BONationality(MembershipContext membershipContext)
        {
            _membershipContext = membershipContext;
        }
        public async Task<List<msNationality>> Get()
        {
            RepoNationality repo = new RepoNationality(_membershipContext);
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

        public async Task<List<msNationality>> GetById(string ID)
        {
            List<msNationality> result = new List<msNationality>();
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
