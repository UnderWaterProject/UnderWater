﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderWater
{
    class EventMenu
    {
        public static EventMenu Instance;

        public Panel eventMenu;

        public string parentEventName;
        public string currentEventName;
        public string eventEnglishName;
        public string eventLevel;
        public string operationType;

        public Button confirmBtn;
        public Button concelBtn;

        public EventMenu()
        {
            Instance = this;
            eventMenu = (Panel)MainBody.Instance.mainBody.Controls["EventMenu"];

            confirmBtn = (Button)eventMenu.Controls["Confirm"];
            confirmBtn.Click += new EventHandler(OnClick_Confrim);
          
            concelBtn = (Button)eventMenu.Controls["Concel"];
            concelBtn.Click += new EventHandler(OnClick_Concel);
        }

        private void Clear()
        {
            eventMenu.Controls["ParentEventName"].Text = "";
            eventMenu.Controls["CurrentEventName"].Text = "";
            eventMenu.Controls["EventEnglishName"].Text = "";
            eventMenu.Controls["EventLevel"].Text = "";
            eventMenu.Controls["OperationType"].Text = "";
        }
        //
        //确认键点击
        //
        private void OnClick_Confrim(object sender, EventArgs e)
        {
            //获取事件值
            parentEventName = eventMenu.Controls["ParentEventName"].Text;
            currentEventName = eventMenu.Controls["CurrentEventName"].Text;
            eventEnglishName = eventMenu.Controls["EventEnglishName"].Text;
            eventLevel = eventMenu.Controls["EventLevel"].Text;
            operationType = eventMenu.Controls["OperationType"].Text;

            //获取操作类型：添加， 修改， 删除
            string operatorName = eventMenu.Controls["OperatorName"].Text;
            switch (operatorName)
            {
                case "添加事件":
                    //添加事件
                    new GenEventLabel();
                    break;
                case "修改事件":
                    EventOperation.Instance.ModifyEvent();
                    break;
                case "删除事件":
                    EventOperation.Instance.DeleteEvent();
                    break;
            }
            //重构树
            EventInfo.Instance.ResetEventTree();
            //连线

            //清空面板值
            Clear();
            //关闭窗口
            eventMenu.Visible = false;
        }
        //
        //取消键点击
        //
        private void OnClick_Concel(object sender, EventArgs e)
        {
            eventMenu.Visible = false;
        }
    }
}
