using System.ComponentModel;

namespace FluentBootstrap.Buttons
{
    public enum ButtonSize
    {
        [Description()]
        Default,
        [Description(Css.BtnLg)]
        Lg,
        [Description(Css.BtnSm)]
        Sm,
        [Description(Css.BtnXs)]
        Xs
    }
}
