using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlTest
{
    public class SokobanLevels
    {
        [XmlElement()]
        public string Title { get; set; }

        [XmlElement()]
        public string Description { get; set; }

        [XmlElement()]
        public LevelCollection LevelCollection { get; set; }
    }
}
