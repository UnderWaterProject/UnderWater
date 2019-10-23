using System;
using System.Xml;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnderWater
{
    class OpenReadXml
    {
        public Dictionary<Label, EventClass> dict;

        public OpenReadXml(String path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlNode root = xmlDocument.SelectSingleNode("Node");
            dict = new Dictionary<Label, EventClass>();
            travelXml(root);
        }

        private void travelXml(XmlNode root)
        {
            EventClass eventClass = convert(root);
            
            List<String> childList = new List<string>();
            if (root.ChildNodes != null)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    if (root.ChildNodes[i].Name.Equals("Node"))
                    {
                        XmlNode child = root.ChildNodes[i];
                        childList.Add(child.Attributes[2].Value);
                        travelXml(child);
                    }
                }
                eventClass.childList = childList;
            }
            Label label = Utils.util.CreateLabel(eventClass.currentEventName, eventClass.eventEnglishName);
            dict.Add(label, eventClass);
        }

        private EventClass convert(XmlNode node)
        {
            XmlAttributeCollection collection = node.Attributes;
            EventClass e = new EventClass(collection[0].Value, collection[1].Value, collection[2].Value, collection[3].Value, collection[4].Value);
            e.layer = Convert.ToInt32(collection[5].Value);
            return e;
        }

    }
}
