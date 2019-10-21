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
            Label topEventLabel = GetTopEvent();
            startX = 15;

            ClearLocationAndChild();
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
                //更新父事件位置
                //获取父事件Name
                string parentEventName = tmpEventClass.parentEventName;
                //获取Label
                //MainBody.Instance.mainBody.Controls[parentEventName].Location = eventLabel.Location;
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

        /*
        private void SetSubEventPos(Label eventLabel)
        {
            int width = 70;
            int height = 20;
            int widthCell = 15;
            int heightCell = 10;
            //获取当前事件EventClass
            EventClass tmpEventClass = eventInfoDic[eventLabel];
            //获取子事件列表
            List<string> tmpChildList = tmpEventClass.childList;
            //获取当前重构孩子数
            for (int i = 0; i < tmpChildList.Count; i++)
            {
                int currentChildCount = tmpEventClass.currentChildCount;
                Label tmpSubEvent = (Label)MainBody.Instance.mainBody.Controls[tmpChildList[i]];


                //设置子事件位置
                tmpSubEvent.Location = new Point(widthCell+(width + widthCell + tmpEventClass.currentEventPos.X) * currentChildCount, heightCell + height + tmpEventClass.currentEventPos.Y);
                //存储当前事件的位置
                eventInfoDic[tmpSubEvent].currentEventPos = tmpSubEvent.Location;
                MessageBox.Show(tmpSubEvent.Location.ToString());
                tmpEventClass.currentChildCount += 1;

                if (eventInfoDic[tmpSubEvent].childList != null)
                {
                    SetSubEventPos(tmpSubEvent);
                }
            }
        }
        */

        private void ClearLocationAndChild()
        {
            foreach (Label tmpLabel in eventInfoDic.Keys)
            {
                EventClass tmpEventClass = eventInfoDic[tmpLabel];
                tmpEventClass.currentEventPos = new Point(0, 10);
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
