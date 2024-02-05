using MobileBankingManagement.BusinessLayer.interfaces;
using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileBankingManagement.Controllers
{
    [ApiController]
    public class MobileBankingController : ControllerBase
    {
        private readonly IMobileBankingService _MobileBankingService;
        public MobileBankingController(IMobileBankingService MobileBankingService)
        {
            _MobileBankingService = MobileBankingService;
        }

        [HttpPost]
        [Route("create-feature")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateFeature([FromBody] MobileBanking model)
        {
            var policyExists = await _MobileBankingService.GetFeatureById(model.FeatureId);
            if (policyExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Feature already exists!" });
            var result = await _MobileBankingService.CreateFeature(model);
            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Feature creation failed! Please check details and try again." });

            return Ok(new Response { Status = "Success", Message = "Feature created successfully!" });

        }


        [HttpPut]
        [Route("update-feature")]
        public async Task<IActionResult> UpdateFeature([FromBody] MobileBankingViewModel model)
        {
            var policy = await _MobileBankingService.UpdateFeature(model);
            if (policy == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Feature With Id = {model.FeatureId} cannot be found" });
            }
            else
            {
                var result = await _MobileBankingService.UpdateFeature(model);
                return Ok(new Response { Status = "Success", Message = "Feature updated successfully!" });
            }
        }

        [HttpDelete]
        [Route("delete-feature")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var policy = await _MobileBankingService.GetFeatureById(id);
            if (policy == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Feature With Id = {id} cannot be found" });
            }
            else
            {
                var result = await _MobileBankingService.DeleteFeatureById(id);
                return Ok(new Response { Status = "Success", Message = "Feature deleted successfully!" });
            }
        }


        [HttpGet]
        [Route("get-feature-by-id")]
        public async Task<IActionResult> GetFeatureById(int id)
        {
            var policy = await _MobileBankingService.GetFeatureById(id);
            if (policy == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Feature With Id = {id} cannot be found" });
            }
            else
            {
                return Ok(policy);
            }
        }

        [HttpGet]
        [Route("get-all-features")]
        public async Task<IEnumerable<MobileBanking>> GetAllFeatures()
        {
            return _MobileBankingService.GetAllFeatures();
        }
    }
}