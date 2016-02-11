using QA.TestLibs.XmlDesiarilization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TConsole
{
    public class Hero : XmlBaseType
    {
        [XmlProperty("Link of hero")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Link", "link")]
        public HeroLink Link { get; set; }

        [XmlProperty("Text of hero")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Text", "text")]
        public HeroText Text { get; set; }

        public HeroImage Image { get; set; }

        [XmlProperty("Image direction of hero", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "ImageDirection", "imageDirection")]
        public HeroLayout Layout { get; set; }
    }

    public class HeroLayout : XmlBaseType
    {
        [XmlProperty("Breadcrumb of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Breadcrumbs", "breadcrumbs")]
        public bool Breadcrumbs { get; set; } = true;

        [XmlProperty("Overlay of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Overlay", "overlay")]
        public bool Overlay { get; set; } = true;

        [XmlProperty("Play Icon of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "PlayIcon", "playIcon")]
        public bool PlayIcon { get; set; }

        [XmlProperty("Embedded Video of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "EmbeddedVideo", "embeddedVideo")]
        public bool EmbeddedVideo { get; set; }

        [XmlConstraint("EmbeddedVideo", true)]
        [XmlProperty("Show Video In Full Width of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "ShowVideoInFullWidth", "showVideoInFullWidth")]
        public bool ShowVideoInFullWidth { get; set; } = false;

        [XmlConstraint("ShowVideoInFullWidth", true)]
        [XmlProperty("Start Playing Immediately of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "StartPlayingImmediately", "startPlayingImmediately")]
        public bool StartPlayingImmediately { get; set; }

        [XmlConstraint("ShowVideoInFullWidth", true)]
        [XmlProperty("Link Text of Layout-element")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "LinkText", "linkText")]
        public string LinkText { get; set; }

        [XmlProperty("Ancho rBox of Layout-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "AnchorBox", "anchorBox")]
        public bool AnchorBox { get; set; }

    }
}
