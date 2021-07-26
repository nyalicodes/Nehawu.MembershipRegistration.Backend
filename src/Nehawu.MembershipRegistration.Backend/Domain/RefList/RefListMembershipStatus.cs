using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain.RefList
{
    [ReferenceList("Eclb", "RefListMembershipStatus")]
    public enum RefListMembershipStatus : long
    {
        Active = 1,
        Suspended = 2,
        Cancelled = 3
    }
}
