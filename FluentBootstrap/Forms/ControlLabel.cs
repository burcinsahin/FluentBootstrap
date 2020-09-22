﻿using FluentBootstrap.Grids;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Forms
{
    public class ControlLabel : Tag, IHasGridColumnExtensions, IHasTextContent
    {
        internal ControlLabel(BootstrapHelper helper, object text)
            : base(helper, "label", Css.ControlLabel)
        {
            TextContent = text;
        }
    }
}
