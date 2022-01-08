using MySql.Data.MySqlClient;
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
    public partial class Manage_community_modify_search : Form
    {
        string admin_name;
        string gid;
        public Manage_community_modify_search(string admin_name)
        {
            InitializeComponent();
            this.admin_name = admin_name;
        }

        private void Manage_community_modify_search_Load(object sender, EventArgs e)
        {
            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            //this.label1.BackColor = Color.FromArgb(200, Mask.BackColor);
            //this.textBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.textBox1.ForeColor = Color.FromArgb(111, 111, 111);

            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;

            this.pictureBox2.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.xButton2.Visible = false;

            this.linkLabel1.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            if (name != "输入待查找的社区名")
            {

                String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
                MySqlConnection conn = new MySqlConnection(connetStr);
                try
                {
                    //MessageBox.Show("sonnect success");

                    conn.Open();
                    string query = "select gid,gname,gppath from gamecommunity where gname = '"+ name + "'; ";
                    Console.WriteLine(query);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    bool bb = reader.Read();
                    if (bb)
                    {
                        pictureBox2.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        xButton2.Visible = true;
                        gid = reader["gid"].ToString();
                        string gname = reader["gname"].ToString();
                        string gppath = reader["gppath"].ToString();
                        string url = reader["gppath"].ToString();
                        reader.Close();
                        Image im = test_1.Properties.Resources.gamecommunity;
                        try
                        {
                            pictureBox2.Load(url);
                        }
                        catch (Exception ex2)
                        {
                            pictureBox2.Image = im;
                        }
                        this.textBox2.Text = gppath;
                        this.textBox3.Text = gname;

                    }
                    else
                    {
                        MessageBox.Show("该社区名不存在！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }

                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("连接失败，请检查您的网络！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();

                }
            }
            else
            {
                MessageBox.Show("输入待查找的社区名！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.FromArgb(0,0,0);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.FromArgb(111, 111, 111);
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            if(xButton2.Visible == false)
            {
                MessageBox.Show("没有相应的社区！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                string s11 = this.textBox2.Text;
                string s12 = this.textBox3.Text;

                String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
                MySqlConnection conn = new MySqlConnection(connetStr);

                try
                {
                    conn.Open();
                    string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + gid + ";";
                    Console.WriteLine(up);
                    MySqlCommand cmd = new MySqlCommand(up, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("连接失败，请检查您的网络！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageBox.Show("成功!", "成功");
                    conn.Close();
                    this.Close();
                    this.Dispose();
                    new Manage_community_menu(admin_name).ShowDialog();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_modify(admin_name,0).ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_menu(admin_name).ShowDialog();
        }
    }
}
