﻿using MySql.Data.MySqlClient;
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
    public partial class Message : NForm
    {
        [DllImport("user32", EntryPoint = "HideCaret")]
        //禁止焦点
        private static extern bool HideCaret(IntPtr hWnd);
        string admin_name;
        string rid;
        public Message(string admin_name, string rid)
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
            new Message_menu(admin_name).ShowDialog();//模态
        }

        private void Message_Load(object sender, EventArgs e)
        {
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.label_name.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label_name.Focus();

            this.label_admin.Text = admin_name;
            this.label_admin.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.label_time.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label3.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label4.BackColor = Color.FromArgb(200, Mask.BackColor);


            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.Cursor = Cursors.Hand;

            this.text_message.Multiline = true;
            this.text_message.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.text_topic.ReadOnly = true;
            this.text_message.ReadOnly = true;

            HideCaret(this.text_topic.Handle);
            HideCaret(this.text_message.Handle);

            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string query = "select * from information where iid = " + rid + ";";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool bb = reader.Read();

                if (bb)
                {
                    string text = reader["itext"].ToString();
                    string time = reader["itime"].ToString();
                    string topic = reader["itopic"].ToString();

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

        private void xButton1_Click(object sender, EventArgs e)
        {
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);

            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string up = "update information set iflag = '1' where iid = " + this.rid + ";";
                Console.WriteLine(up);
                MySqlCommand cmd = new MySqlCommand(up, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();

                up = "update information set ioperator = '" + this.admin_name + "' where iid = " + this.rid + ";";
                Console.WriteLine(up);
                cmd = new MySqlCommand(up, conn);
                reader = cmd.ExecuteReader();
                reader.Close();

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
                new Message_menu(admin_name).ShowDialog();
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
    }
}
