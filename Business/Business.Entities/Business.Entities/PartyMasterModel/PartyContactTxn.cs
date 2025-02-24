﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Entities.Party
{
    public class PartyContactTxn
    {
        public int PartyContactID { get; set; }
        public int PartyID { get; set; }
        public string Prefix { get; set; }
        [Required(ErrorMessage = "Contact person name is required.")]
        public string ContactPersonName { get; set; }
        [Required(ErrorMessage = "Please select Designation.")]
        public int DesignationID { get; set; }
        [Required(ErrorMessage = "Please select Department.")]
        public int DepartmentID { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        [Required(ErrorMessage = "Personal mobile number is required..")]
        public string PersonalMobile { get; set; }
        [Required(ErrorMessage = "Office mobile number is required..")]
        public string OfficeMobile { get; set; }
        public string PersonalEmailID { get; set; }
        [Required(ErrorMessage = "Office emailid is required..")]
        public string OfficeEmailID { get; set; }
        public string AlternativeMobile { get; set; }
        public string EmailGroupName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Religion { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsResigned { get; set; }
        public string Notes { get; set; }
        public int SrNo { get; set; }
        public int CreatedOrModifiedBy { get; set; }
    }
}
