using MemberManagement.Controllers;
using MemberManagement.DataLayer.Repositories;
using MemberMangement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MemberManagementUnitTests
{
    public class MemberControllerTest
    {
        private MemberController _controller;
        private MemberRepository _service = null;

        public MemberControllerTest()
        {
            _service = new MemberRepository();
            _controller = new MemberController(_service);
        }

        [Theory(DisplayName = "Return empty result when both parameters are null")]
        [InlineData(null, null)]
        public void GetEmptyResultsIfParametersAreNull(long? ploicyNumber, long? memberCardNumber)
        {
            //act
            var result = _controller.GetMembers(ploicyNumber, memberCardNumber);
            //Assert
            Assert.Empty(result);
        }

        [Fact(DisplayName = "Get member - By Policy Number")]
        public void GetMembers()
        {
            //Arrange
            long? ploicyNumber = 6494400124;
            long? memberCardNumber = null;
            //act
            var result = _controller.GetMembers(ploicyNumber, memberCardNumber);
            //Assert
            Assert.IsType<Member>(result.FirstOrDefault());
            Assert.Equal(ploicyNumber.ToString(),result.FirstOrDefault()?.PolicyNumber);
        }
    }
}
