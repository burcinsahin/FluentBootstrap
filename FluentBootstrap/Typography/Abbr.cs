using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Typography
{
    public class Abbr : Tag, IHasTextContent, IHasTitleAttribute
    {
        internal Abbr(BootstrapHelper helper)
            : base(helper, "abbr")
        {
        }
    }
}
