// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class PagesHealthCheck_domain : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The caa_error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaaError { get; set; }
#nullable restore
#else
        public string CaaError { get; set; }
#endif
        /// <summary>The dns_resolves property</summary>
        public bool? DnsResolves { get; set; }
        /// <summary>The enforces_https property</summary>
        public bool? EnforcesHttps { get; set; }
        /// <summary>The has_cname_record property</summary>
        public bool? HasCnameRecord { get; set; }
        /// <summary>The has_mx_records_present property</summary>
        public bool? HasMxRecordsPresent { get; set; }
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Host { get; set; }
#nullable restore
#else
        public string Host { get; set; }
#endif
        /// <summary>The https_error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HttpsError { get; set; }
#nullable restore
#else
        public string HttpsError { get; set; }
#endif
        /// <summary>The is_apex_domain property</summary>
        public bool? IsApexDomain { get; set; }
        /// <summary>The is_a_record property</summary>
        public bool? IsARecord { get; set; }
        /// <summary>The is_cloudflare_ip property</summary>
        public bool? IsCloudflareIp { get; set; }
        /// <summary>The is_cname_to_fastly property</summary>
        public bool? IsCnameToFastly { get; set; }
        /// <summary>The is_cname_to_github_user_domain property</summary>
        public bool? IsCnameToGithubUserDomain { get; set; }
        /// <summary>The is_cname_to_pages_dot_github_dot_com property</summary>
        public bool? IsCnameToPagesDotGithubDotCom { get; set; }
        /// <summary>The is_fastly_ip property</summary>
        public bool? IsFastlyIp { get; set; }
        /// <summary>The is_https_eligible property</summary>
        public bool? IsHttpsEligible { get; set; }
        /// <summary>The is_non_github_pages_ip_present property</summary>
        public bool? IsNonGithubPagesIpPresent { get; set; }
        /// <summary>The is_old_ip_address property</summary>
        public bool? IsOldIpAddress { get; set; }
        /// <summary>The is_pages_domain property</summary>
        public bool? IsPagesDomain { get; set; }
        /// <summary>The is_pointed_to_github_pages_ip property</summary>
        public bool? IsPointedToGithubPagesIp { get; set; }
        /// <summary>The is_proxied property</summary>
        public bool? IsProxied { get; set; }
        /// <summary>The is_served_by_pages property</summary>
        public bool? IsServedByPages { get; set; }
        /// <summary>The is_valid property</summary>
        public bool? IsValid { get; set; }
        /// <summary>The is_valid_domain property</summary>
        public bool? IsValidDomain { get; set; }
        /// <summary>The nameservers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nameservers { get; set; }
#nullable restore
#else
        public string Nameservers { get; set; }
#endif
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>The responds_to_https property</summary>
        public bool? RespondsToHttps { get; set; }
        /// <summary>The should_be_a_record property</summary>
        public bool? ShouldBeARecord { get; set; }
        /// <summary>The uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PagesHealthCheck_domain"/> and sets the default values.
        /// </summary>
        public PagesHealthCheck_domain()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PagesHealthCheck_domain"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PagesHealthCheck_domain CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PagesHealthCheck_domain();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"caa_error", n => { CaaError = n.GetStringValue(); } },
                {"dns_resolves", n => { DnsResolves = n.GetBoolValue(); } },
                {"enforces_https", n => { EnforcesHttps = n.GetBoolValue(); } },
                {"has_cname_record", n => { HasCnameRecord = n.GetBoolValue(); } },
                {"has_mx_records_present", n => { HasMxRecordsPresent = n.GetBoolValue(); } },
                {"host", n => { Host = n.GetStringValue(); } },
                {"https_error", n => { HttpsError = n.GetStringValue(); } },
                {"is_a_record", n => { IsARecord = n.GetBoolValue(); } },
                {"is_apex_domain", n => { IsApexDomain = n.GetBoolValue(); } },
                {"is_cloudflare_ip", n => { IsCloudflareIp = n.GetBoolValue(); } },
                {"is_cname_to_fastly", n => { IsCnameToFastly = n.GetBoolValue(); } },
                {"is_cname_to_github_user_domain", n => { IsCnameToGithubUserDomain = n.GetBoolValue(); } },
                {"is_cname_to_pages_dot_github_dot_com", n => { IsCnameToPagesDotGithubDotCom = n.GetBoolValue(); } },
                {"is_fastly_ip", n => { IsFastlyIp = n.GetBoolValue(); } },
                {"is_https_eligible", n => { IsHttpsEligible = n.GetBoolValue(); } },
                {"is_non_github_pages_ip_present", n => { IsNonGithubPagesIpPresent = n.GetBoolValue(); } },
                {"is_old_ip_address", n => { IsOldIpAddress = n.GetBoolValue(); } },
                {"is_pages_domain", n => { IsPagesDomain = n.GetBoolValue(); } },
                {"is_pointed_to_github_pages_ip", n => { IsPointedToGithubPagesIp = n.GetBoolValue(); } },
                {"is_proxied", n => { IsProxied = n.GetBoolValue(); } },
                {"is_served_by_pages", n => { IsServedByPages = n.GetBoolValue(); } },
                {"is_valid", n => { IsValid = n.GetBoolValue(); } },
                {"is_valid_domain", n => { IsValidDomain = n.GetBoolValue(); } },
                {"nameservers", n => { Nameservers = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"responds_to_https", n => { RespondsToHttps = n.GetBoolValue(); } },
                {"should_be_a_record", n => { ShouldBeARecord = n.GetBoolValue(); } },
                {"uri", n => { Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("caa_error", CaaError);
            writer.WriteBoolValue("dns_resolves", DnsResolves);
            writer.WriteBoolValue("enforces_https", EnforcesHttps);
            writer.WriteBoolValue("has_cname_record", HasCnameRecord);
            writer.WriteBoolValue("has_mx_records_present", HasMxRecordsPresent);
            writer.WriteStringValue("host", Host);
            writer.WriteStringValue("https_error", HttpsError);
            writer.WriteBoolValue("is_apex_domain", IsApexDomain);
            writer.WriteBoolValue("is_a_record", IsARecord);
            writer.WriteBoolValue("is_cloudflare_ip", IsCloudflareIp);
            writer.WriteBoolValue("is_cname_to_fastly", IsCnameToFastly);
            writer.WriteBoolValue("is_cname_to_github_user_domain", IsCnameToGithubUserDomain);
            writer.WriteBoolValue("is_cname_to_pages_dot_github_dot_com", IsCnameToPagesDotGithubDotCom);
            writer.WriteBoolValue("is_fastly_ip", IsFastlyIp);
            writer.WriteBoolValue("is_https_eligible", IsHttpsEligible);
            writer.WriteBoolValue("is_non_github_pages_ip_present", IsNonGithubPagesIpPresent);
            writer.WriteBoolValue("is_old_ip_address", IsOldIpAddress);
            writer.WriteBoolValue("is_pages_domain", IsPagesDomain);
            writer.WriteBoolValue("is_pointed_to_github_pages_ip", IsPointedToGithubPagesIp);
            writer.WriteBoolValue("is_proxied", IsProxied);
            writer.WriteBoolValue("is_served_by_pages", IsServedByPages);
            writer.WriteBoolValue("is_valid", IsValid);
            writer.WriteBoolValue("is_valid_domain", IsValidDomain);
            writer.WriteStringValue("nameservers", Nameservers);
            writer.WriteStringValue("reason", Reason);
            writer.WriteBoolValue("responds_to_https", RespondsToHttps);
            writer.WriteBoolValue("should_be_a_record", ShouldBeARecord);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
