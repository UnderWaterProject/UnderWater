using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderWater
{
    public partial class MainForm : Form
    {

        public static MainForm Instance;
        public MainForm()
        {
            Instance = this;
            InitializeComponent();
            TopMenu topMenu = new TopMenu();
            MainBody mainBody = new MainBody();
            EventMenu eventMenu = new EventMenu();
            EventInfo eventInfo = new EventInfo();
        }
    }
}
