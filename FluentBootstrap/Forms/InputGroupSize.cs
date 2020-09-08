using System.ComponentModel;

namespace FluentBootstrap.Forms
{
    public enum InputGroupSize
    {
        [Description()]
        Default,
        [Description(Css.InputGroupLg)]
        Lg,
        [Description(Css.InputGroupSm)]
        Sm
    }
}
