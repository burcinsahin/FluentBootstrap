using System;
using System.IO;
using FluentBootstrap.Interfaces;
using FluentBootstrap.Links;

namespace FluentBootstrap.Panels
{
    public class PanelTitle : Tag, IHasTextContent, ICanCreate<Link>
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

            var accordionPanelGroup = GetComponent<AccordionPanelGroup>();
            if (accordionPanelGroup != null)
            {
                var link = GetHelper()
                    .Link(TextContent, $"#{accordionPanelGroup.GetAttribute("id")}_panel{accordionPanelGroup.PanelCounter}")
                    .AddAttribute("data-toggle", "collapse")
                    .AddAttribute("data-parent", $"#{accordionPanelGroup.GetAttribute("id")}");
                AddChild(link);
                TextContent = null;
            }

            base.OnStart(writer);
        }
    }
}