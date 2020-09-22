using FluentBootstrap.Badges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.ListGroups
{
    public class ListGroup : Tag,
        ICanCreate<ListGroupItem>,
        ICanCreate<ListGroupButton>
    {
        internal ListGroup(BootstrapHelper helper)
            : base(helper, "div", Css.ListGroup)
        {
        }
    }
}
