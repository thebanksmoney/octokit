// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Issues.Item.Labels {
    public class LabelsPostRequestBodyMember2 : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LabelsPostRequestBodyMember2_labels>? Labels { get; set; }
#nullable restore
#else
        public List<LabelsPostRequestBodyMember2_labels> Labels { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="LabelsPostRequestBodyMember2"/> and sets the default values.
        /// </summary>
        public LabelsPostRequestBodyMember2()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LabelsPostRequestBodyMember2"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LabelsPostRequestBodyMember2 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LabelsPostRequestBodyMember2();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"labels", n => { Labels = n.GetCollectionOfObjectValues<LabelsPostRequestBodyMember2_labels>(LabelsPostRequestBodyMember2_labels.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<LabelsPostRequestBodyMember2_labels>("labels", Labels);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
