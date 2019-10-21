using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            MouseEventArgs onClick = (MouseEventArgs)e;
            if (onClick.Button == MouseButtons.Left)
            {

            }
            else if (onClick.Button == MouseButtons.Right)
            {
                //设置上级事件
                EventMenu.Instance.eventMenu.Controls["ParentEventName"].Text = ((Label)sender).Name;
                //显示EventMenu面板
                EventMenu.Instance.eventMenu.Visible = true;
            }
        }

    }
}
