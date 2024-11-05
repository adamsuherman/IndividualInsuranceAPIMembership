﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualInsuranceAPIMembership.BusinessLayer.BindingModel
{
    public class BReqUpdateMembership
    {
        public Guid ID { get; set; }

        public string? PolicyNumber { get; set; }

        public string? CardNumber { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public decimal? Premi { get; set; }

        public decimal? Plafond { get; set; }

        public DateTime? Birthdate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid? NationalityId { get; set; }

        public string? NationalIdNumber { get; set; }

        public string? CreatedAt { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
