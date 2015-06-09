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
        public Form_output(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }
    }
}
