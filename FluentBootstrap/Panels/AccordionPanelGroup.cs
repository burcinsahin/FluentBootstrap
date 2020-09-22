using System;
using System.IO;
using FluentBootstrap.Interfaces;

namespace FluentBootstrap.Panels
{
    public class AccordionPanelGroup : Tag, ICanCreate<Panel>
    {
        internal int PanelCounter { get; set; }

        public AccordionPanelGroup(BootstrapHelper helper)
            : base(helper, "div", Css.PanelGroup)
        {
        }

        #region Overrides of Tag
        protected override void OnStart(TextWriter writer)
        {
            if (string.IsNullOrWhiteSpace(GetAttribute("id")))
            {
                GetBuilder(this).SetId($"accordion{DateTime.Now.Ticks}");
            }
            base.OnStart(writer);
        }
        #endregion
    }
}
