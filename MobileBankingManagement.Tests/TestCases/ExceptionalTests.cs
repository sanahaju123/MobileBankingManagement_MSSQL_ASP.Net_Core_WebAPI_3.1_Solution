

using MobileBankingManagement.BusinessLayer.interfaces;
using MobileBankingManagement.BusinessLayer.Services.Repository;
using MobileBankingManagement.BusinessLayer.Services;
using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MobileBankingManagement.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IMobileBankingService _insuranceService;
        public readonly Mock<IMobileBankingRepository> insuranceservice = new Mock<IMobileBankingRepository>();

        private readonly MobileBanking _MobileBanking;
        private readonly MobileBankingViewModel _MobileBankingViewModel;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _insuranceService = new MobileBankingService(insuranceservice.Object);

            _output = output;

            _MobileBanking = new MobileBanking
            {
                FeatureId = 1,
                FeatureName = "Test",
                Description = "Test",
                FullName = "Test",
                transactionId = "123",
                Username = "Test",
            };

            _MobileBankingViewModel = new MobileBankingViewModel
            {
                FeatureId = 1,
                FeatureName = "Test",
                Description = "Test",
                FullName = "Test",
                transactionId = "123",
                Username = "Test",
            };
        }


        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidFeatureIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateFeature(_MobileBanking)).ReturnsAsync(_MobileBanking);
                var result = await  _insuranceService.CreateFeature(_MobileBanking);
                if (result != null || result.FeatureId !=0)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidTransactionIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateFeature(_MobileBanking)).ReturnsAsync(_MobileBanking);
                var result = await _insuranceService.CreateFeature(_MobileBanking);
                if (result != null || result.transactionId != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidDescriptionIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateFeature(_MobileBanking)).ReturnsAsync(_MobileBanking);
                var result = await _insuranceService.CreateFeature(_MobileBanking);
                if (result != null || result.Description != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateFeature(_MobileBanking)).ReturnsAsync(_MobileBanking);
                var result = await _insuranceService.CreateFeature(_MobileBanking);
                if (result != null || result.FullName != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
        [Fact]
        public async Task<bool> Testfor_Validate_IfInvalidUserNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateFeature(_MobileBanking)).ReturnsAsync(_MobileBanking);
                var result = await _insuranceService.CreateFeature(_MobileBanking);
                if (result != null || result.Username != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}
