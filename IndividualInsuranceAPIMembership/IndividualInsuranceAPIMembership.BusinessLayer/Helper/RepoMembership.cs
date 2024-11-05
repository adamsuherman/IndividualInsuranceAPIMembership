using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using IndividualInsuranceAPIMembership.DataAccess.Models.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualInsuranceAPIMembership.BusinessLayer.Helper
{

    public  class RepoMembership
    {
        private readonly MembershipContext _context;

        public RepoMembership(MembershipContext context)
        {
            _context = context;
        }

        public async Task<BResInsertMembership> Insert(BReqInsertMembership request)
        {
            BResInsertMembership result = new BResInsertMembership();
            TblPeserta objres = new TblPeserta();
            Guid ID = Guid.NewGuid();
            
            TblPeserta param = new TblPeserta();
            param.ID = ID;
            param.PolicyNumber = request.PolicyNumber;
            param.CardNumber = request.CardNumber;
            param.Name = request.Name;
            param.Address = request.Address;
            param.PhoneNumber = request.PhoneNumber;
            param.Email = request.Email;
            param.Birthdate = Convert.ToDateTime(request.Birthdate);
            param.StartDate = Convert.ToDateTime(request.StartDate);
            param.EndDate = Convert.ToDateTime(request.EndDate);
            param.NationalityId = request.NationalityId;
            param.NationalIdNumber = request.NationalIdNumber;
            param.CreatedAt = request.CreatedAt;
            param.CreatedDate = Convert.ToDateTime(request.CreatedDate);
            _context.Add(param);

            _context.SaveChanges();

            objres = _context.TblPeserta.Where(t => t.ID == ID).FirstOrDefault();

            result.ID = objres.ID.ToString();
            result.PolicyNumber = objres.PolicyNumber.ToString();
            result.CardNumber = objres.CardNumber.ToString();
            result.Name = objres.Name.ToString();
            result.Address = objres.Address.ToString();
            result.PhoneNumber = objres.PhoneNumber.ToString();
            result.Email = objres.Email.ToString();
            result.Birthdate = objres.Birthdate.ToString();
            result.StartDate = objres.StartDate.ToString();
            result.EndDate = objres.EndDate.ToString();
            result.NationalityId = objres.NationalityId.ToString();
            result.NationalIdNumber = objres.NationalIdNumber.ToString();
            result.CreatedAt = objres.CreatedAt.ToString();
            result.CreatedDate = objres.CreatedDate.ToString();

            return result;
        }

    }
}
