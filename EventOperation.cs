using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnderWater
{
    class EventOperation
    {
        public static EventOperation Instance;

        public EventOperation()
        {
            Instance = this;
        }

        public void ModifyEvent()
        {
            string currentEventName = EventMenu.Instance.eventMenu.Controls["EventEnglishName"].Text;
            Label currentEvent = (Label)MainBody.Instance.mainBody.Controls[currentEventName];
            EventClass currentEventClass = EventInfo.Instance.eventInfoDic[currentEvent];
            //currentEventClass.parentEventName = EventMenu.Instance.eventMenu.Controls["ParentEventName"].Text;
            currentEventClass.currentEventName = EventMenu.Instance.eventMenu.Controls["CurrentEventName"].Text;
            currentEventClass.eventEnglishName = EventMenu.Instance.eventMenu.Controls["EventEnglishName"].Text;
            currentEventClass.eventLevel = EventMenu.Instance.eventMenu.Controls["EventLevel"].Text;
            currentEventClass.operatorType = EventMenu.Instance.eventMenu.Controls["OperationType"].Text;

            currentEvent.Name = currentEventClass.eventEnglishName;
            currentEvent.Text = currentEventClass.currentEventName;
        }

        public void DeleteEvent()
        {
            string currentEventName = EventMenu.Instance.eventMenu.Controls["EventEnglishName"].Text;
            Label currentEvent = (Label)MainBody.Instance.mainBody.Controls[currentEventName];
            EventClass currentEventClass = EventInfo.Instance.eventInfoDic[currentEvent];

            if (currentEventClass.childList.Count > 0)
            {
                MessageBox.Show("该事件含有子事件，无法删除！");
            }
            else
            {
                //删除该事件
                //字典中删除label
                EventInfo.Instance.eventInfoDic.Remove(currentEvent);
                //面板中删除label
                MainBody.Instance.mainBody.Controls.Remove(currentEvent);
                //从父节点中的类中删除对应的childList
                string parentEventName = EventMenu.Instance.eventMenu.Controls["ParentEventName"].Text;
                Label parentEvent = (Label)MainBody.Instance.mainBody.Controls[parentEventName];
                EventClass parentEventClass = EventInfo.Instance.eventInfoDic[parentEvent];
                parentEventClass.childList.Remove(currentEventName);
            }
        }
    }
}
