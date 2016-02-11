using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TestLibs.XmlDesiarilization;

namespace TConsole
{
    public class HeroAnchor : XmlBaseType
    {
        [XmlProperty("Text of hero-anchor", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Text", "text")]
        public HeroText Text { get; set; }

        [XmlProperty("Link of hero-anchor", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Link", "link")]
        public HeroLink Link { get; set; }

        [XmlProperty("Layout of hero-anchor", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public HeroAnchorLayout Layout { get; set; }

        public HeroImage Image { get; set; }

        public HeroImage Icon { get; set; }

    }

    public class HeroAnchorLayout : XmlBaseType
    {
        [XmlProperty("Vertical position of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "VerticalPosition", "varticalPosition")]
        public HeroAnchorLayoutVerticalPosition VerticalPosition { get; set; } = HeroAnchorLayoutVerticalPosition.Top;

        [XmlProperty("Horizontal position of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "HorizontalPosition", "horizantalPosition")]
        public HeroAnchorLayoutHorizontalPosition HorizontalPosition { get; set; } = HeroAnchorLayoutHorizontalPosition.Center;

        [XmlProperty("Arrow color of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "ArrowColor", "arrowColor")]
        public HeroAnchorArrowColor ArrowColor { get; set; } = HeroAnchorArrowColor.White;

        [XmlProperty("Is play icon of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "IconPlayed", "iconPlayed")]
        public bool IconPlayed { get; set; }
    }
}
