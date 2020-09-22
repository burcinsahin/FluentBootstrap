using System.ComponentModel;

namespace FluentBootstrap.Pagers
{
    public enum PageAlignment
    {
        [Description()]
        Default,
        [Description(Css.Previous)]
        Previous,
        [Description(Css.Next)]
        Next
    }
}
