using MemberManagement.DataLayer.Interfaces;
using MemberManagement.DataLayer.Repositories;
using MemberMangement.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberManagement.Controllers
{
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMemberRepository _memberRepository;

        public MemberController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        [Route("~/api/GetMembers")]
        [HttpGet]
        public List<Member> GetMembers(long? policyNumber, long? memberCardNumber)
        {
            if (policyNumber == null && memberCardNumber == null) return new List<Member>() ;
            return _memberRepository.GetMembers(policyNumber, memberCardNumber);
        }
    }
}
