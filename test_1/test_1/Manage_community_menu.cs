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
    public partial class Manage_community_menu : Form
    {
        string admin_name;
        public Manage_community_menu(string admin_name)
        {
            InitializeComponent();
            this.admin_name = admin_name;
        }

        private void Manage_community_menu_Load(object sender, EventArgs e)
        {
            this.label_name.Text = admin_name;
            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label_name.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.linkLabel1.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.pictureBox2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox3.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox4.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Admin_menu(admin_name).ShowDialog();//模态
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_add(admin_name).ShowDialog();//模态
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_add(admin_name).ShowDialog();//模态
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_modify_search(admin_name).ShowDialog();//模态
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_modify_search(admin_name).ShowDialog();//模态
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Dispose();
            new Add_game_attribute(admin_name).ShowDialog();//模态
        }
    }
}
