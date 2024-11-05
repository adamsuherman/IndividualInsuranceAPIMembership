using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BindingModel
{
    public class BReqInsertMembership
    {
        public string ID { get; set; }
        public string PolicyNumber { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string NationalityId { get; set; }
        public string NationalIdNumber { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedDate { get; set; }
    }
}
