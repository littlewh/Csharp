namespace test_1
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.CheckBox();
            this.xButton1 = new test_1.XButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label_time = new System.Windows.Forms.Label();
            this.text_message = new System.Windows.Forms.RichTextBox();
            this.text_topic = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_admin = new System.Windows.Forms.Label();
            this.Mask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::test_1.Properties.Resources.back_ope;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.xButton1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Controls.Add(this.text_message);
            this.panel1.Controls.Add(this.text_topic);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_admin);
            this.panel1.Controls.Add(this.Mask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 829);
            this.panel1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(596, 665);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 28);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.Text = "禁言被举报人";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(219, 665);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(210, 28);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.Text = "删除被举报文章";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // xButton1
            // 
            this.xButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton1.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(222)))), ((int)(((byte)(0)))));
            this.xButton1.EnterForeColor = System.Drawing.Color.White;
            this.xButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.xButton1.FlatAppearance.BorderSize = 5;
            this.xButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.xButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.xButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xButton1.Font = new System.Drawing.Font("黑体", 12F);
            this.xButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            this.xButton1.HoverForeColor = System.Drawing.Color.White;
            this.xButton1.Location = new System.Drawing.Point(512, 711);
            this.xButton1.Name = "xButton1";
            this.xButton1.PressBackColor = System.Drawing.Color.Green;
            this.xButton1.PressForeColor = System.Drawing.Color.White;
            this.xButton1.Radius = 10;
            this.xButton1.Size = new System.Drawing.Size(368, 55);
            this.xButton1.TabIndex = 33;
            this.xButton1.Text = "提交";
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(980, 668);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 24);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看被举报内容";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(474, 256);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(998, 597);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(238, 24);
            this.label_time.TabIndex = 26;
            this.label_time.Text = "2020-12-13 12:12:12";
            // 
            // text_message
            // 
            this.text_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_message.Location = new System.Drawing.Point(107, 209);
            this.text_message.Name = "text_message";
            this.text_message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.text_message.Size = new System.Drawing.Size(1160, 427);
            this.text_message.TabIndex = 28;
            this.text_message.Text = "";
            this.text_message.Click += new System.EventHandler(this.text_message_Click);
            this.text_message.Enter += new System.EventHandler(this.text_message_Enter);
            this.text_message.Leave += new System.EventHandler(this.text_message_Leave);
            // 
            // text_topic
            // 
            this.text_topic.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_topic.Location = new System.Drawing.Point(219, 120);
            this.text_topic.MaxLength = 20;
            this.text_topic.Multiline = true;
            this.text_topic.Name = "text_topic";
            this.text_topic.Size = new System.Drawing.Size(939, 47);
            this.text_topic.TabIndex = 27;
            this.text_topic.Enter += new System.EventHandler(this.text_topic_Enter);
            this.text_topic.Leave += new System.EventHandler(this.text_topic_Leave);
            // 
            // label_name
            // 
            this.label_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_name.Location = new System.Drawing.Point(1064, 734);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(133, 45);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "操作人：";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::test_1.Properties.Resources.back;
            this.pictureBox1.Image = global::test_1.Properties.Resources.back;
            this.pictureBox1.InitialImage = global::test_1.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(55, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_admin
            // 
            this.label_admin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_admin.Location = new System.Drawing.Point(1184, 734);
            this.label_admin.Name = "label_admin";
            this.label_admin.Size = new System.Drawing.Size(133, 45);
            this.label_admin.TabIndex = 16;
            this.label_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mask
            // 
            this.Mask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mask.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mask.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mask.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mask.Location = new System.Drawing.Point(47, 40);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(1281, 749);
            this.Mask.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "标题:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "内容:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 829);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "审核被举报的内容";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Mask;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_admin;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.RichTextBox text_message;
        private System.Windows.Forms.TextBox text_topic;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private XButton xButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox radioButton2;
        private System.Windows.Forms.CheckBox radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}