using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Middleware;

namespace justiceTestSever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociationController : ControllerBase
    {
        private readonly IAssociationBL _AssociationBL;
        public AssociationController(IAssociationBL associationBL)
        {
            _AssociationBL = associationBL;
        }
        [HttpGet("getDonationsList")]
        public async Task<List<Donation>> GetDonationsList(int AssociationCode)
        {
            var a=await _AssociationBL.GetDonationsList(AssociationCode);
            return a;
        }
        [HttpPost("AddDonation")]
        public async Task<List<Donation>> AddDonation(Donation donation)
        {
            return await _AssociationBL.AddDonation(donation);
        }
        [HttpPost("EditDonation")]
        public async Task<List<Donation>> EditDonation(Donation donation)
        {
            return await _AssociationBL.EditDonation(donation);
        }
    }
}