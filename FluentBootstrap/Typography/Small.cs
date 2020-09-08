using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Typography
{
    public class Small : Tag, IHasTextContent
    {
        internal Small(BootstrapHelper helper)
            : base(helper, "small")
        {
        }
    }
}
