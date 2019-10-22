using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UnderWater
{
    class EventInfo
    {
        public static EventInfo Instance;
        public Dictionary<Label, EventClass> eventInfoDic;

        
        private int startX = 15;
        private int XCell = 100;

        public EventInfo()
        {
            Instance = this;
            eventInfoDic = new Dictionary<Label, EventClass>();
        }

        public void ResetEventTree()
        {
            startX = 15;
            ClearLocationAndChild();

            foreach (Label tmpLabel in eventInfoDic.Keys)
            {
                Console.WriteLine(tmpLabel.Name + ":" + tmpLabel.Location);
            }

            Label topEventLabel = GetTopEvent();
            
            SetSubEventPos(topEventLabel);

        }

        private int SetSubEventPos(Label eventLabel)
        {
            int layer = 0;
            //获取当前事件EventClass
            EventClass tmpEventClass = eventInfoDic[eventLabel];
            //获取子事件列表
            List<string> tmpChildList = tmpEventClass.childList;
            //
            
            if(tmpChildList.Count>0)
            {
                foreach(string tmpChildName in tmpChildList)
                {
                    startX = SetSubEventPos((Label)MainBody.Instance.mainBody.Controls[tmpChildName]);
                }
                //
                int parentX = 0;
                for(int i=0;i< tmpChildList.Count; i++)
                {
                    string subEventName = tmpChildList[i];
                    parentX += MainBody.Instance.mainBody.Controls[subEventName].Location.X;
                }
                parentX /= tmpChildList.Count;

                //获取最后一个子事件
                string lastChildName = tmpChildList[tmpChildList.Count - 1];

                Label childEventLabel = (Label)MainBody.Instance.mainBody.Controls[lastChildName];
                tmpEventClass = eventInfoDic[childEventLabel];
                //获取父事件Name
                string parentEventName = tmpEventClass.parentEventName;
                //MessageBox.Show(parentEventName);
                //获取Label
                Label parentEventLabel = (Label)MainBody.Instance.mainBody.Controls[parentEventName];
                parentEventLabel.Location = new Point(parentX, childEventLabel.Location.Y - 40);
                //获取父事件的类信息文件
                tmpEventClass = eventInfoDic[parentEventLabel];
                //将位置信息加入类信息文件中
                tmpEventClass.currentEventPos = parentEventLabel.Location;

            }
            else
            {//当前为最低层
                //获取当前层数
                layer = tmpEventClass.layer;
                eventLabel.Location = new Point(startX, layer * 40 + 10);
                tmpEventClass.currentEventPos = eventLabel.Location;
            }
            
            return startX + XCell;
        }

        private void DrawLineInEvent()
        {

        }

        private void ClearLocationAndChild()
        {
            foreach (Label tmpLabel in eventInfoDic.Keys)
            {
                EventClass tmpEventClass = eventInfoDic[tmpLabel];
                tmpEventClass.currentEventPos = new Point(0, 0);
                tmpLabel.Location = new Point(0, 0);
                tmpEventClass.currentChildCount = 0;
            }
        }

        private Label GetTopEvent()
        {
            int widthCell = 15;
            int heightCell = 10;

            Label topEventLabel = null;
            EventClass tmpEventClass = null;
            foreach (Label tmpLabel in eventInfoDic.Keys)
            {
                tmpEventClass = eventInfoDic[tmpLabel];
                if (tmpEventClass.eventLevel == "TOP")
                {
                    topEventLabel = tmpLabel;
                }
            }
            topEventLabel.Location = new Point(widthCell, heightCell);
            //存储当前事件的位置
            tmpEventClass.currentEventPos = topEventLabel.Location;

            return topEventLabel;
        }
    }
}
