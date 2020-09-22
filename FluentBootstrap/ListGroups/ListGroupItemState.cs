using System.ComponentModel;

namespace FluentBootstrap.ListGroups
{
    public enum ListGroupItemState
    {
        [Description()]
        Default,
        [Description(Css.ListGroupItemSuccess)]
        Success,
        [Description(Css.ListGroupItemInfo)]
        Info,
        [Description(Css.ListGroupItemWarning)]
        Warning,
        [Description(Css.ListGroupItemDanger)]
        Danger
    }
}
