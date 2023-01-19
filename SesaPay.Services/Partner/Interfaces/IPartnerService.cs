using SesaPay.DataModels.Partners;
using SesaPay.ViewModels.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Services.Partner.Interfaces
{
    public interface IPartnerService:IServiceBase<PartnerModel> 
    {
        /*IEnumerable<PartnerModel>  GetPartners();*/
       /* IEnumerable<tbl_partner> GetPartners();
        Task<int> AddPartner(PartnerModel partner);
        Task<bool> DeletePartner(int  id);

        Task<bool> UpdatePartner(PartnerModel partner);
        tbl_partner GetPartner(int id);*/


    }
}
