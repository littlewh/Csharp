namespace test_1
{
    partial class Add_game_attribute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_game_attribute));
            this.Mask = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xButton1 = new test_1.XButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Mask.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 51);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(108, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "添加类型名：";
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
            this.xButton1.Location = new System.Drawing.Point(284, 379);
            this.xButton1.Name = "xButton1";
            this.xButton1.PressBackColor = System.Drawing.Color.Green;
            this.xButton1.PressForeColor = System.Drawing.Color.White;
            this.xButton1.Radius = 10;
            this.xButton1.Size = new System.Drawing.Size(329, 65);
            this.xButton1.TabIndex = 12;
            this.xButton1.Text = "提交";
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::test_1.Properties.Resources.back;
            this.pictureBox1.Image = global::test_1.Properties.Resources.back;
            this.pictureBox1.InitialImage = global::test_1.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add_game_attribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_1.Properties.Resources.back_yuan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.xButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_game_attribute";
            this.Text = "添加社区类型";
            this.Load += new System.EventHandler(this.Add_game_attribute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private XButton xButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}