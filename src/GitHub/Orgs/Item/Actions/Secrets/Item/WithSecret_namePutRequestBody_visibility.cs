// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item.Actions.Secrets.Item {
    /// <summary>Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.</summary>
    public enum WithSecret_namePutRequestBody_visibility
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "selected")]
        Selected,
    }
}
