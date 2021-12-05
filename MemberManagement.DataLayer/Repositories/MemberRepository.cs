using MemberManagement.DataLayer.Interfaces;
using MemberMangement.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MemberManagement.DataLayer.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public List<Member> GetMembers(long? policyNumber, long? memberCardNumber)
        {
            var members =  JsonConvert.DeserializeObject<List<Member>>(File.ReadAllText(@"App_Data\MEMBERS_MOCK_DATA.json"));
            if (members == null || members.Count == 0) return new List<Member>();
            return members.Where(m =>  (policyNumber == null || Int64.Parse(m.PolicyNumber) == policyNumber) &&
            (memberCardNumber == null ||  Int64.Parse(m.MemberCardNumber) == memberCardNumber) ).ToList() ;
        }
    }
}
