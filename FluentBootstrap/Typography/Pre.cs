using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Typography
{
    public class Pre : Tag, IHasTextContent
    {
        internal Pre(BootstrapHelper helper)
            : base(helper, "pre")
        {
        }
    }
}
