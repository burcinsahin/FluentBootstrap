using System.ComponentModel;

namespace FluentBootstrap.Paginations
{
    public enum PaginationSize
    {
        [Description()]
        Default,
        [Description(Css.PaginationLg)]
        Lg,
        [Description(Css.PaginationSm)]
        Sm
    }
}
