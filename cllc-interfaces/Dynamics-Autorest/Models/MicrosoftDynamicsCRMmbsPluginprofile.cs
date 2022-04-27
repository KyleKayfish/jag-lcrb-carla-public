// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.mbs_pluginprofile
    /// </summary>
    public partial class MicrosoftDynamicsCRMmbsPluginprofile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmbsPluginprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMmbsPluginprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmbsPluginprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMmbsPluginprofile(int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string mbsTypename = default(string), int? statuscode = default(int?), string mbsWorkflowstepid = default(string), string _createdbyValue = default(string), int? mbsMode = default(int?), string mbsCorrelationid = default(string), int? mbsPerformanceexecutionduration = default(int?), int? statecode = default(int?), string mbsConfiguration = default(string), string mbsLabel = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? mbsPerformanceconstructorstarttime = default(System.DateTimeOffset?), string _mbsInitiatinguseridValue = default(string), int? mbsDepth = default(int?), string mbsProfile = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string mbsSecureconfiguration = default(string), string mbsPluginprofileid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string mbsMessagename = default(string), string mbsPersistencekey = default(string), string mbsPrimaryentity = default(string), System.DateTimeOffset? mbsPerformanceexecutionstarttime = default(System.DateTimeOffset?), string mbsRequestid = default(string), int? mbsPerformanceconstructorduration = default(int?), int? mbsOperationtype = default(int?), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), string _mbsBusinessunitidValue = default(string), string _modifiedbyValue = default(string), int? importsequencenumber = default(int?), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> mbsPluginprofileSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> mbsPluginprofileAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> mbsPluginprofileMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> mbsPluginprofileProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> mbsPluginprofileBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> mbsPluginprofilePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMbusinessunit mbsBusinessUnitId = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser mbsInitiatingUserId = default(MicrosoftDynamicsCRMsystemuser))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            MbsTypename = mbsTypename;
            Statuscode = statuscode;
            MbsWorkflowstepid = mbsWorkflowstepid;
            this._createdbyValue = _createdbyValue;
            MbsMode = mbsMode;
            MbsCorrelationid = mbsCorrelationid;
            MbsPerformanceexecutionduration = mbsPerformanceexecutionduration;
            Statecode = statecode;
            MbsConfiguration = mbsConfiguration;
            MbsLabel = mbsLabel;
            Overriddencreatedon = overriddencreatedon;
            MbsPerformanceconstructorstarttime = mbsPerformanceconstructorstarttime;
            this._mbsInitiatinguseridValue = _mbsInitiatinguseridValue;
            MbsDepth = mbsDepth;
            MbsProfile = mbsProfile;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            MbsSecureconfiguration = mbsSecureconfiguration;
            MbsPluginprofileid = mbsPluginprofileid;
            Createdon = createdon;
            MbsMessagename = mbsMessagename;
            MbsPersistencekey = mbsPersistencekey;
            MbsPrimaryentity = mbsPrimaryentity;
            MbsPerformanceexecutionstarttime = mbsPerformanceexecutionstarttime;
            MbsRequestid = mbsRequestid;
            MbsPerformanceconstructorduration = mbsPerformanceconstructorduration;
            MbsOperationtype = mbsOperationtype;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            this._mbsBusinessunitidValue = _mbsBusinessunitidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MbsPluginprofileSyncErrors = mbsPluginprofileSyncErrors;
            MbsPluginprofileAsyncOperations = mbsPluginprofileAsyncOperations;
            MbsPluginprofileMailboxTrackingFolders = mbsPluginprofileMailboxTrackingFolders;
            MbsPluginprofileProcessSession = mbsPluginprofileProcessSession;
            MbsPluginprofileBulkDeleteFailures = mbsPluginprofileBulkDeleteFailures;
            MbsPluginprofilePrincipalObjectAttributeAccesses = mbsPluginprofilePrincipalObjectAttributeAccesses;
            MbsBusinessUnitId = mbsBusinessUnitId;
            MbsInitiatingUserId = mbsInitiatingUserId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_typename")]
        public string MbsTypename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_workflowstepid")]
        public string MbsWorkflowstepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_mode")]
        public int? MbsMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_correlationid")]
        public string MbsCorrelationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_performanceexecutionduration")]
        public int? MbsPerformanceexecutionduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_configuration")]
        public string MbsConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_label")]
        public string MbsLabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_performanceconstructorstarttime")]
        public System.DateTimeOffset? MbsPerformanceconstructorstarttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_mbs_initiatinguserid_value")]
        public string _mbsInitiatinguseridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_depth")]
        public int? MbsDepth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_profile")]
        public string MbsProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_secureconfiguration")]
        public string MbsSecureconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_pluginprofileid")]
        public string MbsPluginprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_messagename")]
        public string MbsMessagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_persistencekey")]
        public string MbsPersistencekey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_primaryentity")]
        public string MbsPrimaryentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_performanceexecutionstarttime")]
        public System.DateTimeOffset? MbsPerformanceexecutionstarttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_requestid")]
        public string MbsRequestid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_performanceconstructorduration")]
        public int? MbsPerformanceconstructorduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_operationtype")]
        public int? MbsOperationtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_mbs_businessunitid_value")]
        public string _mbsBusinessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_pluginprofile_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MbsPluginprofileSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_pluginprofile_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MbsPluginprofileAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_pluginprofile_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MbsPluginprofileMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_pluginprofile_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MbsPluginprofileProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_pluginprofile_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MbsPluginprofileBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_pluginprofile_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MbsPluginprofilePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_BusinessUnitId")]
        public MicrosoftDynamicsCRMbusinessunit MbsBusinessUnitId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mbs_InitiatingUserId")]
        public MicrosoftDynamicsCRMsystemuser MbsInitiatingUserId { get; set; }

    }
}