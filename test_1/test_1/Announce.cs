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
    public partial class Announce : NForm
    {
        private string admin_name;
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        public const int WM_CLOSE = 0x10;
        public Announce(string admin_name)
        {

            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
            this.admin_name = admin_name;
            
        }

        private void Announce_Load(object sender, EventArgs e)
        {
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.label1.Text = admin_name;

            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label2.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label3.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label4.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.pictureBox1.Cursor = Cursors.Hand;


            this.text_topic.ForeColor = Color.FromArgb(111, 111, 111);
            this.text_message.ForeColor = Color.FromArgb(111, 111, 111);
            this.label1.ForeColor = Color.FromArgb(111, 111, 111);
            this.label2.ForeColor = Color.FromArgb(111, 111, 111);


            this.text_message.Multiline = true;
            this.text_message.ScrollBars = RichTextBoxScrollBars.Vertical;


            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
        }

        private void Mask_Click(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_topic_Click(object sender, EventArgs e)
        {
            if(text_topic.Text == "请在此处输入标题，不超过30字。")
            {
                text_topic.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_message_TextChanged(object sender, EventArgs e)
        {
        }

        private void text_message_Click(object sender, EventArgs e)
        {
            
            if (text_message.Text == "在此输入内容。")
            {
                text_message.Clear();
            }
        }

        private void text_topic_Leave(object sender, EventArgs e)
        {
            if (text_topic.Text == "")
            {
                text_topic.Text = "请在此处输入标题，不超过30字。";
            }
            this.text_topic.ForeColor = Color.FromArgb(111, 111, 111);
        }

        private void text_topic_TextChanged(object sender, EventArgs e)
        {
        }

        private void text_topic_Enter(object sender, EventArgs e)
        {
            this.text_topic.ForeColor = Color.FromArgb(0,0,0);
        }

        private void text_topic_Validated(object sender, EventArgs e)
        {

        }

        private void text_message_Enter(object sender, EventArgs e)
        {
            this.text_message.ForeColor = Color.FromArgb(0,0,0);
        }

        private void text_message_Leave(object sender, EventArgs e)
        {
            if (text_message.Text == "")
            {
                text_message.Text = "在此输入内容。";
            }
            this.text_message.ForeColor = Color.FromArgb(111,111,111);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Admin_menu(admin_name).ShowDialog();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            string an_topic = text_topic.Text;
            string an_message = text_message.Text;
            DateTime dt = DateTime.Now;
            string an_time = dt.ToString();
            string an_admin = admin_name;
            //MessageBox.Show(an_time);
            if (text_topic.Text == "" || text_topic.Text == "请在此处输入标题，不超过30字。" || text_message.Text == "" || text_message.Text == "在此输入内容。")
            {
                MessageBox.Show("标题和内容不能为空", "DEFEATED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
                MySqlConnection conn = new MySqlConnection(connetStr);
                try
                {
                    //MessageBox.Show("sonnect success");

                    conn.Open();
                    string insert = "insert into announce(an_topic,an_message,an_operator,an_time) values('" + an_topic + "','" + an_message + "','" + an_admin + "','" +an_time + "');";
                    Console.WriteLine(insert);
                    MySqlCommand cmd = new MySqlCommand(insert, conn);
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
                    conn.Close();

                    StartKiller();
                    MessageBox.Show("发布成功！3秒后返回", "成功");
                    
                    this.Close();
                    this.Dispose();
                    new Admin_menu(admin_name).ShowDialog();
                }

            }
        }
        private void StartKiller()
        {
            Timer timer = new Timer();
            timer.Interval = 3000; //3秒启动 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //停止Timer 
            ((Timer)sender).Stop();

            this.Close();
            this.Dispose();
            new Admin_menu(admin_name).ShowDialog();
        }

    }
}
