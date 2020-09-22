using System.ComponentModel;

namespace FluentBootstrap.Forms
{
    public enum InputSize
    {
        [Description()]
        Default,
        [Description(Css.InputLg)]
        Lg,
        [Description(Css.InputSm)]
        Sm
    }
}
