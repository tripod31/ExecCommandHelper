using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecCommandHelper
{
    public partial class Form_output : Form
    {
        private string _str;
        public Form_output(string str)
        {
            InitializeComponent();
            _str = str;
        }

        private void Form_output_Load(object sender, EventArgs e)
        {
            textBox1.Text = _str;
            textBox1.SelectionStart = 0;
        }
    }
}
