using MySql.Data;
using MySql.Data.MySqlClient;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1
{
    public partial class ID_login : Form
    {
        public ID_login()
        {
            InitializeComponent();
        }

        private void ID_login_Load(object sender, EventArgs e)
        {
            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.name.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.password.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.remember.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.backlabel.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.backlabel.Focus();

            XButton submit = new XButton();
            submit.Location = new Point(133, 222);
            submit.Text = "登    录";
            submit.Height = 30;
            submit.Width = 180;
            submit.Click += new System.EventHandler(this.submit_Click);

            submit.BackColor = Color.FromArgb(55, 199, 0);//静止颜色
            submit.FlatStyle = FlatStyle.Flat;
            submit.FlatAppearance.BorderSize = 5;
            submit.FlatAppearance.BorderColor = Color.FromArgb(0,0,0,0);
            this.Controls.Add(submit);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            string re = @"^\w+$";//数字、字母、下划线
            string s1 = textBox1.Text;
            string temp_s2 = textBox2.Text;
            string s2 = Get_MD5(temp_s2);
            Console.WriteLine(s2);
            

            if (!Regex.IsMatch(s1, re))
            {
                MessageBox.Show("用户名不合法");
            }
            else
            {
                String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
                MySqlConnection conn = new MySqlConnection(connetStr);
                try
                {
                    //MessageBox.Show("sonnect success");

                    conn.Open();
                    string query = "select * from admin;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    bool flag1 = false;
                    bool flag2 = false;
                    while (reader.Read())
                    {
                        string name = reader["account"].ToString(); 
                        string password = reader["apassword"].ToString(); 

                        if (name == s1)
                        {
                            flag1 = true;
                            if (password == s2)
                            {
                                flag2 = true;
                                break;
                            }
                        }
                       
                    }

                    reader.Close();

                    if (flag1 == false || flag2 == false)
                    {
                        MessageBox.Show("用户名或密码错误", "DEFEATED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else//登陆成功
                    {
                        if (remember.Checked == true)
                        {
                            //IPAddress ip = GetIP();
                            string ip = GetLocalIp();

                            query = "select * from ip_login_whitelist;";
                            cmd = new MySqlCommand(query, conn);
                            reader = cmd.ExecuteReader();
                            bool flag_ip = true;
                            bool flag_name = true;
                            while (reader.Read())
                            {
                                string temp_ip = reader["ip"].ToString(); 
                                string temp_name = reader["id"].ToString(); 

                                if (temp_ip == ip)
                                {
                                    flag_ip = false;//找到ip
                                    if (temp_name != s1)
                                    {
                                        //Console.WriteLine(temp_name);
                                        //Console.WriteLine(s1);
                                        flag_name = false;
                                    }
                                    break;
                                }

                            }
                            reader.Close();

                            if (flag_ip == true)//ip没用过
                            {
                                string insert = "insert into ip_login_whitelist(id,ip) values('" + s1 + "','" + ip + "');";
                                Console.WriteLine(insert);
                                cmd = new MySqlCommand(insert, conn);
                                reader = cmd.ExecuteReader();

                                reader.Close();
                            }
                            else if (flag_ip == false && flag_name == false)//找到ip并且不是自己
                            {
                                MessageBox.Show("当前IP地址已经被其他管理员绑定", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }



                        }
                        this.Hide();
                        new Admin_menu(s1).ShowDialog();//模态
                        this.Close();
                        this.Dispose();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("登录失败，请检查您的网络！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    conn.Close();
                }
            }
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

        public static string Get_MD5(string txt)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(txt);
                byte[] newBuffer = mi.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString().ToUpper();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox1.Text == "仅能由英文、数字、下划线组成")
            {
                textBox1.Text = "";
            }
            
        }

        private void Mask_Click(object sender, EventArgs e)
        {

        }

        private void backlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            this.Close();
            this.Dispose();
            new Index().ShowDialog();//模态
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
