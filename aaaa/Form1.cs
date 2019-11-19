using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Par rui = new Par();
        private void Button1_Click(object sender, EventArgs e)
        {
            rui.recebe = textBox1.Text;
            label1.Text = rui.envia;
        }
    }
}
