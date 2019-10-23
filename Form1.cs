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
            Utils utils = new Utils();
            MoveMenu moveMenu = new MoveMenu();
            EventOperation eventOperation = new EventOperation();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Red, new Point(0, 0), new Point(20, 20));
        }

        private void DrawLine(Label tmp1, Label tmp2)
        {
            Pen pen = new Pen(Color.Red, 5);

            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, tmp1.Location, tmp2.Location);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出？", "确定关闭", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
