using MobileBankingManagement.BusinessLayer.interfaces;
using MobileBankingManagement.BusinessLayer.Services.Repository;
using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileBankingManagement.BusinessLayer.Services
{
    public class MobileBankingService : IMobileBankingService
    {
        private readonly IMobileBankingRepository _MobileBankingRepository;

        public MobileBankingService(IMobileBankingRepository MobileBankingRepository)
        {
            _MobileBankingRepository = MobileBankingRepository;
        }

        public async Task<MobileBanking> CreateFeature(MobileBanking MobileBanking)
        {
            return await _MobileBankingRepository.CreateFeature(MobileBanking);
        }

        public async Task<bool> DeleteFeatureById(int id)
        {
            return await _MobileBankingRepository.DeleteFeatureById(id);
        }

        public List<MobileBanking> GetAllFeatures()
        {
            return _MobileBankingRepository.GetAllFeatures();
        }

        public async Task<MobileBanking> GetFeatureById(int id)
        {
            return await _MobileBankingRepository.GetFeatureById(id);
        }

        public async Task<MobileBanking> UpdateFeature(MobileBankingViewModel model)
        {
            return await _MobileBankingRepository.UpdateFeature(model);
        }
    }
}