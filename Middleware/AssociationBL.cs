using Common;
using DAL;
using MailKit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Middleware
{
    public class AssociationBL : IAssociationBL
    {
        private readonly IAssociationRepository _AssociationRepository;
        private readonly IMailService _MailService;

        public AssociationBL(IAssociationRepository AssociationRepository, IMailService MailService)
        {
            _AssociationRepository = AssociationRepository;
            _MailService = MailService;
        }
        public async Task<List<Donation>> GetDonationsList(int AssociationCode)
        {
            return await _AssociationRepository.GetDonationsList(AssociationCode);
        }
        public async Task<List<Donation>> AddDonation(Donation donation)
        {
            if (donation.sum > 10000)
            {
                string mail = _AssociationRepository.GetAssociation(donation.AssociationCode).Result.MailAdress;
                await _MailService.SendEmailAsync(new MailRequest() { Attachments = null, Body = "נקלטה תרומה של יותר מ10K", Subject = "לתשומת לב", ToEmail = mail });
            }
            return await _AssociationRepository.AddDonation(donation);
        }
        public Task<List<Donation>> EditDonation(Donation donation)
        {
            return _AssociationRepository.EditDonation(donation);
        }
    }
}
