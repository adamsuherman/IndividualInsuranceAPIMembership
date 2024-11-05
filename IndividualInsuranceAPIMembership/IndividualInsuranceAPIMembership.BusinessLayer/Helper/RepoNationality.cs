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
            objRes = _context.msNationality.ToList();
            return objRes;
        }

        public async Task<msNationality> GetByID(Guid ID)
        {
            msNationality objRes = new msNationality();
            objRes = _context.msNationality.Where(t => t.NationalityId == ID).FirstOrDefault();
            return objRes;
        }
    }
}
