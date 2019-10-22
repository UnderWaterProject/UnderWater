using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnderWater
{
    class MainBody
    {
        public static MainBody Instance;

        public Panel mainBody;

        public MainBody()
        {
            Instance = this;
            mainBody = (Panel)MainForm.Instance.Controls["MainBody"];

            mainBody.Click += new EventHandler(OnClick_MainBody);
        }

        private void OnClick_MainBody(object sender, EventArgs e)
        {
            MouseEventArgs onClick = (MouseEventArgs)e;
            if (onClick.Button == MouseButtons.Left)
            {
                MoveMenu.Instance.moveMenu.Visible = false;
            }
            else if (onClick.Button == MouseButtons.Right)
            {
                MoveMenu.Instance.moveMenu.Visible = false;
            }
        }
    }
}
