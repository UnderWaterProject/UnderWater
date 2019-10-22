using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;

namespace UnderWater
{
    class Utils
    {

        public static Utils util;

        public Utils()
        {
            util = this;
        }

        public Label CreateLabel(string currentEventName, string eventEnglishName)
        {
            Label eventLabel = new Label();

            eventLabel.Font = new Font("宋体", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //eventLabel.Location = eventLocation;
            eventLabel.Name = eventEnglishName;
            eventLabel.Size = new Size(70, 20);
            eventLabel.BackColor = Color.YellowGreen;
            eventLabel.BorderStyle = BorderStyle.FixedSingle;
            eventLabel.TextAlign = ContentAlignment.MiddleCenter;
            eventLabel.Text = currentEventName;

            eventLabel.Click += new EventHandler(OnClick_Event);

            MainBody.Instance.mainBody.Controls.Add(eventLabel);
            return eventLabel;
        }

        private void OnClick_Event(object sender, EventArgs e)
        {
            OnClick_Common(sender, e);
        }

        public void OnClick_Common(object sender, EventArgs e)
        {
            MouseEventArgs onClick = (MouseEventArgs)e;
            if (onClick.Button == MouseButtons.Left)
            {

            }
            else if (onClick.Button == MouseButtons.Right)
            {
                EventMenu.Instance.eventMenu.Controls["ParentEventName"].Text = ((Label)sender).Name;
                MoveMenu.Instance.moveMenu.Visible = true;

                MainBody.Instance.mainBody.Controls.Add(MoveMenu.Instance.moveMenu);
                MoveMenu.Instance.moveMenu.Location = new Point(((Label)sender).Location.X + 70, ((Label)sender).Location.Y + 20);
            }
        }

        public XmlDocument ObjToXml(Dictionary<Label, EventClass> dict, String rootName)
        {
            Label label = (Label)MainBody.Instance.mainBody.Controls[rootName];
            XmlDocument xmldoc = new XmlDocument();
            XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmldoc.AppendChild(xmldecl);
            XmlElement root = xmldoc.CreateElement("Node");
            setAttributeToNode(root, dict[label]);
            EventClass eRoot = dict[label];
            xmldoc.AppendChild(root);
            travelTree(root, eRoot.childList, dict, xmldoc);
            return xmldoc;
        }

        private void travelTree(XmlElement node, List<String> childs, Dictionary<Label, EventClass> dict, XmlDocument xmldoc)
        {
            if (node == null)
                return;
            foreach (String s in childs) {
                Label label = (Label)MainBody.Instance.mainBody.Controls[s];
                EventClass eventClass = dict[label];
                XmlElement tmp = xmldoc.CreateElement("Node");
                setAttributeToNode(tmp, dict[label]);
                node.AppendChild(tmp);
                travelTree(tmp, eventClass.childList, dict, xmldoc);
            }
        }

        private void setAttributeToNode(XmlElement node, EventClass eventClass)
        {
            node.SetAttribute("parentEventName", eventClass.parentEventName);
            node.SetAttribute("currentEventName", eventClass.currentEventName);
            node.SetAttribute("eventEnglishName", eventClass.eventEnglishName);
            node.SetAttribute("eventLevel", eventClass.eventLevel);
            node.SetAttribute("operatorType", eventClass.operatorType);
            node.SetAttribute("layer", eventClass.layer.ToString());
        }

    }
}
