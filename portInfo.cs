using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace on_off_displaying
{
    public partial class portInfo : Form
    {
        public portInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                portListener portList = new portListener(textBox1.Text);
                portList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter port");
            }
        }

      //private
    }
}
