// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>**Required when the state is dismissed.** The reason for dismissing or closing the alert.</summary>
    public enum CodeScanningAlertDismissedReason
    {
        [EnumMember(Value = "false positive")]
        FalsePositive,
        [EnumMember(Value = "won't fix")]
        WonTFix,
        [EnumMember(Value = "used in tests")]
        UsedInTests,
    }
}
