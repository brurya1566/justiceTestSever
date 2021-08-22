using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAssociationRepository : IDisposable
    {
        Task<Association> GetAssociation(int code);
        Task<List<Donation>> GetDonationsList(int AssociationCode);
        Task<List<Donation>> AddDonation(Donation donation);
        Task<List<Donation>> EditDonation(Donation donation);

    }
}
