namespace test_1
{
    partial class ID_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ID_login));
            this.Mask = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.remember = new System.Windows.Forms.CheckBox();
            this.backlabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Mask
            // 
            this.Mask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mask.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mask.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mask.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mask.Location = new System.Drawing.Point(89, 50);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(699, 343);
            this.Mask.TabIndex = 0;
            this.Mask.Click += new System.EventHandler(this.Mask_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(137, 139);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(143, 33);
            this.name.TabIndex = 1;
            this.name.Text = "用 户 名";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(137, 257);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(143, 33);
            this.password.TabIndex = 2;
            this.password.Text = "密    码";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 9.5F);
            this.textBox1.Location = new System.Drawing.Point(329, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 48);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "仅能由英文、数字、下划线组成";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 9.5F);
            this.textBox2.Location = new System.Drawing.Point(329, 248);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(382, 48);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remember.Location = new System.Drawing.Point(143, 342);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(138, 28);
            this.remember.TabIndex = 5;
            this.remember.Text = "记住此ip";
            this.remember.UseVisualStyleBackColor = false;
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backlabel.Location = new System.Drawing.Point(690, 343);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(58, 24);
            this.backlabel.TabIndex = 6;
            this.backlabel.TabStop = true;
            this.backlabel.Text = "返回";
            this.backlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backlabel_LinkClicked);
            // 
            // ID_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_1.Properties.Resources.back_yuan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 529);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.remember);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Mask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ID_login";
            this.Text = "账密登录";
            this.Load += new System.EventHandler(this.ID_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mask;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox remember;
        private System.Windows.Forms.LinkLabel backlabel;
    }
}