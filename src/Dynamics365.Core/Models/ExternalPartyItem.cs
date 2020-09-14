using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ExternalPartyItem : DynamicsModel
    {
        [JsonProperty("externalpartyid")]
        public string ExternalPartyId { get; set; }

        [JsonProperty("lastenabledon")]
        public DateTimeOffset? LastEnabledOn { get; set; }

        [JsonProperty("lastdisabledon")]
        public DateTimeOffset? LastDisabledOn { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("channelaccessprofileid")]
        public string ChannelAccessProfileId { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("channelaccessprofileidname")]
        public string ChannelAccessProfileIdName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalpartyidname")]
        public string ExternalPartyIdName { get; set; }

        [JsonProperty("externalpartyitemid")]
        public Guid? ExternalPartyItemId { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectiddsc")]
        public long? RegardingObjectIdDsc { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }


    }
}

