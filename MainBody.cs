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
        }
    }
}
