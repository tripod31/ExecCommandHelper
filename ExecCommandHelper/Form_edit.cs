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
            textBox1.Lines=arr;
        }


        private void button_folder_Click(object sender, EventArgs e)
        {
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
            add_text(path);
        }

        // textBoxに文字列を挿入
        private void add_text(string str)
        {
            this.textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart)
                + str
                + textBox1.Text.Substring(textBox1.SelectionStart + textBox1.SelectionLength);
        }


        private void button_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = _info.exec_dir;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string path = openFileDialog1.FileName;
            if (radioButton_relative.Checked)
            {
                path = MakeRelativePath(_info.exec_dir + Path.DirectorySeparatorChar, path);
            }
            add_text( path);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string str="";
            foreach (string line in textBox1.Lines)
            {
                if (str.Length > 0)
                    str += " ";
                str += line;
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
