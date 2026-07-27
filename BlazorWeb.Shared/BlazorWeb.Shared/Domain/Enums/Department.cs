using System.ComponentModel;

namespace BlazorWeb.Shared.Domain.Enums
{
    public enum Department
    {
        [Description("AA Research")]
        AfricanAmericanResearch,
        [Description("LA Research")]
        LatinAmericanResearch,
        [Description("RA Research")]
        WhiteAmericanResearch,
        [Description("A Research")]
        AsianResearch
    }
}
