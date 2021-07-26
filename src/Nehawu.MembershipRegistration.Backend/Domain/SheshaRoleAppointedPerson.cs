using Nehawu.MembershipRegistration.Backend.Domain.RefList;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain
{
    /// <summary>
    /// SheshaRoleAppointedPerson domain
    /// </summary>
    [Entity(TypeShortAlias = "Eclb.SheshaRoleAppointedPerson")]
    public class SheshaRoleAppointedPerson : ShaRoleAppointedPerson
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime ValidFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime? ValidTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RefListMembershipStatus Status { get; set; }
    }
}
