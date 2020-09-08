﻿using System.ComponentModel;

namespace FluentBootstrap.ProgressBars
{
    public enum ProgressBarState
    {
        [Description()]
        None,
        [Description(Css.ProgressBarSuccess)]
        Success,
        [Description(Css.ProgressBarInfo)]
        Info,
        [Description(Css.ProgressBarWarning)]
        Warning,
        [Description(Css.ProgressBarDanger)]
        Danger
    }
}
