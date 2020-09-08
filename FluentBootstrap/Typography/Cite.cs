using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Typography
{
    public class Cite : Tag, IHasTextContent, IHasTitleAttribute
    {
        internal Cite(BootstrapHelper helper)
            : base(helper, "cite")
        {
        }
    }
}
