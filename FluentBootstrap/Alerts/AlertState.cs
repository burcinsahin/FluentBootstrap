using System.ComponentModel;

namespace FluentBootstrap.Alerts
{
    public enum AlertState
    {
        [Description(Css.AlertSuccess)]
        Success,
        [Description(Css.AlertInfo)]
        Info,
        [Description(Css.AlertWarning)]
        Warning,
        [Description(Css.AlertDanger)]
        Danger
    }
}
