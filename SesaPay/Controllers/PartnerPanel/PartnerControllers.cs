using Microsoft.AspNetCore.Mvc;
using SesaPay.DataModels.Partners;
using SesaPay.Repository.Partner.Interface;
using SesaPay.Services.Admin.Interfaces;
using SesaPay.Services.Partner.Interfaces;
using SesaPay.ViewModels.Partner;

namespace SesaPay.API.Controllers.PartnerPanel
{
    [ApiController]
    [Route("[controller]")]
    public class PartnerControllers : ControllerBase
    {
        private readonly IPartnerService _partnerService;

      
        public PartnerControllers(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }


        [HttpGet]
        [Route("partners")]
        public  IActionResult GetPartners()
        {
          var partners = _partnerService.GetAlls();
          return Ok(partners);
        }

        [HttpPost]
        [Route("addPartner")]
       public IActionResult CreatePartners(PartnerModel partner)
        {
          _partnerService.Created(partner);
          return Ok(partner);
        }

        [HttpDelete]
        [Route("delete/{tb}")]

        public IActionResult DeletePartner(int tb)
        {
            _partnerService.Delete(tb);
            return Ok();
        }


        [HttpGet]
        [Route("getPartner/{id}")]
        public  IActionResult GetPartner(int id)
        {
            var p = _partnerService.Get(id);
            return Ok(p);
        }


        [HttpPut]
        [Route("update/partner/{id}")]
        public IActionResult UpdatePartners(int id,PartnerModel partner)
        {
            var _partner = _partnerService.Get(id);
            _partnerService.UpdateTT(partner);
            return Ok(partner);
        }

    }
}
