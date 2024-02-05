using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileBankingManagement.BusinessLayer.Services.Repository
{
    public interface IMobileBankingRepository
    {
        List<MobileBanking> GetAllFeatures();
        Task<MobileBanking> CreateFeature(MobileBanking MobileBanking);
        Task<MobileBanking> GetFeatureById(int id);
        Task<bool> DeleteFeatureById(int id);
        Task<MobileBanking> UpdateFeature(MobileBankingViewModel model);
    }
}
