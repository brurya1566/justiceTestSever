using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public interface IAssociationBL
    {
        Task<List<Donation>> GetDonationsList(int AssociationCode);
        Task<List<Donation>> AddDonation(Donation donation);
        Task<List<Donation>> EditDonation(Donation donation);
    }
}
