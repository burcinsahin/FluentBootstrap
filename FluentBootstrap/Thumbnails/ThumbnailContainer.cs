using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Thumbnails
{
    public class ThumbnailContainer : Tag,
        ICanCreate<Thumbnail>,
        ICanCreate<Caption>
    {
        internal ThumbnailContainer(BootstrapHelper helper)
            : base(helper, "div", Css.Thumbnail)
        {
        }
    }
}
