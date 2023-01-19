using AutoMapper;
using AutoMapper.Execution;
using SesaPay.DataModels.Partners;
using SesaPay.Repository.Partner.Interface;
using SesaPay.Services.Partner.Interfaces;
using SesaPay.ViewModels.Admin;
using SesaPay.ViewModels.Partners;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Services.Partner.Implementations
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerRepository _partnerRepository;
        private readonly IMapper _mapper;

        public PartnerService(IPartnerRepository partnerRepository, IMapper mapper)
        {
            _partnerRepository = partnerRepository;
            _mapper = mapper;
        }

        public void Created(PartnerDto t)
        {
            var partner = _mapper.Map<Partner_Tbl>(t);
            _partnerRepository.Create(partner);
        }

        public void Delete(int id)
        {
            
            _partnerRepository.Delete(id);
        }

        public PartnerDto Get(int id)
        {
          var  partner = _partnerRepository.Get(id);
           return _mapper.Map<PartnerDto>(partner);
        }

        public List<PartnerDto> GetAlls()
        {
            var partners = _partnerRepository.GetAll();
            return _mapper.Map<List<PartnerDto>>(partners);
        }

        public void UpdateTT(PartnerDto t)
        {
            var p = _mapper.Map<Partner_Tbl>(t);
            _partnerRepository.UpdateT(p);

        }


    }   

        
}
