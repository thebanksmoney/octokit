// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class RepositoryAdvisoryCreate_vulnerabilities : IParsable 
    {
        /// <summary>The name of the package affected by the vulnerability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryAdvisoryCreate_vulnerabilities_package? Package { get; set; }
#nullable restore
#else
        public RepositoryAdvisoryCreate_vulnerabilities_package Package { get; set; }
#endif
        /// <summary>The package version(s) that resolve the vulnerability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PatchedVersions { get; set; }
#nullable restore
#else
        public string PatchedVersions { get; set; }
#endif
        /// <summary>The functions in the package that are affected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? VulnerableFunctions { get; set; }
#nullable restore
#else
        public List<string> VulnerableFunctions { get; set; }
#endif
        /// <summary>The range of the package versions affected by the vulnerability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VulnerableVersionRange { get; set; }
#nullable restore
#else
        public string VulnerableVersionRange { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RepositoryAdvisoryCreate_vulnerabilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryAdvisoryCreate_vulnerabilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryAdvisoryCreate_vulnerabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"package", n => { Package = n.GetObjectValue<RepositoryAdvisoryCreate_vulnerabilities_package>(RepositoryAdvisoryCreate_vulnerabilities_package.CreateFromDiscriminatorValue); } },
                {"patched_versions", n => { PatchedVersions = n.GetStringValue(); } },
                {"vulnerable_functions", n => { VulnerableFunctions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"vulnerable_version_range", n => { VulnerableVersionRange = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RepositoryAdvisoryCreate_vulnerabilities_package>("package", Package);
            writer.WriteStringValue("patched_versions", PatchedVersions);
            writer.WriteCollectionOfPrimitiveValues<string>("vulnerable_functions", VulnerableFunctions);
            writer.WriteStringValue("vulnerable_version_range", VulnerableVersionRange);
        }
    }
}
