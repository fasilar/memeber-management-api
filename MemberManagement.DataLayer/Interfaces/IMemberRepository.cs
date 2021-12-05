using MemberMangement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemberManagement.DataLayer.Interfaces
{
    public interface IMemberRepository
    {
        List<Member> GetMembers(long? policyNumber, long? memberCardNumber);
    }
}
