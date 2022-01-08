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
    public partial class Report_text : Form
    {
        public Report_text(string text)
        {
            InitializeComponent();
            this.text = text;
        }

        private void Report_text_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Multiline = true;
            this.richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Text = text;
            this.richTextBox1.ReadOnly = true;


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        string text;
    }
}
