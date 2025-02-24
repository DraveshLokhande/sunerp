﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Entities.Marketing.Feedback
{
    public class MarketingFeedback
    {
        public int MarketingFeedbackID { get; set; }

        [Required(ErrorMessage = "Please Select Date")]
        public DateTime FeedbackDate { get; set; }

        [Required(ErrorMessage = "Please Enter the Party Name")]
        public string PartyName { get; set; }

        [Required(ErrorMessage = "Please Select the Party Type")]
        public int PartyID { get; set; }
        public int PartyTypeID { get; set; }
        public string PartyTypeText { get; set; }

        //[Required(ErrorMessage = "Please Enter the Party Email ID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter the Party Mobile Number")]
        public string MobileNo { get; set; }

        /*[Required(ErrorMessage = "Please Select This Check Box")]*/
        public bool IsReceivedDocument { get; set; } = true;

        /*[Required(ErrorMessage = "Please Witer the Note")]*/
        public string Note { get; set; }
        public string PositiveNoteID { get; set; }
        public string PositiveNoteText { get; set; }
        public int CreatedOrModifiedBy { get; set; }
        public object SrNo { get; set; }
        public string PositiveNotesArray { get; set; }
        [NotMapped]
        public string EncryptedId { get; set; }
        public List<MarketingFeedbackLogDetail> marketingFeedbackLogDetails { get; set; } = new List<MarketingFeedbackLogDetail>();
    }
}
