using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TestLibs.XmlDesiarilization;

namespace TConsole
{
    public class HeroCarousel : XmlBaseType
    {
        [XmlProperty("HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public List<HeroCarouselItem> Items { get; set; }

        [XmlProperty("HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public string MainTheme { get; set; }

        [XmlProperty("HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public HeroCarouselTransitionMode TransitionMode { get; set; } = HeroCarouselTransitionMode.Manual;

        [XmlProperty("HeroCentered Layout")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public int RotationTime { get; set; }

        [XmlProperty("HeroCentered Layout")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public int TransitionTime { get; set; }
    }

    [XmlType("Hero Centered Text")]
    [XmlLocation("heroCenteredText")]
    public class HeroCarouselItem : XmlBaseType
    {
        public HeroCarouselItemText Text { get; set; }
        public HeroImage Image { get; set; }
        public HeroLink Link { get; set; }
    }

    public class HeroCarouselItemText
    {
        [XmlProperty("Headline of HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "HeadLine", "headline")]
        public string HeadLine { get; set; }

        [XmlProperty("Paragraph of HeroCentered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Paragraph", "paragraph")]
        public string Paragraph { get; set; }

        [XmlProperty("Font Color enum of HeroCarousel Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FontColor", "fontcolor", "fontColor")]
        public HeroTextFontColor FontColor { get; set; } = HeroTextFontColor.Black;

        [XmlProperty("Main Theme Color enum of HeroCarousel Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FontColor", "fontcolor", "fontColor")]
        public HeroTextMainThemeColor MainThemeColor { get; set; } = HeroTextMainThemeColor.Black;
    }

    [XmlType("Hero Centered Layout")]
    [XmlLocation("heroCenteredLayout")]
    public class HeroCarouselItemLayout : XmlBaseType
    {
        [XmlProperty("Breadcrumbs of HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Overlay", "overlay")]
        public bool Overlay { get; set; }

        [XmlProperty("Breadcrumbs of HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Breadcrumbs", "breadcrumbs")]
        public bool PlayIcon { get; set; }

        [XmlProperty("Breadcrumbs of HeroCentered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Breadcrumbs", "breadcrumbs")]
        public bool EmbeddedVideo { get; set; }
    }
}
