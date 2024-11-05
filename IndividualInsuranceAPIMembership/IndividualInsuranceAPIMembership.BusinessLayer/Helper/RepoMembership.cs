using IndividualInsuranceAPIMembership.BusinessLayer.BindingModel;
using IndividualInsuranceAPIMembership.DataAccess.Context;
using IndividualInsuranceAPIMembership.DataAccess.Models.Membership;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            Guid ID = Guid.NewGuid();
            
            TblPeserta param = new TblPeserta();
            param.ID = ID;
            param.PolicyNumber = request.PolicyNumber;
            param.CardNumber = request.CardNumber;
            param.Name = request.Name;
            param.Address = request.Address;
            param.PhoneNumber = request.PhoneNumber;
            param.Email = request.Email;
            param.Premi = Convert.ToInt32(request.Premi);
            param.Plafond = Convert.ToInt32(request.Plafond);
            param.Birthdate = Convert.ToDateTime(request.Birthdate);
            param.StartDate = Convert.ToDateTime(request.StartDate);
            param.EndDate = Convert.ToDateTime(request.EndDate);
            param.NationalityId = request.NationalityId;
            param.NationalIdNumber = request.NationalIdNumber;
            param.CreatedAt = request.CreatedAt;
            param.CreatedDate = Convert.ToDateTime(request.CreatedDate);
            _context.Add(param);

            _context.SaveChanges();

            var data = (from peserta in _context.TblPeserta
                        join nationality in _context.msNationality on peserta.NationalityId equals nationality.NationalityId
                        where peserta.ID == ID
                        select new
                        {
                            ID = peserta.ID,
                            PolicyNumber=peserta.PolicyNumber,
                            CardNumber = peserta.CardNumber,
                            Name = peserta.Name,
                            Address = peserta.Address,
                            PhoneNumber = peserta.PhoneNumber,
                            Email = peserta.Email,
                            Premi = peserta.Premi,
                            Plafond = peserta.Plafond,
                            Birthdate = peserta.Birthdate,
                            StartDate = peserta.StartDate,
                            EndDate = peserta.EndDate,
                            Nationality = nationality.NationalityName,
                            NationalIdNumber = peserta.NationalIdNumber,
                            CreatedAt = peserta.CreatedAt,
                            CreatedDate= peserta.CreatedDate
                        }).FirstOrDefault();

            result.ResultCode = "01";
            result.ResultMessage = "Save Successfully";
            result.Data = data;

            return result;
        }

        public async Task<BResInsertMembership> GetById(Guid ID)
        {
            BResInsertMembership result = new BResInsertMembership();
            var data = (from peserta in _context.TblPeserta
                        join nationality in _context.msNationality on peserta.NationalityId equals nationality.NationalityId
                        where peserta.ID == ID
                        select new
                        {
                            ID = peserta.ID,
                            PolicyNumber = peserta.PolicyNumber,
                            CardNumber = peserta.CardNumber,
                            Name = peserta.Name,
                            Address = peserta.Address,
                            PhoneNumber = peserta.PhoneNumber,
                            Email = peserta.Email,
                            Premi = peserta.Premi,
                            Plafond = peserta.Plafond,
                            Birthdate = peserta.Birthdate,
                            StartDate = peserta.StartDate,
                            EndDate = peserta.EndDate,
                            Nationality = nationality.NationalityName,
                            NationalIdNumber = peserta.NationalIdNumber,
                            CreatedAt = peserta.CreatedAt,
                            CreatedDate = peserta.CreatedDate
                        }).FirstOrDefault();

            result.ResultCode = "01";
            result.ResultMessage = "Success";
            result.Data = data;

            //result.Data 

            return result;
        }
        public async Task<BResInsertMembership> Get()
        {
            BResInsertMembership result = new BResInsertMembership();
            var data = (from peserta in _context.TblPeserta
                        join nationality in _context.msNationality on peserta.NationalityId equals nationality.NationalityId
                        select new
                        {
                            ID = peserta.ID,
                            PolicyNumber = peserta.PolicyNumber,
                            CardNumber = peserta.CardNumber,
                            Name = peserta.Name,
                            Address = peserta.Address,
                            PhoneNumber = peserta.PhoneNumber,
                            Email = peserta.Email,
                            Premi = peserta.Premi,
                            Plafond = peserta.Plafond,
                            Birthdate = peserta.Birthdate,
                            StartDate = peserta.StartDate,
                            EndDate = peserta.EndDate,
                            Nationality = nationality.NationalityName,
                            NationalIdNumber = peserta.NationalIdNumber,
                            CreatedAt = peserta.CreatedAt,
                            CreatedDate = peserta.CreatedDate
                        }).ToList();

            result.ResultCode = "01";
            result.ResultMessage = "Success";
            result.Data = data;

            return result;
        }

        public async Task<BResUpdateMembership> Update(BReqUpdateMembership request)
        {
            BResUpdateMembership result = new BResUpdateMembership();
            var existingData = _context.TblPeserta.Where(t => t.ID == request.ID).FirstOrDefault();
            if (existingData != null)
            {
                _context.Entry(existingData).CurrentValues.SetValues(request);
                _context.SaveChanges();
            }

            var data = (from peserta in _context.TblPeserta
                        join nationality in _context.msNationality on peserta.NationalityId equals nationality.NationalityId
                        where peserta.ID == request.ID
                        select new
                        {
                            ID = peserta.ID,
                            PolicyNumber = peserta.PolicyNumber,
                            CardNumber = peserta.CardNumber,
                            Name = peserta.Name,
                            Address = peserta.Address,
                            PhoneNumber = peserta.PhoneNumber,
                            Email = peserta.Email,
                            Premi = peserta.Premi,
                            Plafond = peserta.Plafond,
                            Birthdate = peserta.Birthdate,
                            StartDate = peserta.StartDate,
                            EndDate = peserta.EndDate,
                            Nationality = nationality.NationalityName,
                            NationalIdNumber = peserta.NationalIdNumber,
                            CreatedAt = peserta.CreatedAt,
                            CreatedDate = peserta.CreatedDate
                        }).FirstOrDefault();

            result.ResultCode = "01";
            result.ResultMessage = "Success";
            result.Data = data;

            return result;
        }

        public async Task<BResInsertMembership> Delete(Guid ID)
        {
            BResInsertMembership result = new BResInsertMembership();

            var peserta = new TblPeserta { ID = ID };
            _context.TblPeserta.Attach(peserta);
            _context.TblPeserta.Remove(peserta);
            _context.SaveChanges();

            result.ResultCode = "00";
            result.ResultMessage = "Delete Successfully";
            result.Data = null;

            return result;
        }

    }
}
