using System.IO;
using FluentBootstrap.ListGroups;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Panels
{
    public class Panel : Tag,
        ICanCreate<PanelSection>,
        ICanCreate<PanelTitle>,
        ICanCreate<ListGroup>
    {
        public bool Expanded { get; set; }
        public bool Collapsible { get; set; }

        internal Panel(BootstrapHelper helper)
            : base(helper, "div", Css.Panel, Css.PanelDefault)
        {
        }

        #region Overrides of Tag
        protected override void OnStart(TextWriter writer)
        {
            var accordionPanelGroup = GetComponent<AccordionPanelGroup>();
            if (accordionPanelGroup != null)
            {
                Collapsible = true;
                if (string.IsNullOrWhiteSpace(Id))
                    Id = $"{accordionPanelGroup.GetId()}_panel{accordionPanelGroup.PanelCounter}";
                accordionPanelGroup.PanelCounter++;
            }
            base.OnStart(writer);
        }
        #endregion
    }
}
