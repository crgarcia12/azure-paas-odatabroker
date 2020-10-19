using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdataBroker.Models
{
    public class InsurancePolicy
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public string Agency__c { get; set; }
        public string Assistance__c { get; set; }
        public int InsurancePolicyAssetsQuantity__c { get; set; }
        public string Certificate__c { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RiskDetail__c { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string EmailPolicy__c { get; set; }
        public string StatusClient__c { get; set; }
        public string StatusProducer__c { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ExternalId__c { get; set; }
        public DateTime EffectiveDatePaymentSuspension__c { get; set; }
        public DateTime ExpirationDatePaymentSuspension__c { get; set; }
        public DateTime EffectiveDateTop__c { get; set; }
        public string Frequency__c { get; set; }
        public int AutomaticIncrement__c { get; set; }
        public string CurrencyIndex__c { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string Currency__c { get; set; }
        public string Business__c { get; set; }
        public bool HasPendingOperation__c { get; set; }
        public string LogicOrder__c { get; set; }
        public string ParentPolicyId { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public string PlanTier { get; set; }
        public string PlanType { get; set; }
        public int TimeLimit__c { get; set; }
        public string PolicyDescription { get; set; }
        public string PolicyName { get; set; }
        public string Name { get; set; }
        public string PolicyType { get; set; }
        public bool InsurancePolicyError__c { get; set; }
        public bool InsurancePolicyUnderMaintenance__c { get; set; }
        public bool InsurancePolicyDataCheck__c { get; set; }
        public bool InsurancePolicyWindBack__c { get; set; }
        public int PremiumAmount { get; set; }
        public string PremiumFrequency { get; set; }
        public int PrimeAmount__c { get; set; }
        public int PrimeVRUAmount__c { get; set; }
        public string PriorPolicyId { get; set; }
        public string ProducerId { get; set; }
        public string ProductId { get; set; }
        public string Branch__c { get; set; }
        public DateTime SaleDate { get; set; }
        public string Status { get; set; }
        public string Substatus { get; set; }
        public string PayerType__c { get; set; }
        public string PaymentType__c { get; set; }
        public string TypeProducer__c { get; set; }
    }
}
