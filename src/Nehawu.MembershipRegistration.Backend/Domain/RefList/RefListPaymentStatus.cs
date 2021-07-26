using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain.RefList
{
    [ReferenceList("Eclb", "RefListPaymentStatus")]
    public enum RefListPaymentStatus : long
    {
        Outstanding = 1,
        Paid = 2
    }
}
