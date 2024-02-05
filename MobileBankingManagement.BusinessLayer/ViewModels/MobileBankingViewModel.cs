using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBankingManagement.BusinessLayer.ViewModels
{
    public class MobileBankingViewModel
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string transactionId { get; set; }
        public string FullName { get; set; }
    }
}
