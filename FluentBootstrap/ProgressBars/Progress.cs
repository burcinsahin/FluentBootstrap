using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.ProgressBars
{
    public class Progress : Tag,
        ICanCreate<ProgressBar>
    {
        internal Progress(BootstrapHelper helper)
            : base(helper, "div", Css.Progress)
        {
        }
    }
}
