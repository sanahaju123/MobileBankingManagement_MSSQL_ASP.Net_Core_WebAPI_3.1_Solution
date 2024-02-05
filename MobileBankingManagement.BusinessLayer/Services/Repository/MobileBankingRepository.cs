using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.DataLayer;
using MobileBankingManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBankingManagement.BusinessLayer.Services.Repository
{
    public class MobileBankingRepository : IMobileBankingRepository
    {
        private readonly InsuranceDbContext _dbContext;
        public MobileBankingRepository(InsuranceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MobileBanking> CreateFeature(MobileBanking MobileBanking)
        {
            try
            {
                var result = await _dbContext.InsurancePolicies.AddAsync(MobileBanking);
                await _dbContext.SaveChangesAsync();
                return MobileBanking;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteFeatureById(int id)
        {
            try
            {
                _dbContext.Remove(_dbContext.InsurancePolicies.Single(a => a.FeatureId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<MobileBanking> GetAllFeatures()
        {
            try
            {
                var result = _dbContext.InsurancePolicies.
                OrderByDescending(x => x.FeatureId).Take(10).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<MobileBanking> GetFeatureById(int id)
        {
            try
            {
                return await _dbContext.InsurancePolicies.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<MobileBanking> UpdateFeature(MobileBankingViewModel model)
        {
            var feature = await _dbContext.InsurancePolicies.FindAsync(model.FeatureId);
            try
            {
                _dbContext.InsurancePolicies.Update(feature);
                await _dbContext.SaveChangesAsync();
                return feature;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}