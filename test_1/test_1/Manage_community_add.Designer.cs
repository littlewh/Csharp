namespace test_1
{
    partial class Manage_community_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_community_add));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mask = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.xButton1 = new test_1.XButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(150, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "在此处输入社区名";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label_name
            // 
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(696, 67);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(159, 41);
            this.label_name.TabIndex = 10;
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::test_1.Properties.Resources.admin;
            this.pictureBox1.ImageLocation = "Resourses.admin_male1";
            this.pictureBox1.Location = new System.Drawing.Point(752, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Mask
            // 
            this.Mask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mask.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mask.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mask.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mask.Location = new System.Drawing.Point(14, 9);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(846, 511);
            this.Mask.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(150, 248);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(527, 50);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "在此处输入社区图像链接(可选)";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
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
            this.xButton1.Location = new System.Drawing.Point(222, 371);
            this.xButton1.Name = "xButton1";
            this.xButton1.PressBackColor = System.Drawing.Color.Green;
            this.xButton1.PressForeColor = System.Drawing.Color.White;
            this.xButton1.Radius = 10;
            this.xButton1.Size = new System.Drawing.Size(384, 71);
            this.xButton1.TabIndex = 13;
            this.xButton1.Text = "提交";
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = global::test_1.Properties.Resources.back;
            this.pictureBox2.Image = global::test_1.Properties.Resources.back;
            this.pictureBox2.InitialImage = global::test_1.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(20, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Manage_community_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_1.Properties.Resources.back_yuan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 529);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.xButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manage_community_add";
            this.Text = "添加社区";
            this.Load += new System.EventHandler(this.Manage_community_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Mask;
        private System.Windows.Forms.TextBox textBox2;
        private XButton xButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}