using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class AssociationRepository : IAssociationRepository
    {
        private static List<Association> AssociationList = new List<Association> { new Association() { Code=1,MailAdress="brurya1566@gmail.com",Name="עמותה למען ברוריה דהאן"} };

        private static List<Donation> DonationList = new List<Donation> { new Donation() { CurrencyTypeCode = 1, DonationPurpose = "", DonationConditions = "", EntityKindCode = 1, EntityName = "ישות 1", forex = new float() { }, sum = 2000 } , new Donation() { CurrencyTypeCode = 1, DonationPurpose = "", DonationConditions = "", EntityKindCode = 1, EntityName = "ישות 2", forex = new float() { }, sum = 300 } };

        public async Task<Association> GetAssociation(int code)
        {
            return  AssociationList.Where(data => data.Code == code).FirstOrDefault();
        }
        public async Task<List<Donation>> GetDonationsList(int AssociationCode)
        {
            return DonationList.Where(data => data.AssociationCode == AssociationCode).ToList();
        }
        public async Task<List<Donation>> AddDonation(Donation donation)
        {
            donation.DonationId = DonationList.Max(data => data.DonationId) + 1;//טיפול במפתח רץ
            DonationList.Add(donation);
            return DonationList;
        }
        public async Task<List<Donation>> EditDonation(Donation donation)
        {
            DonationList.Remove(DonationList.First(data => data.DonationId == donation.DonationId));
            return DonationList;
        }
        public void Dispose()
        {
            //מיועד עבור אובייקט בסיס הנתונים 
        }
    }
}
