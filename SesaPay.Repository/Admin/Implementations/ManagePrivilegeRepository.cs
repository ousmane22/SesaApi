using SesaPay.DataModels;
using SesaPay.DataModels.Admin;
using SesaPay.DataModels.Partners;
using SesaPay.Repository.Admin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Repository.Admin.Implementations
{
    public class ManagePrivilegeRepository: IManagePrivilegeRepository
    {
        private readonly SesaPayContext _sesaPayContext;
        public ManagePrivilegeRepository(SesaPayContext sesaPayContext)
        {
            _sesaPayContext = sesaPayContext;
        }

        public Task<int> AddPartner(tbl_partner partner)
        {
            _sesaPayContext.Add(partner);
            _sesaPayContext.SaveChanges();
            return Task.FromResult(0);
        }

        public List<tbl_cities> GetList()
        {
           var result= _sesaPayContext.tbl_Cities.ToList();
            return result;
        }
    }
}
