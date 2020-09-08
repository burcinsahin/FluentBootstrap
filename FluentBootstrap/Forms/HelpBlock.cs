using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Forms
{
    public class HelpBlock : Tag, IHasTextContent
    {
        internal HelpBlock(BootstrapHelper helper)
            : base(helper, "div", Css.HelpBlock)
        {
        }
    }
}
