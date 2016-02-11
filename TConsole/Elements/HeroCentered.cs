using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TestLibs.XmlDesiarilization;

namespace TConsole
{
    public class HeroCentered : XmlBaseType
    {
        [XmlProperty("HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Text", "text")]
        public HeroCenteredText Text { get; set; }

        [XmlProperty("HeroCentered Links", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Links", "links")]
        public List<HeroLink> Links { get; set; }

        public HeroImage Image { get; set; }

        [XmlProperty("HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public HeroCenteredLayout Layout { get; set; }
    }

    [XmlType("Hero Centered Text")]
    [XmlLocation("heroCenteredText")]
    public class HeroCenteredText : XmlBaseType
    {
        [XmlProperty("Headline of HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "HeadLine", "headline")]
        public string HeadLine { get; set; }

        [XmlProperty("SubHeadline of HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "SubHeadLine", "subheadline", "subHeadline")]
        public string SubHeadLine { get; set; }

        [XmlProperty("Paragraph of HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Paragraph", "paragraph")]
        public string Paragraph { get; set; }

        [XmlProperty("Footnote of HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FootNote", "footnote", "footNote")]
        public string FootNote { get; set; }

        [XmlProperty("FontColor enum of HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FontColor", "fontcolor", "fontColor")]
        public HeroTextFontColor FontColor { get; set; } = HeroTextFontColor.Black;
    }

    
    [XmlType("Hero Centered Layout")]
    [XmlLocation("heroCenteredLayout")]
    public class HeroCenteredLayout : XmlBaseType
    {
        [XmlProperty("Style enum of HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Style", "style")]
        public HeroLayoutStyle Style { get; set; } = HeroLayoutStyle.Promo;

        [XmlProperty("Breadcrumbs of HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Breadcrumbs", "breadcrumbs")]
        public bool Breadcrumbs { get; set; }
    }
}
