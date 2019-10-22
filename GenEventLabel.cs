using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace UnderWater
{
    class GenEventLabel
    {
        Point eventLocation = new Point(MainBody.Instance.mainBody.Width/2, 10);

        public GenEventLabel()
        {
            Label eventLabel = new Label();

            eventLabel.Font = new Font("宋体", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            eventLabel.Location = eventLocation;
            eventLabel.Name = EventMenu.Instance.eventEnglishName;
            eventLabel.Size = new Size(70, 20);
            eventLabel.BackColor = Color.YellowGreen;
            eventLabel.BorderStyle = BorderStyle.FixedSingle;
            eventLabel.TextAlign = ContentAlignment.MiddleCenter;
            eventLabel.Text = EventMenu.Instance.currentEventName;

            eventLabel.Click += new EventHandler(OnClick_Event);

            MainBody.Instance.mainBody.Controls.Add(eventLabel);

            EventClass eventClass = new EventClass(EventMenu.Instance.parentEventName, EventMenu.Instance.currentEventName, EventMenu.Instance.eventEnglishName, EventMenu.Instance.eventLevel, EventMenu.Instance.operationType);
            //跟新事件层数
            eventClass.UpdateLayer();
            //更新上级事件的子节点数
            eventClass.AddParentEventChildCount();
            EventInfo.Instance.eventInfoDic.Add(eventLabel, eventClass);
            //测试
            EventInfo.Instance.ResetEventTree();
        }

        private void OnClick_Event(object sender, EventArgs e)
        {
            Utils.util.OnClick_Common(sender, e);
        }
    }
}
