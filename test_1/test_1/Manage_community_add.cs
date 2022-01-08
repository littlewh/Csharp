using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1
{
    public partial class Manage_community_add : Form
    {
        string admin_name;
        public Manage_community_add(string admin_name)
        {
            InitializeComponent();
            this.admin_name = admin_name;
        }

        private void Manage_community_add_Load(object sender, EventArgs e)
        {
            this.label_name.Text = admin_name;
            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.textBox1.ForeColor = Color.FromArgb(111,111,111);
            this.textBox2.ForeColor = Color.FromArgb(111, 111, 111);
            this.label_name.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox2.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.FromArgb(0,0,0);
            if (textBox1.Text == "在此处输入社区名")
            {
                this.textBox1.Text = "";
            }
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.textBox2.ForeColor = Color.FromArgb(0,0,0);
            if (textBox2.Text == "在此处输入社区图像链接(可选)")
            {
                this.textBox2.Text = "";
            }
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            this.textBox2.ForeColor = Color.FromArgb(111, 111, 111);
            if (this.textBox2.Text == "")
            {
                this.textBox2.Text = "在此处输入社区图像链接(可选)";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.FromArgb(111, 111, 111);
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "在此处输入社区名";
            }
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            //MessageBox.Show("ojbk");
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();
                string re = @"(http|ftp|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)+\.(png|jpg|gif|jpeg)";

                if (s2 == "在此处输入社区图像链接(可选)")
                {
                    string insert = "insert into gamecommunity(gname,goperator,gflag) values('" + s1 + "','"  + admin_name + "','1');";
                    Console.WriteLine(insert);
                    MySqlCommand cmd = new MySqlCommand(insert, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();

                    MessageBox.Show("成功!", "成功");
                    this.Close();
                    this.Dispose();
                    new Manage_community_menu(admin_name).ShowDialog();//模态

                }
                else if (!Regex.IsMatch(s2, re))
                {
                    MessageBox.Show("图片链接不合法");
                }
                else
                {
                    string insert = "insert into gamecommunity(gname,gppath,goperator,gflag) values('" + s1 + "','" + s2 + "','"  + admin_name + "','1');";
                    Console.WriteLine(insert);
                    MySqlCommand cmd = new MySqlCommand(insert, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();

                    MessageBox.Show("成功!", "成功");
                    this.Close();
                    this.Dispose();
                    new Manage_community_menu(admin_name).ShowDialog();//模态
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("失败，请检查您的网络！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                conn.Close();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_menu(admin_name).ShowDialog();//模态
        }
    }
}
