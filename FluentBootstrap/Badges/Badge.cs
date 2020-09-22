﻿using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Badges
{
    public class Badge : Tag, IHasTextContent
    {
        internal Badge(BootstrapHelper helper)
            : base(helper, "span", Css.Badge)
        {
        }
    }
}
