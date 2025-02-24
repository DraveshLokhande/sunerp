﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities.SalesDistribution.OpportunityLossMasterModel
{
    public class CustomerAddressTxn
    {
        
        public string AddressType { get; set; }
        public string PlotNoName { get; set; }
        public string StreetNoName { get; set; } 
        public string StateName { get; set; }
        public string CountryName { get; set; } 
        public string CustomerCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; } 
        public string Area { get; set; }
        public string ZIPCode { get; set; }
       
        public string City { get; set; }
        public string District { get; set; }
        public string Taluka { get; set; }
        public string Landmark { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public int AddressTypeID { get; set; } 
    }
}
