namespace UnderWater
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MoveMenu = new System.Windows.Forms.Panel();
            this.DeleteEvent = new System.Windows.Forms.Label();
            this.ModifyEvent = new System.Windows.Forms.Label();
            this.AddEvent = new System.Windows.Forms.Label();
            this.MainBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ParentEventName = new System.Windows.Forms.Label();
            this.Concel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.NewEventFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenEventFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveEventFile = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.MoveMenu.SuspendLayout();
            this.MainBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveMenu
            // 
            this.MoveMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MoveMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveMenu.Controls.Add(this.DeleteEvent);
            this.MoveMenu.Controls.Add(this.ModifyEvent);
            this.MoveMenu.Controls.Add(this.AddEvent);
            this.MoveMenu.Location = new System.Drawing.Point(652, 6);
            this.MoveMenu.Name = "MoveMenu";
            this.MoveMenu.Size = new System.Drawing.Size(143, 90);
            this.MoveMenu.TabIndex = 0;
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeleteEvent.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteEvent.Location = new System.Drawing.Point(-1, 57);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(143, 24);
            this.DeleteEvent.TabIndex = 2;
            this.DeleteEvent.Text = "删除事件";
            this.DeleteEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyEvent
            // 
            this.ModifyEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModifyEvent.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModifyEvent.Location = new System.Drawing.Point(-1, 31);
            this.ModifyEvent.Name = "ModifyEvent";
            this.ModifyEvent.Size = new System.Drawing.Size(143, 24);
            this.ModifyEvent.TabIndex = 1;
            this.ModifyEvent.Text = "修改事件";
            this.ModifyEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEvent
            // 
            this.AddEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddEvent.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddEvent.Location = new System.Drawing.Point(-1, 5);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(143, 24);
            this.AddEvent.TabIndex = 0;
            this.AddEvent.Text = "添加事件";
            this.AddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainBody
            // 
            this.MainBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainBody.Controls.Add(this.panel1);
            this.MainBody.Controls.Add(this.MoveMenu);
            this.MainBody.Location = new System.Drawing.Point(0, 27);
            this.MainBody.Name = "MainBody";
            this.MainBody.Size = new System.Drawing.Size(800, 423);
            this.MainBody.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ParentEventName);
            this.panel1.Controls.Add(this.Concel);
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(225, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 289);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // ParentEventName
            // 
            this.ParentEventName.AutoSize = true;
            this.ParentEventName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ParentEventName.Location = new System.Drawing.Point(145, 31);
            this.ParentEventName.Name = "ParentEventName";
            this.ParentEventName.Size = new System.Drawing.Size(49, 19);
            this.ParentEventName.TabIndex = 8;
            this.ParentEventName.Text = "NULL";
            // 
            // Concel
            // 
            this.Concel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Concel.Location = new System.Drawing.Point(149, 236);
            this.Concel.Name = "Concel";
            this.Concel.Size = new System.Drawing.Size(76, 33);
            this.Concel.TabIndex = 7;
            this.Concel.Text = "取消";
            this.Concel.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Location = new System.Drawing.Point(31, 236);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(76, 33);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "操作类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "事件等级：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "事件英文名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前事件名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "上级事件名称：";
            // 
            // TopMenu
            // 
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEventFile,
            this.OpenEventFile,
            this.SaveEventFile});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(800, 25);
            this.TopMenu.TabIndex = 3;
            this.TopMenu.Text = "menuStrip1";
            // 
            // NewEventFile
            // 
            this.NewEventFile.Name = "NewEventFile";
            this.NewEventFile.Size = new System.Drawing.Size(68, 21);
            this.NewEventFile.Text = "新建文件";
            // 
            // OpenEventFile
            // 
            this.OpenEventFile.Name = "OpenEventFile";
            this.OpenEventFile.Size = new System.Drawing.Size(68, 21);
            this.OpenEventFile.Text = "打开文件";
            // 
            // SaveEventFile
            // 
            this.SaveEventFile.Name = "SaveEventFile";
            this.SaveEventFile.Size = new System.Drawing.Size(56, 21);
            this.SaveEventFile.Text = "另存为";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(149, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 29);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(149, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 29);
            this.textBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 27);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(149, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 27);
            this.comboBox2.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainBody);
            this.Controls.Add(this.TopMenu);
            this.Name = "MainForm";
            this.Text = "水下结构物创建";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MoveMenu.ResumeLayout(false);
            this.MainBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MoveMenu;
        private System.Windows.Forms.Label AddEvent;
        private System.Windows.Forms.Panel MainBody;
        private System.Windows.Forms.Label DeleteEvent;
        private System.Windows.Forms.Label ModifyEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Concel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem NewEventFile;
        private System.Windows.Forms.ToolStripMenuItem OpenEventFile;
        private System.Windows.Forms.ToolStripMenuItem SaveEventFile;
        private System.Windows.Forms.Label ParentEventName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

