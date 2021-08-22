using System;

namespace Common
{
    public class Donation
    {
        public int AssociationCode { get; set; }
        public int DonationId { get; set; }
        public string EntityName { get; set; }
        public int sum { get; set; }
        public int EntityKindCode { get; set; }
        public string DonationPurpose { get; set; }
        public string DonationConditions { get; set; }
        public int CurrencyTypeCode { get; set; }
        public float forex { get; set; }
    }
}
