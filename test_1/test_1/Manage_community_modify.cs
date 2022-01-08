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
    public partial class Manage_community_modify : NForm
    {
        string admin_name;
        int num;
        string id1 = "";
        string id2 = "";
        string id3 = "";
        string id4 = "";
        string id5 = "";
        string id6 = "";

        public Manage_community_modify(string admin_name,int num)
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
            this.admin_name = admin_name;
            this.num = num;
        }

        private void Manage_community_modify_menu_Load(object sender, EventArgs e)
        {
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.label_name.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label_admin.Text = admin_name;
            this.label_admin.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.Cursor = Cursors.Hand;

            this.linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            this.linkLabel6.LinkBehavior = LinkBehavior.HoverUnderline;
            this.linkLabel1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.linkLabel2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.linkLabel3.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.linkLabel4.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.linkLabel5.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.linkLabel6.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label3.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label4.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label5.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label6.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label7.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label8.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label1.Cursor = Cursors.IBeam;
            this.label2.Cursor = Cursors.IBeam;
            this.label3.Cursor = Cursors.IBeam;
            this.label4.Cursor = Cursors.IBeam;
            this.label5.Cursor = Cursors.IBeam;
            this.label6.Cursor = Cursors.IBeam;
            this.label7.Cursor = Cursors.IBeam; 
            this.label8.Cursor = Cursors.IBeam;

            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;

            this.pictureBox2.Visible = false;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox3.Visible = false;
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox4.Visible = false;
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox4.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox5.Visible = false;
            this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox5.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox6.Visible = false;
            this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox6.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox7.Visible = false;
            this.pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox7.BackgroundImageLayout = BackgroundImageLayout = ImageLayout.Stretch;


            this.pictureBox2.Focus();


            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string query = "select * from gamecommunity where gflag = '1'; ";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    string gid = reader["gid"].ToString();
                    string gname = reader["gname"].ToString();
                    string gppath = reader["gppath"].ToString();
                    string url = reader["gppath"].ToString();
                    Image im = test_1.Properties.Resources.gamecommunity;
                    i++;
                    if (i <= num * 6)
                    {
                        continue;
                    }
                    switch (i % 6)
                    {
                        case 1:
                            {
                                this.textBox1.Visible = true;
                                this.textBox7.Visible = true;
                                this.pictureBox2.Visible = true;
                                this.textBox1.Text = gppath;
                                this.textBox7.Text = gname;
                                this.id1 = gid;
                                //this.linkLabel1.Text = re_rid + " " + re_topic;
                                //this.label1.Text = re_name;


                                //社区头像
                                try
                                {
                                    pictureBox2.Load(url);
                                }
                                catch (Exception ex2)
                                {
                                    pictureBox2.Image = im;
                                }
                                break;
                            }
                        case 2:
                            {
                                this.textBox2.Visible = true;
                                this.textBox8.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.textBox2.Text = gppath;
                                this.textBox8.Text = gname;
                                this.id2 = gid;
                                //this.linkLabel2.Text = re_rid + " " + re_topic;
                                //this.label2.Text = re_name;

                                //社区头像
                                try
                                {
                                    pictureBox3.Load(url);
                                }
                                catch (Exception ex2)
                                {
                                    pictureBox3.Image = im;
                                }
                                break;
                            }
                        case 3:
                            {
                                this.textBox3.Visible = true;
                                this.textBox9.Visible = true;
                                this.pictureBox4.Visible = true;
                                this.textBox3.Text = gppath;
                                this.textBox9.Text = gname;
                                this.id3 = gid;
                                //this.linkLabel3.Text = re_rid + " " + re_topic;
                                //this.label3.Text = re_name;

                                //社区头像
                                try
                                {
                                    pictureBox4.Load(url);
                                }
                                catch (Exception ex2)
                                {
                                    pictureBox4.Image = im;
                                }
                                break;
                            }
                        case 4:
                            {
                                this.textBox4.Visible = true;
                                this.textBox10.Visible = true;
                                this.pictureBox5.Visible = true;
                                this.textBox4.Text = gppath;
                                this.textBox10.Text = gname;
                                this.id4 = gid;
                                //this.linkLabel4.Text = re_rid + " " + re_topic;
                                //this.label4.Text = re_name;

                                //社区头像
                                try
                                {
                                    pictureBox5.Load(url);
                                }
                                catch (Exception ex2)
                                {
                                    pictureBox5.Image = im;
                                }
                                break;
                            }
                        case 5:
                            {
                                this.textBox5.Visible = true;
                                this.textBox11.Visible = true;
                                this.pictureBox6.Visible = true;
                                this.textBox5.Text = gppath;
                                this.textBox11.Text = gname;
                                this.id5 = gid;
                                //this.linkLabel5.Text = re_rid + " " + re_topic;
                                //this.label5.Text = re_name;

                                //社区头像
                                try
                                {
                                    pictureBox6.Load(url);
                                }
                                catch (Exception ex2)
                                {
                                    pictureBox6.Image = im;
                                }
                                break;
                            }
                        case 0:
                            {
                                this.textBox6.Visible = true;
                                this.textBox12.Visible = true;
                                this.pictureBox7.Visible = true;
                                this.textBox6.Text = gppath;
                                this.textBox12.Text = gname;
                                this.id6 = gid;
                                //this.linkLabel6.Text = re_topic;
                                //this.label6.Text = re_name;

                                //社区头像
                                try
                                {
                                    pictureBox7.Load(url);
                                }
                                catch (Exception ex2)
                                {
                                    pictureBox7.Image = im;
                                }
                                break;
                            }
                        default:
                            break;



                    }

                    
                    if (i % 6 == 0)
                    {
                        break;
                    }

                }

                reader.Close();

                query = "select count(*) from gamecommunity where gflag = '1'; ";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                string ss = reader["count(*)"].ToString();
                int sum = int.Parse(ss);
                if (i >= sum)
                {
                    this.xButton1.Text = "提交并退出";
                    this.xButton1.Click -= new System.EventHandler(this.xButton1_Click);
                    this.xButton1.Click += new System.EventHandler(this.xButton1_next_Click);
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Manage_community_menu(admin_name).ShowDialog();//模态
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();
                if (id1 != "")
                {
                    string s11 = this.textBox1.Text;
                    string s12 = this.textBox7.Text;
                    string id = id1;

                    if (s12 != "")
                    {
                        string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                        Console.WriteLine(up);
                        MySqlCommand cmd = new MySqlCommand(up, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }


                }
                if (id2 != "")
                {
                    string s11 = this.textBox2.Text;
                    string s12 = this.textBox8.Text;
                    string id = id2;

                    if (s12 != "")
                    {
                        string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                        Console.WriteLine(up);
                        MySqlCommand cmd = new MySqlCommand(up, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }

                }
                if (id3 != "")
                {
                    string s11 = this.textBox3.Text;
                    string s12 = this.textBox9.Text;
                    string id = id3;

                    if (s12 != "")
                    {
                        string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                        Console.WriteLine(up);
                        MySqlCommand cmd = new MySqlCommand(up, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }

                }
                if (id4 != "")
                {
                    string s11 = this.textBox4.Text;
                    string s12 = this.textBox10.Text;
                    string id = id4;

                    if (s12 != "")
                    {
                        string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                        Console.WriteLine(up);
                        MySqlCommand cmd = new MySqlCommand(up, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }

                }
                if (id5 != "")
                {
                    string s11 = this.textBox5.Text;
                    string s12 = this.textBox11.Text;
                    string id = id5;

                    if (s12 != "")
                    {
                        string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                        Console.WriteLine(up);
                        MySqlCommand cmd = new MySqlCommand(up, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }

                }
                if (id6 != "")
                {
                    string s11 = this.textBox6.Text;
                    string s12 = this.textBox12.Text;
                    string id = id6;

                    if (s12 != "")
                    {
                        string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                        Console.WriteLine(up);
                        MySqlCommand cmd = new MySqlCommand(up, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }

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

                MessageBox.Show("成功!", "成功");

                this.Close();
                this.Dispose();
                new Manage_community_modify(admin_name,num+1).ShowDialog();
            }
            
        }
        private void xButton1_next_Click(object sender, EventArgs e)
        {
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();
                if (id1 != "")
                {
                    string s11 = this.textBox1.Text;
                    string s12 = this.textBox7.Text;
                    string id = id1;

                    string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                    Console.WriteLine(up);
                    MySqlCommand cmd = new MySqlCommand(up, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
                if (id2 != "")
                {
                    string s11 = this.textBox2.Text;
                    string s12 = this.textBox8.Text;
                    string id = id2;

                    string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                    Console.WriteLine(up);
                    MySqlCommand cmd = new MySqlCommand(up, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
                if (id3 != "")
                {
                    string s11 = this.textBox3.Text;
                    string s12 = this.textBox9.Text;
                    string id = id3;

                    string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                    Console.WriteLine(up);
                    MySqlCommand cmd = new MySqlCommand(up, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
                if (id4 != "")
                {
                    string s11 = this.textBox4.Text;
                    string s12 = this.textBox10.Text;
                    string id = id4;

                    string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                    Console.WriteLine(up);
                    MySqlCommand cmd = new MySqlCommand(up, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
                if (id5 != "")
                {
                    string s11 = this.textBox5.Text;
                    string s12 = this.textBox11.Text;
                    string id = id5;

                    string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                    Console.WriteLine(up);
                    MySqlCommand cmd = new MySqlCommand(up, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
                if (id6 != "")
                {
                    string s11 = this.textBox6.Text;
                    string s12 = this.textBox12.Text;
                    string id = id6;

                    string up = "update gamecommunity set gppath = '" + s11 + "',gname = '" + s12 + "' where gid = " + id + ";";
                    Console.WriteLine(up);
                    MySqlCommand cmd = new MySqlCommand(up, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
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

                MessageBox.Show("成功!", "成功");

                this.Close();
                this.Dispose();
                new Manage_community_menu(admin_name).ShowDialog();
            }

        }
    }
}
