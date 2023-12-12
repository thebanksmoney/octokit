// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class DependencyGraphSpdxSbom_sbom_packages : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The location where the package can be downloaded,or NOASSERTION if this has not been determined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DownloadLocation { get; set; }
#nullable restore
#else
        public string DownloadLocation { get; set; }
#endif
        /// <summary>The externalRefs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DependencyGraphSpdxSbom_sbom_packages_externalRefs>? ExternalRefs { get; set; }
#nullable restore
#else
        public List<DependencyGraphSpdxSbom_sbom_packages_externalRefs> ExternalRefs { get; set; }
#endif
        /// <summary>Whether the package&apos;s file content has been subjected toanalysis during the creation of the SPDX document.</summary>
        public bool? FilesAnalyzed { get; set; }
        /// <summary>The license of the package as determined while creating the SPDX document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseConcluded { get; set; }
#nullable restore
#else
        public string LicenseConcluded { get; set; }
#endif
        /// <summary>The license of the package as declared by its author, or NOASSERTION if this informationwas not available when the SPDX document was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseDeclared { get; set; }
#nullable restore
#else
        public string LicenseDeclared { get; set; }
#endif
        /// <summary>The name of the package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>A unique SPDX identifier for the package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SPDXID { get; set; }
#nullable restore
#else
        public string SPDXID { get; set; }
#endif
        /// <summary>The distribution source of this package, or NOASSERTION if this was not determined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Supplier { get; set; }
#nullable restore
#else
        public string Supplier { get; set; }
#endif
        /// <summary>The version of the package. If the package does not have an exact version specified,a version range is given.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionInfo { get; set; }
#nullable restore
#else
        public string VersionInfo { get; set; }
#endif
        /// <summary>
        /// Instantiates a new dependencyGraphSpdxSbom_sbom_packages and sets the default values.
        /// </summary>
        public DependencyGraphSpdxSbom_sbom_packages() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependencyGraphSpdxSbom_sbom_packages CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependencyGraphSpdxSbom_sbom_packages();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"downloadLocation", n => { DownloadLocation = n.GetStringValue(); } },
                {"externalRefs", n => { ExternalRefs = n.GetCollectionOfObjectValues<DependencyGraphSpdxSbom_sbom_packages_externalRefs>(DependencyGraphSpdxSbom_sbom_packages_externalRefs.CreateFromDiscriminatorValue)?.ToList(); } },
                {"filesAnalyzed", n => { FilesAnalyzed = n.GetBoolValue(); } },
                {"licenseConcluded", n => { LicenseConcluded = n.GetStringValue(); } },
                {"licenseDeclared", n => { LicenseDeclared = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"SPDXID", n => { SPDXID = n.GetStringValue(); } },
                {"supplier", n => { Supplier = n.GetStringValue(); } },
                {"versionInfo", n => { VersionInfo = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("downloadLocation", DownloadLocation);
            writer.WriteCollectionOfObjectValues<DependencyGraphSpdxSbom_sbom_packages_externalRefs>("externalRefs", ExternalRefs);
            writer.WriteBoolValue("filesAnalyzed", FilesAnalyzed);
            writer.WriteStringValue("licenseConcluded", LicenseConcluded);
            writer.WriteStringValue("licenseDeclared", LicenseDeclared);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("SPDXID", SPDXID);
            writer.WriteStringValue("supplier", Supplier);
            writer.WriteStringValue("versionInfo", VersionInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}