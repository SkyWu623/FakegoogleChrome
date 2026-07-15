using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace google
{
    public partial class Form2 : Form
    {
        public string Txt { get; set; }
        public string urltext { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.Text = $"{urltext}-Google搜尋";
            textBox1.Text = this.Txt;
            URL.Text = $"https://www.google.com/search?id=<{this.urltext}> chrome&ie=UTF-8&safe=active&ssui=on";
        }
    }
}
