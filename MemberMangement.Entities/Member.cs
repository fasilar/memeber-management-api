using System;
using System.Collections.Generic;
using System.Text;

namespace MemberMangement.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortName {
            get
            {
                return string.Format("{0}{1}", !string.IsNullOrEmpty(this.FirstName) ? this.FirstName[0].ToString().ToUpper() : string.Empty,
                !string.IsNullOrEmpty(this.LastName) ? this.LastName[0].ToString().ToUpper() : string.Empty);
            } 
        }
        public string MemberCardNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string DateOfBirth { get; set; }  
    }
}
