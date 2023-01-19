using Microsoft.EntityFrameworkCore;
using SesaPay.DataModels;
using SesaPay.DataModels.Admin;
using SesaPay.DataModels.Partners;
using SesaPay.Repository.Partner.Interface;
using SesaPay.ViewModels.Partner;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SesaPay.Repository.Partner.Implementation
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly SesaPayContext _sesaPayContext;

        public PartnerRepository(SesaPayContext sesaPayContext)
        {
            _sesaPayContext = sesaPayContext;
        }

        public void Create(DataModels.Partners.Partner t)
        {
            _sesaPayContext.tbl_Partners.Add(t);
            _sesaPayContext.SaveChanges();
        }

        public void Delete(int t)
        {
            var partner = _sesaPayContext.tbl_Partners.FirstOrDefault(x=>x.Id == t); 
            _sesaPayContext.tbl_Partners.Remove(partner);
            _sesaPayContext.SaveChanges();
        }

        public DataModels.Partners.Partner Get(int id)
        {
          return  _sesaPayContext.tbl_Partners.FirstOrDefault(x=>x.Id == id);
        }

        public IEnumerable<DataModels.Partners.Partner> GetAll()
        {
            return _sesaPayContext.tbl_Partners.ToList();
        }

        public void UpdateT(DataModels.Partners.Partner t)
        {
            
            _sesaPayContext.tbl_Partners.Update(t);
            _sesaPayContext.SaveChanges();
        }

      
    }

}