using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Panels
{
    public class PanelHeading : PanelSection,
        ICanCreate<PanelTitle>        
    {
        internal PanelHeading(BootstrapHelper helper)
            : base(helper, Css.PanelHeading)
        {
        }
    }
}
