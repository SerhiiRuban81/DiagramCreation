using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagrams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello git!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Second btn!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is btn for test");
        }
    }
}
