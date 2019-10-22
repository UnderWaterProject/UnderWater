using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UnderWater
{
    class TopMenu
    {
        ToolStripMenuItem newFile;
        ToolStripMenuItem openFile;
        ToolStripMenuItem saveFile;

        public TopMenu()
        {
            Init();
        }

        public void Init()
        {
            MenuStrip topMenu = (MenuStrip)MainForm.Instance.Controls["TopMenu"];

            newFile = (ToolStripMenuItem)topMenu.Items["NewEventFile"];
            newFile.Click += new EventHandler(OnClick_NewFile);

            openFile = (ToolStripMenuItem)topMenu.Items["OpenEventFile"];
            openFile.Click += new EventHandler(OnClick_OpenFile);

            saveFile = (ToolStripMenuItem)topMenu.Items["SaveEventFile"];
            saveFile.Click += new EventHandler(OnClick_SaveFile);

        }

        private void OnClick_NewFile(object sender, EventArgs e)
        {
            //弹出事件创建框
            EventMenu.Instance.eventMenu.Visible = true;
        }

        private void OnClick_OpenFile(object sender, EventArgs e)
        {
            String fileName = string.Empty;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "xml";
            dlg.Filter = "Xml Files|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
                fileName = dlg.FileName;
            if (fileName == null)
                return;
            OpenReadXml openReadXml = new OpenReadXml(fileName);
            EventInfo.Instance.eventInfoDic = openReadXml.dict;
            EventInfo.Instance.ResetEventTree();
            foreach (var item in openReadXml.dict)
            {
                Console.Write(item.Key.Name + " : ");
                Console.WriteLine(item.Value.ToString());
            }
        }

        private void OnClick_SaveFile(object sender, EventArgs e)
        {
            // 另存为 xml 文件
            Utils u = new Utils();
            Dictionary<Label, EventClass> dict = EventInfo.Instance.eventInfoDic;
            String rootName = "";
            foreach (EventClass item in dict.Values) {
                if (item.eventLevel == "TOP") {
                    rootName = item.eventEnglishName;
                }
            }
            XmlDocument xmldoc = u.ObjToXml(dict, rootName);
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "xml";
            dlg.Filter = "Xml Files|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string file = dlg.FileName;
                Console.WriteLine("保存的路径是： " + file);
                xmldoc.Save(file);
            }
            
        }
    }
}
