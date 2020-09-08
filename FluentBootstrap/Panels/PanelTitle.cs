﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Panels
{
    public class PanelTitle : Tag, IHasTextContent
    {
        internal PanelTitle(BootstrapHelper helper, object text, int headingLevel)
            : base(helper, "h" + headingLevel, Css.PanelTitle)
        {
            if (headingLevel < 1 || headingLevel > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(headingLevel));
            }
            TextContent = text;
        }

        protected override void OnStart(TextWriter writer)
        {
            // Make sure we're in a PanelHeading
            if (GetComponent<PanelHeading>() == null)
            {
                GetHelper().PanelHeading().Component.Start(writer);
            }

            base.OnStart(writer);
        }
    }
}
