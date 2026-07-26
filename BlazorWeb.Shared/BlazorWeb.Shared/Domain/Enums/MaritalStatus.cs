using System.ComponentModel;

namespace BlazorWeb.Shared.Domain.Enums
{
    public enum MaritalStatus
    {
        [Description("Married")]
        Married,
        [Description("Married with kids")]
        MarriedWithKids,
        [Description("Not Married")]
        NotMarried,
        [Description("Single")]
        Single,
        [Description("Single with kids")]
        SingleWithKids,
        Other
    }
}
