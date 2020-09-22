using System.ComponentModel;

namespace FluentBootstrap.Buttons
{
    public enum ButtonGroupSize
    {
        [Description()]
        Default,
        [Description(Css.BtnGroupLg)]
        Lg,
        [Description(Css.BtnGroupSm)]
        Sm,
        [Description(Css.BtnGroupXs)]
        Xs
    }
}
