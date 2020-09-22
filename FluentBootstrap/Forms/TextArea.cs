using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Forms
{
    public class TextArea : FormControl, IHasNameAttribute, IHasMaxLengthAttribute
    {
        internal TextArea(BootstrapHelper helper)
            : base(helper, "textarea", Css.FormControl)
        {
        }
    }
}
