using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISIncClassProject.Entities
{
    public class VendorMetadata
    {

        [Display(Name = "Account Number")]
        public string AccountNumber;

        [Display(Name = "Credit Rating")]
        public byte CreditRating;

        [Display(Name = "Active")]
        public bool ActiveFlag;

        [Display(Name = "Preferred")]
        public bool PreferredVendorStatus;

        [Display(Name = "Purchasing URL")]
        public string PurchasingWebServiceURL;

        [Display(Name = "Modified")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime ModifiedDate;
    }
}