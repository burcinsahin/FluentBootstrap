using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Dropdowns
{
    public class DropdownHeader : Tag, IHasTextContent
    {
        internal DropdownHeader(BootstrapHelper helper)
            : base(helper, "li", Css.DropdownHeader)
        {
            MergeAttribute("role", "presentation");
        }
    }
}
