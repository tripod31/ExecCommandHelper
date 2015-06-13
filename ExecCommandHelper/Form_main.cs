using ExecCommandHelper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExecCommandHelper
{
	public partial class Form_main : Form
	{
		private const string XML_FILE = "infos.xml";
        private ExecCommandInfoCtrl _infoCtrl = new ExecCommandInfoCtrl();

        private ExecCommand _ec;


		public Form_main()
		{
			this.InitializeComponent();

		}

		private void load_infos()
		{
			if (File.Exists(XML_FILE))
			{
				try
				{
                    _infoCtrl.load_infos(XML_FILE);
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
					return;
				}
				foreach (ExecCommandInfo info in _infoCtrl.Infos)
				{
					this.comboBox_infos.Items.Add(info.name);
				}
			}
		}

		private void save_infos()
		{
			try
			{
                _infoCtrl.save_infos(XML_FILE);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
		{
            Properties.Settings.Default.main_size = this.Size;
            Properties.Settings.Default.selected_info = comboBox_infos.Text;
            Properties.Settings.Default.selline = menuitem_selline.Checked;
			Settings.Default.Save();
			this.save_infos();
		}


		private void button_exec_Click(object sender, EventArgs e)
		{
            //this.Cursor = Cursors.WaitCursor;
            string commandline = this.get_commandLine();
            int pos = commandline.IndexOf(" ");
            string exe_file;
            string args;
            if (pos > 0)
            {
                exe_file = commandline.Substring(0, pos);
                args = commandline.Substring(pos + 1);
            }
            else
            {
                exe_file = commandline;
                args = "";
            }
            string exec_dir = textBox_exec_dir.Text;

            this._ec = new ExecCommand();
            this._ec.ExecAsync(exe_file, args, exec_dir);
            if (this._ec.errcode == 0)
            {
                Form_output form = new Form_output(this._ec);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(this._ec.errmsg);
            }            
        }


        /*
        private void button_abort_Click(object sender, EventArgs e)
        {
            if (!this._ec.process.HasExited)
                this._ec.process.Kill();
        }
        */
        /*
        private void p_Exited(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (this._ec.errcode == 0)
            {
                Form_output form = new Form_output(this._ec.stdout + this._ec.stderr);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(this._ec.errmsg);
            }

        }
        */
        private void button_exec_dir_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.SelectedPath = this.textBox_exec_dir.Text;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox_exec_dir.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }
		private void button_folder_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.SelectedPath = this.textBox_exec_dir.Text;
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				string path = this.folderBrowserDialog1.SelectedPath;
				if (this.radioButton_relativepath.Checked)
				{
					path = this.MakeRelativePath(this.textBox_exec_dir.Text + Path.DirectorySeparatorChar, path);
				}
				this.add_text(path);
			}
		}
		private void add_text(string str)
		{
			this.textBox_commandLine.Text = this.textBox_commandLine.Text.Substring(0, this.textBox_commandLine.SelectionStart) + str + this.textBox_commandLine.Text.Substring(this.textBox_commandLine.SelectionStart + this.textBox_commandLine.SelectionLength);
		}
		private void button_file_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.InitialDirectory = this.textBox_exec_dir.Text;
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string path = this.openFileDialog1.FileName;
				if (this.radioButton_relativepath.Checked)
				{
					path = this.MakeRelativePath(this.textBox_exec_dir.Text + Path.DirectorySeparatorChar, path);
				}
				this.add_text(path);
			}
		}
		private string get_commandLine()
		{
			return this.textBox_commandLine.Text.Replace(Environment.NewLine, " ");
		}
		public string MakeRelativePath(string fromPath, string toPath)
		{
			if (string.IsNullOrEmpty(fromPath))
			{
				throw new ArgumentNullException("fromPath");
			}
			if (string.IsNullOrEmpty(toPath))
			{
				throw new ArgumentNullException("toPath");
			}
			Uri fromUri = new Uri(fromPath);
			Uri toUri = new Uri(toPath);
			string result;
			if (fromUri.Scheme != toUri.Scheme)
			{
				result = toPath;
			}
			else
			{
				Uri relativeUri = fromUri.MakeRelativeUri(toUri);
				string relativePath = Uri.UnescapeDataString(relativeUri.ToString());
				if (toUri.Scheme.ToUpperInvariant() == "FILE")
				{
					relativePath = relativePath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
				}
				result = relativePath;
			}
			return result;
		}
		private void ToolStripMenuItem_font_Click(object sender, EventArgs e)
		{
			this.fontDialog1.Font = this.textBox_commandLine.Font;
			if (this.fontDialog1.ShowDialog() == DialogResult.OK)
			{
				this.textBox_commandLine.Font = this.fontDialog1.Font;
			}
		}
		private void button_save_info_Click(object sender, EventArgs e)
		{
            string name = comboBox_infos.Text;
			if ( name=="")
			{
				MessageBox.Show("名前を入力してください");
				this.comboBox_infos.Focus();
                return;
			}
			
			ExecCommandInfo info_form = this.get_info_from_form();
            ExecCommandInfo info = _infoCtrl.get_info(name);
            if (info != null)
            {
                if (MessageBox.Show(string.Format("{0}:上書きします", name), "保存", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this._infoCtrl.save_info(info_form);
                }
            }
            else
            {
                this.add_info(info_form);
            }
		}
		private ExecCommandInfo get_info_from_form()
		{
			return new ExecCommandInfo(this.comboBox_infos.Text, this.textBox_commandLine.Text, this.textBox_exec_dir.Text);
		}

		private void add_info(ExecCommandInfo info)
		{
            _infoCtrl.add_info(info);
            if (!comboBox_infos.Items.Contains(info.name))
            {
                comboBox_infos.Items.Add(info.name);
            }
						
		}

		private void disp_info(ExecCommandInfo info)
		{
			this.textBox_commandLine.Text = info.commandLine.Replace("\n", Environment.NewLine);
            this.textBox_exec_dir.Text = info.exec_dir;
		}

		private void comboBox_infos_SelectedIndexChanged(object sender, EventArgs e)
		{
            disp_selected_info();
		}

        private void disp_selected_info()
        {
			if (!(this.comboBox_infos.Text == ""))
			{
				string name = this.comboBox_infos.Text;
				ExecCommandInfo info = _infoCtrl.get_info(name);
                if (info != null)
                {
                    this.disp_info(info);
                }
			}
        }

        private void button_delete_info_Click(object sender, EventArgs e)
        {
            if (this.comboBox_infos.Text == "")
            {
                return;
            }
            string name = comboBox_infos.Text;
            if (MessageBox.Show(string.Format("{0}:削除します",name), "削除", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                _infoCtrl.delete_info(name);
                comboBox_infos.Items.Remove(name);
                if (comboBox_infos.Items.Count > 0)
                {
                    comboBox_infos.SelectedIndex = 0;
                }
            }
        }

        private void button_multiline_Click(object sender, EventArgs e)
        {
            string str = textBox_commandLine.Text;
            str = System.Text.RegularExpressions.Regex.Replace(
                str, "[\r\n]+", " ");
            str = System.Text.RegularExpressions.Regex.Replace(
                str, " +", Environment.NewLine);
            textBox_commandLine.Text = str;
        }

        private void button_oneline_Click(object sender, EventArgs e)
        {
            textBox_commandLine.Text = System.Text.RegularExpressions.Regex.Replace(
                textBox_commandLine.Text, "[\r\n]+", " ");         
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            this.load_infos();
            string selected_info = Properties.Settings.Default.selected_info;
            if (comboBox_infos.Items.Contains(selected_info))
            {
                comboBox_infos.Text = selected_info;
                ExecCommandInfo info = _infoCtrl.get_info(selected_info);
                this.disp_info(info);
            }
            textBox_commandLine.SelectionStart = 0;

            this.Size = Properties.Settings.Default.main_size;   // databindingするとおかしくなる
            menuitem_selline.Checked = Properties.Settings.Default.selline; 
        }

        private void button_read_info_Click(object sender, EventArgs e)
        {
            disp_selected_info();
        }

        private void textBox_commandLine_DoubleClick(object sender, EventArgs e)
        {
            if (menuitem_selline.Checked)
            {
                int start_idx = textBox_commandLine.GetFirstCharIndexOfCurrentLine();
                int line_idx = textBox_commandLine.GetLineFromCharIndex(textBox_commandLine.SelectionStart);
                int length = textBox_commandLine.Lines[line_idx].Length;

                textBox_commandLine.SelectionStart = start_idx;
                textBox_commandLine.SelectionLength = length;
            }
           
        }



    }
}
