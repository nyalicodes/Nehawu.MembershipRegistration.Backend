using Abp.Domain.Entities.Auditing;
using Nehawu.MembershipRegistration.Backend.Domain.RefList;
using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain
{
    /// <summary>
    /// Payment Domain
    /// </summary>
    [Entity(TypeShortAlias = "Eclb.Payment")]
    public class Payment : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual Member Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string PaymentRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime PaymentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual decimal PaymentAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RefListPaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RefListPaymentMethod PaymentMethod { get; set; }
    }
}
