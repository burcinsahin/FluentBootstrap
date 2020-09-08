using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Labels
{
    public class Label : Tag, IHasTextContent
    {
        internal Label(BootstrapHelper helper)
            : base(helper, "span", Css.Label, Css.LabelDefault)
        {
        }
    }
}
