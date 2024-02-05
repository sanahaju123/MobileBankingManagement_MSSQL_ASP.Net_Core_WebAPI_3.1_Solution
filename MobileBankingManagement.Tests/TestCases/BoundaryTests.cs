
using MobileBankingManagement.BusinessLayer.interfaces;
using MobileBankingManagement.BusinessLayer.Services.Repository;
using MobileBankingManagement.BusinessLayer.Services;
using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MobileBankingManagement.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IMobileBankingService _insuranceService;
        public readonly Mock<IMobileBankingRepository> insuranceservice = new Mock<IMobileBankingRepository>();

        private readonly MobileBanking _MobileBanking;
        private readonly MobileBankingViewModel _MobileBankingViewModel;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_FeatureId_NotEmpty()
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
                var actualLength = _MobileBanking.FeatureId.ToString().Length;
                if (result.FeatureId.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Description_NotEmpty()
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
                var actualLength = _MobileBanking.Description.ToString().Length;
                if (result.Description.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_TransactionId_NotEmpty()
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
                var actualLength = _MobileBanking.transactionId.ToString().Length;
                if (result.transactionId.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_FeatureName_NotEmpty()
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
                var actualLength = _MobileBanking.FeatureName.ToString().Length;
                if (result.FeatureName.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_FullName_NotEmpty()
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
                var actualLength = _MobileBanking.FullName.ToString().Length;
                if (result.FullName.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_UserName_NotEmpty()
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
                var actualLength = _MobileBanking.Username.ToString().Length;
                if (result.Username.ToString().Length == actualLength)
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