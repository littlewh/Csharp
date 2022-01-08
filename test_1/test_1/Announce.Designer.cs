namespace test_1
{
    partial class Announce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announce));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xButton1 = new test_1.XButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_message = new System.Windows.Forms.RichTextBox();
            this.text_topic = new System.Windows.Forms.TextBox();
            this.Mask = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::test_1.Properties.Resources.back_ope;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.xButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_message);
            this.panel1.Controls.Add(this.text_topic);
            this.panel1.Controls.Add(this.Mask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 829);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::test_1.Properties.Resources.back;
            this.pictureBox1.Image = global::test_1.Properties.Resources.back;
            this.pictureBox1.InitialImage = global::test_1.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(53, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.xButton1.Location = new System.Drawing.Point(560, 699);
            this.xButton1.Name = "xButton1";
            this.xButton1.PressBackColor = System.Drawing.Color.Green;
            this.xButton1.PressForeColor = System.Drawing.Color.White;
            this.xButton1.Radius = 10;
            this.xButton1.Size = new System.Drawing.Size(219, 59);
            this.xButton1.TabIndex = 14;
            this.xButton1.Text = "提交";
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1018, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "发布人：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1138, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 45);
            this.label1.TabIndex = 12;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_message
            // 
            this.text_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_message.Location = new System.Drawing.Point(111, 171);
            this.text_message.Name = "text_message";
            this.text_message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.text_message.Size = new System.Drawing.Size(1160, 499);
            this.text_message.TabIndex = 11;
            this.text_message.Text = "在此输入内容。";
            this.text_message.Click += new System.EventHandler(this.text_message_Click);
            this.text_message.TextChanged += new System.EventHandler(this.text_message_TextChanged);
            this.text_message.Enter += new System.EventHandler(this.text_message_Enter);
            this.text_message.Leave += new System.EventHandler(this.text_message_Leave);
            // 
            // text_topic
            // 
            this.text_topic.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_topic.Location = new System.Drawing.Point(223, 82);
            this.text_topic.MaxLength = 20;
            this.text_topic.Multiline = true;
            this.text_topic.Name = "text_topic";
            this.text_topic.Size = new System.Drawing.Size(939, 47);
            this.text_topic.TabIndex = 10;
            this.text_topic.Text = "请在此处输入标题，不超过30字。";
            this.text_topic.Click += new System.EventHandler(this.text_topic_Click);
            this.text_topic.TextChanged += new System.EventHandler(this.text_topic_TextChanged);
            this.text_topic.Enter += new System.EventHandler(this.text_topic_Enter);
            this.text_topic.Leave += new System.EventHandler(this.text_topic_Leave);
            this.text_topic.Validated += new System.EventHandler(this.text_topic_Validated);
            // 
            // Mask
            // 
            this.Mask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mask.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mask.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mask.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mask.Location = new System.Drawing.Point(47, 42);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(1281, 749);
            this.Mask.TabIndex = 9;
            this.Mask.Click += new System.EventHandler(this.Mask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "内容:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "标题:";
            // 
            // Announce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_1.Properties.Resources.back_ope;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 829);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Announce";
            this.Text = "发布新公告";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Announce_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Mask;
        private System.Windows.Forms.TextBox text_topic;
        private System.Windows.Forms.RichTextBox text_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XButton xButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}