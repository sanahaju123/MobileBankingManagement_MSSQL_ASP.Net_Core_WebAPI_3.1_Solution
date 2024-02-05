using Castle.Core.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MobileBankingManagement.Entities
{
    public class MobileBanking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string transactionId { get; set; }
        public string FullName { get; set; }
    }
}
