using Nehawu.MembershipRegistration.Backend.Domain.RefList;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain
{
    /// <summary>
    /// Member domain class inheriting properties from the Shesha Person domain
    /// </summary>
    [Entity(TypeShortAlias = "Eclb.Member")]
    [Discriminator]
    public class Member : Person
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string MembershipNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string ResidentialAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? ResidentialAddressLat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? ResidentialAddressLong { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RefListMembershipStatus MembershipStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? MembershipStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? MembershipEndDate { get; set; }
    }
}
