using Microsoft.EntityFrameworkCore;
using SesaPay.DataModels;
using SesaPay.DataModels.Admin;
using SesaPay.DataModels.Partners;
using SesaPay.Repository.Partner.Interface;
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

        public void Create(Partner_Tbl t)
        {
            _sesaPayContext.Partners.Add(t);
            _sesaPayContext.SaveChanges();
        }

        public void Delete(int t)
        {
            var partner = _sesaPayContext.Partners.FirstOrDefault(x=>x.Id == t); 
            _sesaPayContext.Partners.Remove(partner);
            _sesaPayContext.SaveChanges();
        }

        public Partner_Tbl Get(int id)
        {
          return  _sesaPayContext.Partners.FirstOrDefault(x=>x.Id == id);
        }

        public IEnumerable<Partner_Tbl> GetAll()
        {
            return _sesaPayContext.Partners.ToList();
        }

        public void UpdateT(Partner_Tbl t)
        {

            _sesaPayContext.Entry(t).State = EntityState.Modified;
            _sesaPayContext.SaveChanges();
        }

      
    }

}