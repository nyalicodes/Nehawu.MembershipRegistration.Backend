using Abp.Domain.Entities.Auditing;
using Nehawu.MembershipRegistration.Backend.Domain.RefList;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nehawu.MembershipRegistration.Backend.Domain
{
    [Entity(TypeShortAlias = "Eclb.MembershipApplication")]
    public class MembershipApplication : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Surname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string IDNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DateOfBirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Cellphone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string ResidentialAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Area Province { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Area Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Area Branch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime ApplicationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RefListApplicationStatus ApplicationStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        public virtual Member RegisteredMember { get; set; }
    }
}
