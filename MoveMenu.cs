using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnderWater
{
    class MoveMenu
    {
        public static MoveMenu Instance;

        public Panel moveMenu;

        public MoveMenu()
        {
            Instance = this;
            Init();
        }

        private void Init()
        {
            moveMenu = (Panel)MainBody.Instance.mainBody.Controls["MoveMenu"];
            Label addEventBtn = (Label)moveMenu.Controls["AddEvent"];
            addEventBtn.Click += new EventHandler(OnClick_AddEvent);

            Label modifyEventBtn = (Label)moveMenu.Controls["ModifyEvent"];
            modifyEventBtn.Click += new EventHandler(OnClick_ModifyEvent);

            Label deleteEventBtn = (Label)moveMenu.Controls["DeleteEvent"];
            deleteEventBtn.Click += new EventHandler(OnClick_DeleteEvent);
        }

        private void OnClick_AddEvent(object sender, EventArgs e)
        {
            //显示EventMenu面板
            EventMenu.Instance.eventMenu.Visible = true;
            //隐藏MoveMenu面板
            MoveMenu.Instance.moveMenu.Visible = false;
            //
            EventMenu.Instance.eventMenu.Controls["OperatorName"].Text = "添加事件";
            EventMenu.Instance.eventMenu.Controls["Confirm"].Text = "添加";
        }

        private void OnClick_ModifyEvent(object sender, EventArgs e)
        {
            //显示EventMenu面板
            EventMenu.Instance.eventMenu.Visible = true;
            //隐藏MoveMenu面板
            MoveMenu.Instance.moveMenu.Visible = false;

            EventMenu.Instance.eventMenu.Controls["OperatorName"].Text = "修改事件";
            EventMenu.Instance.eventMenu.Controls["Confirm"].Text = "修改";

            CurrentEventInfo();
        }

        private void OnClick_DeleteEvent(object sender, EventArgs e)
        {
            //显示EventMenu面板
            EventMenu.Instance.eventMenu.Visible = true;
            //隐藏MoveMenu面板
            MoveMenu.Instance.moveMenu.Visible = false;

            EventMenu.Instance.eventMenu.Controls["OperatorName"].Text = "删除事件";
            EventMenu.Instance.eventMenu.Controls["Confirm"].Text = "删除";

            CurrentEventInfo();
        }

        private void CurrentEventInfo()
        {
            string currentEventName = EventMenu.Instance.eventMenu.Controls["ParentEventName"].Text;

            Label currentEvent = (Label)MainBody.Instance.mainBody.Controls[currentEventName];

            EventClass currentEventClass = EventInfo.Instance.eventInfoDic[currentEvent];

            Panel eventMenu = EventMenu.Instance.eventMenu;
            eventMenu.Controls["ParentEventName"].Text = currentEventClass.parentEventName;
            eventMenu.Controls["CurrentEventName"].Text = currentEventClass.currentEventName;
            eventMenu.Controls["EventEnglishName"].Text = currentEventClass.eventEnglishName;
            eventMenu.Controls["EventLevel"].Text = currentEventClass.eventLevel;
            eventMenu.Controls["OperationType"].Text = currentEventClass.operatorType;
        }
    }
}
