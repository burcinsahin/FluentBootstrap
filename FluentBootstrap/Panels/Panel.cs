using FluentBootstrap.ListGroups;
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
