using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using IndividualInsuranceAPIMembership.DataAccess.Models.Membership;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualInsuranceAPIMembership.BusinessLayer.Helper
{
    public class RepoNationality
    {
        private readonly MembershipContext _context;

        public RepoNationality(MembershipContext context)
        {
            _context = context;
        }   

        public async Task<List<msNationality>> Get()
        {
            List<msNationality> objRes = new List<msNationality>();
            objRes = await _context.msNationality.ToListAsync();
            return objRes;
        }
    }
}
