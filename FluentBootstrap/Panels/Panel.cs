using FluentBootstrap.ListGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Panels
{
    public class Panel : Tag,
        ICanCreate<PanelSection>,
        ICanCreate<PanelTitle>,
        ICanCreate<ListGroup>
    {
        internal Panel(BootstrapHelper helper)
            : base(helper, "div", Css.Panel, Css.PanelDefault)
        {
        }
    }
}
