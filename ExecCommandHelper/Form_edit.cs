using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExecCommandHelper
{
    public partial class Form_edit : Form
    {
        private ExecCommandInfo _info;
        public ExecCommandInfo Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public Form_edit( ExecCommandInfo info)
        {
            InitializeComponent();
            _info = info;
            string[] arr = info.commandLine.Split(new Char[]{' '});
            foreach (string str in arr){
                listView1.Items.Add(str);
            }
        }


        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                ListViewItem item = listView1.Items.Add("new");
                item.Selected = true;
            } else { 
                ListViewItem item = listView1.Items.Insert(listView1.SelectedItems[0].Index+1, "new");
                item.Selected = true;
            }
        }

        private void toolStripButton_del_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            int idx = listView1.SelectedItems[0].Index;
            listView1.Items.RemoveAt(idx);
            if (listView1.Items.Count > 0)
            {
                listView1.Items[idx].Selected = true;
            }
        }

        private void toolStripButton_clear_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            listView1.SelectedItems[0].Text="";
        }

        private void button_folder_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            folderBrowserDialog1.SelectedPath = _info.exec_dir;
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string path=folderBrowserDialog1.SelectedPath;
            if (radioButton_relative.Checked)
            {
                path = MakeRelativePath(_info.exec_dir+ Path.DirectorySeparatorChar,path);
            }
            listView1.SelectedItems[0].Text = path;
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            openFileDialog1.InitialDirectory = _info.exec_dir;
            string path = openFileDialog1.FileName;
            if (radioButton_relative.Checked)
            {
                path = MakeRelativePath(_info.exec_dir + Path.DirectorySeparatorChar, path);
            }
            listView1.SelectedItems[0].Text = path;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string str="";
            foreach (ListViewItem item in listView1.Items)
            {
                if (str.Length > 0)
                    str += " ";
                str += item.Text;
            }
            _info.commandLine = str;

        }

        public String MakeRelativePath(String fromPath, String toPath)
        {
            if (String.IsNullOrEmpty(fromPath)) throw new ArgumentNullException("fromPath");
            if (String.IsNullOrEmpty(toPath)) throw new ArgumentNullException("toPath");

            Uri fromUri = new Uri(fromPath);
            Uri toUri = new Uri(toPath);

            if (fromUri.Scheme != toUri.Scheme) { return toPath; } // path can't be made relative.

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            String relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            if (toUri.Scheme.ToUpperInvariant() == "FILE")
            {
                relativePath = relativePath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
            }

            return relativePath;
        }


    }
}
