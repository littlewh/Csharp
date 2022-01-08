using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using test_1.Properties;
using MySql.Data.MySqlClient;

namespace test_1
{
    public partial class Index : System.Windows.Forms.Form
    {
        public Index()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(GetLocalIp());
            
            //MessageBox.Show(Get_MD5("13245413324"));
            //IPAddress ip = GetIP();
            //Console.WriteLine(ip.ToString());

            XButton b1 = new XButton();
            b1.Location = new Point(75,200);
            b1.Text = "账密登录";
            b1.Height = 30;
            b1.Width = 90;
            b1.Click += new System.EventHandler(this.b1_Click);
            //b1.BackColor = Color.FromArgb(55, 199, 0);//静止颜色
            //b1.FlatStyle = FlatStyle.Flat;
            //b1.FlatAppearance.BorderSize = 5;
            //b1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);

            XButton b2 = new XButton();
            b2.Location = new Point(275, 200);
            b2.Text = "IP登录";
            b2.Height = 30;
            b2.Width = 90;
            b2.Click += new System.EventHandler(this.b2_Click);
            b2.BackColor = Color.FromArgb(55, 199, 0);//静止颜色
            //b2.FlatStyle = FlatStyle.Flat;
            //b2.FlatAppearance.BorderSize = 5;
            //b2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);

            Image im = Resources.bronya;
            //Image im = Image.FromFile(@"D:\各类作业\大三上学期\c#课程设计\bronya.gif");
            PictureBox pb1 = new PictureBox();
            pb1.Image = im;
            pb1.Width = 440;
            pb1.Height = 265;
            
            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(pb1);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        private IPAddress GetIP()//InternalIP
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in nics)
            {
                foreach (var uni in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (uni.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return uni.Address;
                    }
                }
            }
            return null;
        }

        public static string GetLocalIp()
        {
            string ip = "1.1.1.1";
            try
            {
                string HostName = Dns.GetHostName(); //主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        ip = IpEntry.AddressList[i].ToString();
                        return ip;
                    }
                }
                return ip;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取本机IP出错:" + ex.Message);
                return ip;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ID_login().ShowDialog();//模态
            this.Close();
            this.Dispose();
        }
        private void b2_Click(object sender, EventArgs e)
        {
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string query = "select * from ip_login_whitelist;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                //IPAddress ip = GetIP();
                //Console.WriteLine(ip.ToString());
                string ip = GetLocalIp();
                Console.WriteLine(ip);

                bool flag = false;
                string admin_name = ""; 
                while (reader.Read())
                {
                    string x = reader["ip"].ToString(); 

                    //MessageBox.Show(x+ " " + ip);


                    if (ip.ToString() == x)
                    {
                        admin_name = reader["id"].ToString(); 
                        flag = true;
                        break;
                    }
                }

                reader.Close();

                if (flag == false)
                {
                    MessageBox.Show("当前IP地址无法登录", "DEFEATED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//登陆成功
                {
                    //MessageBox.Show("121");
                    this.Hide();
                    new Admin_menu(admin_name).ShowDialog();//模态
                    this.Close();
                    this.Dispose();
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



    }
}
