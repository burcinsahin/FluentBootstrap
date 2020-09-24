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

            var panel = GetComponent<Panel>();
            if (panel != null && panel.Collapsible)
            {
                var link = GetHelper()
                    .Link(TextContent, $"#{panel.GetId()}_collapse")
                    .AddAttribute("data-toggle", "collapse");

                var accordionPanelGroup = GetComponent<AccordionPanelGroup>();
                if (accordionPanelGroup != null)
                {
                    link.AddAttribute("data-parent", $"#{accordionPanelGroup.GetAttribute("id")}");
                }

                AddChild(link);
                TextContent = null;
            }

            base.OnStart(writer);
        }
    }
}