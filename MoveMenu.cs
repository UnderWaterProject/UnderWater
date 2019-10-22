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
        }

        private void OnClick_ModifyEvent(object sender, EventArgs e)
        {

        }

        private void OnClick_DeleteEvent(object sender, EventArgs e)
        {

        }
    }
}
