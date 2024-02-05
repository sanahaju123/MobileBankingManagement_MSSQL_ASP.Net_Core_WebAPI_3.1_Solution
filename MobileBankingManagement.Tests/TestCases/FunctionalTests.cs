
using MobileBankingManagement.BusinessLayer.interfaces;
using MobileBankingManagement.BusinessLayer.Services;
using MobileBankingManagement.BusinessLayer.Services.Repository;
using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MobileBankingManagement.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IMobileBankingService _insuranceService;
        public readonly Mock<IMobileBankingRepository> insuranceservice = new Mock<IMobileBankingRepository>();

        private readonly MobileBanking _MobileBanking;
        private readonly MobileBankingViewModel _MobileBankingViewModel;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _insuranceService = new MobileBankingService(insuranceservice.Object);

            _output = output;

            _MobileBanking = new MobileBanking
            {
                FeatureId=1,
                FeatureName="Test",
                Description="Test",
                FullName="Test",
                transactionId="123",
                Username="Test",
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
        public async Task<bool> Testfor_Create_Feature()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.CreateFeature(_MobileBanking)).ReturnsAsync(_MobileBanking);
                var result = await _insuranceService.CreateFeature(_MobileBanking);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_Update_Feature()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.UpdateFeature(_MobileBankingViewModel)).ReturnsAsync(_MobileBanking);
                var result = await _insuranceService.UpdateFeature(_MobileBankingViewModel);
                if (result != null)
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
        public async Task<bool> Testfor_GetFeatureById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.GetFeatureById(id)).ReturnsAsync(_MobileBanking);
                var result = await _insuranceService.GetFeatureById(id);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_DeleteFeatureById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repos => repos.DeleteFeatureById(id)).ReturnsAsync(response);
                var result = await _insuranceService.DeleteFeatureById(id);
                //Assertion
                if (result != null)
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