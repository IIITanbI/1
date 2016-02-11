using QA.TestLibs.XmlDesiarilization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TConsole
{
    public class HeroLink : XmlBaseType
    {
        [XmlProperty("Link Name of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "LinkName", "linkName", "linkname")]
        public string LinkName { get; set; }

        [XmlProperty("Path of HeroCentered link")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Path", "path")]
        public string Path { get; set; }

        [XmlProperty("Target enum of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Target", "target")]
        public HeroLinkTargetWindow Target { get; set; } = HeroLinkTargetWindow.New;

        [XmlProperty("Displaymode enum of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "DisplayMode", "displayMode", "displaymode")]
        public HeroLinkDisplayMode DisplayMode { get; set; } = HeroLinkDisplayMode.Link;

        [XmlProperty("Tooltip of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Tooltip", "tooltip")]
        public string Tooltip { get; set; }
    }
    public class HeroText : XmlBaseType
    {
        [XmlProperty("Text headline of hero-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Headline", "headline", "HeadLine", "headLine")]
        public string Headline { get; set; }

        [XmlProperty("Paragraph of hero-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Paragraph", "paragraph")]
        public string Paragraph { get; set; }

        [XmlProperty("Text font Color of hero-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FontColor", "fontColor")]
        public HeroTextFontColor FontColor { get; set; }
    }
    public class HeroImage
    {
        public string ImageAltText { get; set; }
        public HeroImageDirection ImageDerection { get; set; }
    }
}
