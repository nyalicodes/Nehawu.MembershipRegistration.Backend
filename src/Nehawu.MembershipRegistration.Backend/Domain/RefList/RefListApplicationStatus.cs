using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain.RefList
{
    [ReferenceList("Eclb", "RefListApplicationStatus")]
    public enum RefListApplicationStatus : long
    {
        ApplicationSubmitted = 1,
        Applicationprocessing = 2,
        ApplicationSucessful = 3,
        ApplicationRejected = 4
    }
}
