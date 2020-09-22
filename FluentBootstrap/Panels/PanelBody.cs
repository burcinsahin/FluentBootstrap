using System.IO;
using FluentBootstrap.Html;

namespace FluentBootstrap.Panels
{
    public class PanelBody : PanelSection
    {
        internal PanelBody(BootstrapHelper helper)
            : base(helper, Css.PanelBody)
        {
        }

        #region Overrides of PanelSection
        protected override void OnStart(TextWriter writer)
        {
            var accordionPanelGroup = GetComponent<AccordionPanelGroup>();
            if (accordionPanelGroup != null)
            {
                var collapseId = $"{accordionPanelGroup.GetAttribute("id")}_panel{accordionPanelGroup.PanelCounter}";
                var builder = GetHelper().Div().AddCss(Css.PanelCollapse, Css.Collapse).SetId(collapseId);
                if (accordionPanelGroup.PanelCounter == 0) builder = builder.AddCss(Css.In);

                builder.Component.Start(writer);
                accordionPanelGroup.PanelCounter++;
            }
            base.OnStart(writer);
        }
        #endregion
    }
}
