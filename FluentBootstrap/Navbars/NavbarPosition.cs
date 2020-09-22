using System.ComponentModel;

namespace FluentBootstrap.Navbars
{
    public enum NavbarPosition
    {
        [Description()]
        Default,
        [Description(Css.NavbarFixedTop)]
        FixedTop,
        [Description(Css.NavbarFixedBottom)]
        FixedBottm,
        [Description(Css.NavbarStaticTop)]
        StaticTop
    }
}
