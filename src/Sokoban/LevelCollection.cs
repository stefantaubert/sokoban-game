using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlTest
{
    public class LevelCollection
    {
        [XmlAttribute()]
        public string Copyright { get; set; }

        [XmlAttribute()]
        public int MaxWidth { get; set; }

        [XmlAttribute()]
        public int MaxHeight{get;set;}
        
        [XmlElement()]
        public Level[] Level { get; set; }
    }
}
