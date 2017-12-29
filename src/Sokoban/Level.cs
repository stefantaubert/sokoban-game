using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlTest
{
    public class Level
    {
        [XmlAttribute()]
        public string Id { get; set; }

        [XmlAttribute()]
        public int Width { get; set; }

        [XmlAttribute()]
        public int Height { get; set; }

        [XmlElement()]
        public string[] L { get; set; }
    }
}
