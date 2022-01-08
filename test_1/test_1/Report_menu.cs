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
    public partial class Report_menu : NForm
    {
        string admin_name;
        public Report_menu(string admin_name)
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
            this.admin_name = admin_name;
        }

        private void Report_menu_Load(object sender, EventArgs e)
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



            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string query = "select comments.cflag,user.uname,report.rid,report.uid,report.rtopic,report.rflag from user,report,comments where report.uid = user.uid and report.rindex = comments.cid; ";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    string re_rid = reader["rid"].ToString();
                    string re_name = reader["uname"].ToString();
                    string re_topic = reader["rtopic"].ToString();
                    string re_id = reader["uid"].ToString();
                    string re_flag = reader["rflag"].ToString();
                    string co_flag = reader["cflag"].ToString();
                    if (co_flag == "1")
                    {
                        continue;
                    }


                    if (re_flag == "0")
                    {
                        i++;
                        switch(i)
                        {
                            case 1:
                                {
                                    this.linkLabel1.Text = re_rid + " " + re_topic;
                                    this.label1.Text = re_name;
                                    this.toolTip1.SetToolTip(label1, "用户id:" + re_id);
                                    break;
                                }
                            case 2:
                                {
                                    this.linkLabel2.Text = re_rid + " " + re_topic;
                                    this.label2.Text = re_name;
                                    this.toolTip2.SetToolTip(label2, "用户id:" + re_id);
                                    break;
                                }
                            case 3:
                                {
                                    this.linkLabel3.Text = re_rid + " " + re_topic;
                                    this.label3.Text = re_name;
                                    this.toolTip3.SetToolTip(label3, "用户id:" + re_id);
                                    break;
                                }
                            case 4:
                                {
                                    this.linkLabel4.Text = re_rid + " " + re_topic;
                                    this.label4.Text = re_name;
                                    this.toolTip4.SetToolTip(label4, "用户id:" + re_id);
                                    break;
                                }
                            case 5:
                                {
                                    this.linkLabel5.Text = re_rid + " " + re_topic;
                                    this.label5.Text = re_name;
                                    this.toolTip5.SetToolTip(label5, "用户id:" + re_id);
                                    break;
                                }
                            case 6:
                                {
                                    this.linkLabel6.Text = re_rid + " " + re_topic;
                                    this.label6.Text = re_name;
                                    this.toolTip6.SetToolTip(label6, "用户id:" + re_id);
                                    break;
                                }
                            default:
                                break;

                        }

                    }
                    if (i >= 6)
                    {
                        break;
                    }

                }

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

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = linkLabel1.Text;
            if (text != "")
            {
                string rid = text.Split(' ')[0];
                //MessageBox.Show(rid);
                
                this.Close();
                this.Dispose();
                new Report(admin_name,rid).ShowDialog();//模态

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = linkLabel2.Text;
            if (text != "")
            {
                string rid = text.Split(' ')[0];
                //MessageBox.Show(rid);

                this.Close();
                this.Dispose();
                new Report(admin_name, rid).ShowDialog();//模态

            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = linkLabel3.Text;
            if (text != "")
            {
                string rid = text.Split(' ')[0];
                //MessageBox.Show(rid);

                this.Close();
                this.Dispose();
                new Report(admin_name, rid).ShowDialog();//模态

            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = linkLabel4.Text;
            if (text != "")
            {
                string rid = text.Split(' ')[0];
                //MessageBox.Show(rid);

                this.Close();
                this.Dispose();
                new Report(admin_name, rid).ShowDialog();//模态

            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = linkLabel5.Text;
            if (text != "")
            {
                string rid = text.Split(' ')[0];
                //MessageBox.Show(rid);

                this.Close();
                this.Dispose();
                new Report(admin_name, rid).ShowDialog();//模态
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = linkLabel6.Text;
            if (text != "")
            {
                string rid = text.Split(' ')[0];
                //MessageBox.Show(rid);

                this.Close();
                this.Dispose();
                new Report(admin_name, rid).ShowDialog();//模态
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new Admin_menu(admin_name).ShowDialog();//模态
        }
    }
}
