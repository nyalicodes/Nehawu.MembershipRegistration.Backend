using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain.RefList
{
    [ReferenceList("Eclb", "RefListPaymentMethod")]
    public enum RefListPaymentMethod : long
    {
        Cash = 1,
        EFT = 2,
        DebitOrder = 3
    }
}
