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
            this.EventMenu = new System.Windows.Forms.Panel();
            this.OperatorName = new System.Windows.Forms.Label();
            this.OperationType = new System.Windows.Forms.ComboBox();
            this.EventLevel = new System.Windows.Forms.ComboBox();
            this.EventEnglishName = new System.Windows.Forms.TextBox();
            this.CurrentEventName = new System.Windows.Forms.TextBox();
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
            this.MoveMenu.SuspendLayout();
            this.MainBody.SuspendLayout();
            this.EventMenu.SuspendLayout();
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
            this.MoveMenu.Visible = false;
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
            this.MainBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainBody.Controls.Add(this.EventMenu);
            this.MainBody.Controls.Add(this.MoveMenu);
            this.MainBody.Location = new System.Drawing.Point(0, 27);
            this.MainBody.Name = "MainBody";
            this.MainBody.Size = new System.Drawing.Size(800, 423);
            this.MainBody.TabIndex = 2;
            // 
            // EventMenu
            // 
            this.EventMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EventMenu.Controls.Add(this.OperatorName);
            this.EventMenu.Controls.Add(this.OperationType);
            this.EventMenu.Controls.Add(this.EventLevel);
            this.EventMenu.Controls.Add(this.EventEnglishName);
            this.EventMenu.Controls.Add(this.CurrentEventName);
            this.EventMenu.Controls.Add(this.ParentEventName);
            this.EventMenu.Controls.Add(this.Concel);
            this.EventMenu.Controls.Add(this.Confirm);
            this.EventMenu.Controls.Add(this.label3);
            this.EventMenu.Controls.Add(this.label4);
            this.EventMenu.Controls.Add(this.label5);
            this.EventMenu.Controls.Add(this.label2);
            this.EventMenu.Controls.Add(this.label1);
            this.EventMenu.Location = new System.Drawing.Point(225, 27);
            this.EventMenu.Name = "EventMenu";
            this.EventMenu.Size = new System.Drawing.Size(313, 316);
            this.EventMenu.TabIndex = 1;
            this.EventMenu.Visible = false;
            // 
            // OperatorName
            // 
            this.OperatorName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OperatorName.Location = new System.Drawing.Point(3, 5);
            this.OperatorName.Name = "OperatorName";
            this.OperatorName.Size = new System.Drawing.Size(307, 35);
            this.OperatorName.TabIndex = 13;
            this.OperatorName.Text = "label6";
            this.OperatorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OperationType
            // 
            this.OperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationType.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OperationType.FormattingEnabled = true;
            this.OperationType.Items.AddRange(new object[] {
            "+",
            "-"});
            this.OperationType.Location = new System.Drawing.Point(149, 202);
            this.OperationType.Name = "OperationType";
            this.OperationType.Size = new System.Drawing.Size(154, 27);
            this.OperationType.TabIndex = 12;
            // 
            // EventLevel
            // 
            this.EventLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventLevel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EventLevel.FormattingEnabled = true;
            this.EventLevel.Items.AddRange(new object[] {
            "TOP",
            "MID",
            "BUTTOM"});
            this.EventLevel.Location = new System.Drawing.Point(149, 165);
            this.EventLevel.Name = "EventLevel";
            this.EventLevel.Size = new System.Drawing.Size(154, 27);
            this.EventLevel.TabIndex = 11;
            // 
            // EventEnglishName
            // 
            this.EventEnglishName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EventEnglishName.Location = new System.Drawing.Point(149, 130);
            this.EventEnglishName.Name = "EventEnglishName";
            this.EventEnglishName.Size = new System.Drawing.Size(154, 29);
            this.EventEnglishName.TabIndex = 10;
            // 
            // CurrentEventName
            // 
            this.CurrentEventName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentEventName.Location = new System.Drawing.Point(149, 91);
            this.CurrentEventName.Name = "CurrentEventName";
            this.CurrentEventName.Size = new System.Drawing.Size(154, 29);
            this.CurrentEventName.TabIndex = 9;
            // 
            // ParentEventName
            // 
            this.ParentEventName.AutoSize = true;
            this.ParentEventName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ParentEventName.Location = new System.Drawing.Point(145, 61);
            this.ParentEventName.Name = "ParentEventName";
            this.ParentEventName.Size = new System.Drawing.Size(49, 19);
            this.ParentEventName.TabIndex = 8;
            this.ParentEventName.Text = "NULL";
            // 
            // Concel
            // 
            this.Concel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Concel.Location = new System.Drawing.Point(149, 266);
            this.Concel.Name = "Concel";
            this.Concel.Size = new System.Drawing.Size(76, 33);
            this.Concel.TabIndex = 7;
            this.Concel.Text = "取消";
            this.Concel.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Location = new System.Drawing.Point(31, 266);
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
            this.label3.Location = new System.Drawing.Point(3, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "操作类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "事件等级：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "事件英文名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前事件名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 61);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MoveMenu.ResumeLayout(false);
            this.MainBody.ResumeLayout(false);
            this.EventMenu.ResumeLayout(false);
            this.EventMenu.PerformLayout();
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
        private System.Windows.Forms.Panel EventMenu;
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
        private System.Windows.Forms.ComboBox OperationType;
        private System.Windows.Forms.ComboBox EventLevel;
        private System.Windows.Forms.TextBox EventEnglishName;
        private System.Windows.Forms.TextBox CurrentEventName;
        private System.Windows.Forms.Label OperatorName;
    }
}

