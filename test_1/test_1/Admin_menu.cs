using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1
{
    public partial class Admin_menu : Form
    {
        private string admin_name;
        public Admin_menu(string admin_name)
        {
            InitializeComponent();
            this.admin_name = admin_name;

        }

        private void Admin_menu_Load(object sender, EventArgs e)
        {
            this.label_name.Text = admin_name;
            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox3.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox4.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox5.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox6.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label_name.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label3.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label4.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label5.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label6.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Mask_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_menu(admin_name).ShowDialog();//模态
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Report_menu(admin_name).ShowDialog();//模态
        }

        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Announce(admin_name).ShowDialog();//模态
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Announce(admin_name).ShowDialog();//模态
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Report_menu(admin_name).ShowDialog();//模态
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Message_menu(admin_name).ShowDialog();//模态
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Message_menu(admin_name).ShowDialog();//模态
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new New_community_menu(admin_name).ShowDialog();//模态
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new New_community_menu(admin_name).ShowDialog();//模态
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_menu(admin_name).ShowDialog();//模态
        }
    }
}
