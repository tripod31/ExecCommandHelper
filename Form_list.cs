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
    public partial class Form_list : Form
    {
        private ExecCommandInfoCtrl _infoCtrl;
        private string _selected_info;

        public string Selected_info { get => _selected_info; set => _selected_info = value; }

        public Form_list(ExecCommandInfoCtrl infoCtrl,string selected_info)
        {
            _infoCtrl = infoCtrl;
            _selected_info = selected_info; 
            InitializeComponent();
        }

        private void Form_list_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.form_list_size;   // databindingするとおかしくなる
            foreach (ExecCommandInfo info in _infoCtrl.Infos)
            {
                int idx = this.listBox1.Items.Add(info.name);
                if (info.name == _selected_info)
                {
                    listBox1.SelectedIndex = idx;
                }
            }
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);

        }

        private void Form_list_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.form_list_size = this.Size;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _selected_info = (string)listBox1.SelectedItem;
            this.Close();
        }
    }
}
