using System.ComponentModel;

namespace FluentBootstrap.Wells
{
    public enum WellSize
    {
        [Description()]
        Default,
        [Description(Css.WellLg)]
        Lg,
        [Description(Css.WellSm)]
        Sm
    }
}
