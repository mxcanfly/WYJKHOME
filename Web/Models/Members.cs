namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Members
    {
        [Key]
        public int MemberID { get; set; }

        [StringLength(50)]
        public string MemberName { get; set; }

        [StringLength(50)]
        public string MemberPhone { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(50)]
        public string InviteCode { get; set; }

        [StringLength(50)]
        public string IsComplete { get; set; }

        [StringLength(50)]
        public string TrueName { get; set; }

        [StringLength(50)]
        public string CertificateType { get; set; }

        [StringLength(50)]
        public string CertificateNo { get; set; }

        [StringLength(50)]
        public string PoliticalStatus { get; set; }

        [StringLength(50)]
        public string Education { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string Sex { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string Alipay { get; set; }

        [StringLength(50)]
        public string BankCardNo { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        [StringLength(50)]
        public string UserAccount { get; set; }

        [StringLength(50)]
        public string SecondContact { get; set; }

        [StringLength(50)]
        public string SecondContactPhone { get; set; }

        [StringLength(50)]
        public string InsuranceArea { get; set; }

        [StringLength(50)]
        public string HouseholdType { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string BusinessCode { get; set; }

        [StringLength(50)]
        public string BusinessIdentityCardNo { get; set; }

        [StringLength(50)]
        public string BusinessName { get; set; }

        [StringLength(50)]
        public string BusinessUser { get; set; }

        [StringLength(512)]
        public string BusinessIdentityPhoto { get; set; }

        [StringLength(512)]
        public string BusinessLicensePhoto { get; set; }

        [StringLength(50)]
        public string EnterpriseApplyName { get; set; }

        [StringLength(50)]
        public string EnterpriseApplyIdentityCardNo { get; set; }

        [StringLength(512)]
        public string EnterpriseApplyIdentityPhoto { get; set; }

        [StringLength(50)]
        public string EnterpriseApplyUserPhone { get; set; }

        [StringLength(50)]
        public string EnterpriseApplyUserEmail { get; set; }

        [StringLength(512)]
        public string EnterpriseLicensePhone { get; set; }

        [StringLength(50)]
        public string EnterpriseName { get; set; }

        [StringLength(50)]
        public string EnterpriseType { get; set; }

        [StringLength(50)]
        public string EnterpriseArea { get; set; }

        [StringLength(50)]
        public string EnterpriseLegal { get; set; }

        [StringLength(50)]
        public string EnterpriseLegalIdentityCardNo { get; set; }

        [StringLength(50)]
        public string EnterprisePeopleNum { get; set; }

        [StringLength(50)]
        public string SocialSecurityCreditCode { get; set; }

        [StringLength(50)]
        public string EnterpriseIsThreeInOne { get; set; }

        [StringLength(512)]
        public string EnterpriseBusinessLicense { get; set; }

        [StringLength(512)]
        public string EnterpriseTaxRegistrationCertificate { get; set; }

        [StringLength(512)]
        public string EnterpriseOrganizationCodeCertificate { get; set; }

        [StringLength(50)]
        public string EnterpriseFixedTelePhone { get; set; }

        [StringLength(50)]
        public string IsAuthentication { get; set; }

        [StringLength(50)]
        public string UserType { get; set; }

        [StringLength(50)]
        public string TaxpayerName { get; set; }

        [StringLength(50)]
        public string TaxNumber { get; set; }

        [StringLength(50)]
        public string ContactUser { get; set; }

        [StringLength(50)]
        public string ContactUserPhone { get; set; }

        [StringLength(50)]
        public string OpenAccountPhone { get; set; }

        public decimal? Account { get; set; }

        public decimal? SocialSecurityAmount { get; set; }

        public decimal? AccumulationFundAmount { get; set; }

        public decimal? ServiceCost { get; set; }

        public decimal? FirstBacklogCost { get; set; }

        public decimal? Bucha { get; set; }

        [StringLength(128)]
        public string HeadPortrait { get; set; }
    }
}
