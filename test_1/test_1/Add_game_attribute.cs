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
    public partial class Add_game_attribute : Form
    {
        string admin_name;
        public Add_game_attribute(string admin_name)
        {
            InitializeComponent();
            this.admin_name = admin_name;
        }

        private void Add_game_attribute_Load(object sender, EventArgs e)
        {
            this.Mask.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.label1.BackColor = Color.FromArgb(200, Mask.BackColor);
            //this.textBox1.BackColor = Color.FromArgb(200, Mask.BackColor);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.BackColor = Color.FromArgb(200, Mask.BackColor);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            String connetStr = "server=115.28.127.66;port=3306;user=gyy;password=Gyy123456;database=games;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connetStr);

            try
            {
                //MessageBox.Show("sonnect success");

                conn.Open();
                string query = "select attributename from gameattribute where attributename = '" + name + "';";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();


                bool bb = reader.Read();
                reader.Close();

                if (bb)
                {
                    MessageBox.Show("该类型已经存在！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string insert = "insert into gameattribute(attributename) values('" + name +  "');";
                    Console.WriteLine(insert);
                    cmd = new MySqlCommand(insert, conn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("成功!", "Success");
                    this.Close();
                    this.Dispose();
                    new Admin_menu(admin_name).ShowDialog();
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
            new Admin_menu(admin_name).ShowDialog();
        }
    }
}
