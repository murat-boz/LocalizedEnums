using LocalizedEnums.WPF.Resources;
using System.ComponentModel;

namespace LocalizedEnums.WPF
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {
        [LocalizedDescription("Bad", typeof(EnumResource))]
        Bad,
        [LocalizedDescription("Good", typeof(EnumResource))]
        Good
    }
}
