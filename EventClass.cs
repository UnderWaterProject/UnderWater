using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UnderWater
{
    class EventClass
    {
        public string parentEventName;
        public string currentEventName;
        public string eventEnglishName;
        public string eventLevel;
        public string operatorType;
        public int layer = 0;
        public List<string> childList;

        public int currentChildCount = 0;//

        public Point currentEventPos = new Point(0, 0);//在EventInfo的重构树方法中赋值

        public EventClass(string parentEventName, string currentEventName, string eventEnglishName, string eventLevel, string operatorType)
        {
            this.parentEventName = parentEventName;
            this.currentEventName = currentEventName;
            this.eventEnglishName = eventEnglishName;
            this.eventLevel = eventLevel;
            this.operatorType = operatorType;

            childList = new List<string>();
        }

        public void UpdateLayer()
        {
            if(this.eventLevel == "TOP")
            {
                this.layer = 0;
            }
            else
            {
                //获取上级Label
                Label parentEventLabel = (Label)MainBody.Instance.mainBody.Controls[this.parentEventName];
                //获取上级EventClass
                EventClass parentEventClass = EventInfo.Instance.eventInfoDic[parentEventLabel];
                //获取上级层数
                int parentLayer = parentEventClass.layer;
                //当前层数加一
                this.layer = parentLayer + 1;
            }
        }

        public void AddParentEventChildCount()
        {
            if (this.eventLevel == "TOP")
            {
                //MessageBox.Show("呀！");
            }
            else
            {
                //获取上级Label
                Label parentEventLabel = (Label)MainBody.Instance.mainBody.Controls[this.parentEventName];
                //获取上级EventClass
                EventClass parentEventClass = EventInfo.Instance.eventInfoDic[parentEventLabel];
                //添加到childList中
                parentEventClass.childList.Add(this.eventEnglishName);
            }
        }

        public override string ToString()
        {
            string str = "parentEventName:" + parentEventName + " eventEnglisthName"
                + " currentEventName" + currentEventName + " eventEnglishName" + eventEnglishName + " eventLevel:" + eventLevel + ", operatorType" + operatorType;
            str += "[";
            foreach (String s in childList)
            {
                str += s + ", ";
            }
            str += "]";
            return str;
        }
    }
}
