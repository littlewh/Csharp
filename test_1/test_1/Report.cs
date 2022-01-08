using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1
{
    public partial class Report : NForm
    {
        [DllImport("user32", EntryPoint = "HideCaret")]
        //禁止焦点
        private static extern bool HideCaret(IntPtr hWnd);
        string admin_name;
        string rid;
        string index;
        public Report(string admin_name,string rid)
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
            this.admin_name = admin_name;
            this.rid = rid;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Report_menu(admin_name).ShowDialog();//模态
        }


        private void Report_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.monthCalendar1.Visible = false;

            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;

            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);

            //label
            this.label_name.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label_name.Focus();
            this.label1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label2.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.label_admin.Text = admin_name;
            this.label_admin.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.label_time.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.linkLabel1.BackColor = Color.FromArgb(200, Mask.BackColor);

            //text
            this.text_message.Multiline = true;
            this.text_message.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.text_topic.ReadOnly = true;
            this.text_message.ReadOnly = true;

            //picture
            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.Cursor = Cursors.Hand;


            this.radioButton1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.radioButton2.BackColor = Color.FromArgb(200, Mask.BackColor);


            HideCaret(this.text_topic.Handle);
            HideCaret(this.text_message.Handle);


            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);

            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string query = "select * from report where rid = " + rid + ";" ;
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                bool bb = reader.Read();

                if (bb)
                {
                    index = reader["rindex"].ToString();
                    string text = reader["rtext"].ToString();
                    string time = reader["rtime"].ToString();
                    string topic = reader["rtopic"].ToString();

                    this.text_topic.Text = topic;
                    this.text_message.Text = text;
                    this.label_time.Text = time;
                }
                else
                {
                    MessageBox.Show("不存在！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string query = "select ctext from comments where cid = " + index + ";";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                string text = reader["ctext"].ToString();
                new Report_text(text).Show();

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

        private void xButton1_Click(object sender, EventArgs e)
        {
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            
            try
            {
                //MessageBox.Show("sonnect success");
                
                conn.Open();
                string up = "update report set rflag = '1' where rid = " + this.rid + ";";
                Console.WriteLine(up);
                MySqlCommand cmd = new MySqlCommand(up, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                up = "update report set roperator = '" + this.admin_name + "' where rid = " + this.rid + ";";
                Console.WriteLine(up);
                cmd = new MySqlCommand(up, conn);
                reader = cmd.ExecuteReader();
                reader.Close();

                if (radioButton1.Checked == true && this.index != "" && this.index != null)//删除评论
                {
                    up = "update comments set cflag = '1' where cid = " + this.index + ";";
                    Console.WriteLine(up);
                    cmd = new MySqlCommand(up, conn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                if (radioButton2.Checked == true && this.index != "" && this.index != null)//找人并且禁言
                {
                    string query = "select uid from comments where cid = " + index + ";";
                    Console.WriteLine(query);
                    cmd = new MySqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string id = reader["uid"].ToString();
                    reader.Close();
                    //Console.WriteLine(id);

                    if (id != "" && id != null)
                    {
                        string d = monthCalendar1.SelectionRange.Start.ToString();
                       

                        query = "select uflag from user where uid = " + id + ";";
                        Console.WriteLine(query);
                        cmd = new MySqlCommand(query, conn);
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        string time = reader["uflag"].ToString();
                        reader.Close();
                        if (time != "0001-01-01 00:00:00")
                        {
                            DialogResult dr = MessageBox.Show("该用户已被禁言至" + time + "是否确定更改至" + d + "？","确认禁言", MessageBoxButtons.OKCancel);
                            if (dr == DialogResult.OK)
                            {
                                up = "update user set uflag = '" + d + "'  where uid = " + id + ";";
                                Console.WriteLine(up);
                                cmd = new MySqlCommand(up, conn);
                                reader = cmd.ExecuteReader();
                                reader.Close();
                            }
                        }
                        else
                        {
                            up = "update user set uflag = '" + d + "'  where uid = " + id + ";";
                            Console.WriteLine(up);
                            cmd = new MySqlCommand(up, conn);
                            reader = cmd.ExecuteReader();
                            reader.Close();
                        }
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
                new Report_menu(admin_name).ShowDialog();
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.monthCalendar1.Visible = true;
            }
            else

            {
                this.monthCalendar1.Visible = false;
            }
        }
        private void text_topic_Enter(object sender, EventArgs e)
        {
            HideCaret(this.text_topic.Handle);
        }

        private void text_message_Enter(object sender, EventArgs e)
        {
            HideCaret(this.text_message.Handle);
        }

        private void text_message_Leave(object sender, EventArgs e)
        {
            HideCaret(this.text_message.Handle);
        }

        private void text_topic_Leave(object sender, EventArgs e)
        {
            HideCaret(this.text_topic.Handle);
        }

        private void text_message_Click(object sender, EventArgs e)
        {
            HideCaret(this.text_message.Handle);
        }
    }
}
