using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.MediaObjects
{
    public class MediaList : Tag,
        ICanCreate<Media>
    {
        internal MediaList(BootstrapHelper helper)
            : base(helper, "ul", Css.MediaList)
        {
        }
    }
}
