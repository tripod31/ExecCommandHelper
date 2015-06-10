using ExecCommandHelper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace ExecCommandHelper
{
	public partial class Form_main : Form
	{
		private const string XML_FILE = "infos.xml";
		private List<ExecCommandInfo> _infos = new List<ExecCommandInfo>();

		public Form_main()
		{
			this.InitializeComponent();
			this.load_infos();
		}
		private void load_infos()
		{
			if (File.Exists("infos.xml"))
			{
				try
				{
					XmlSerializer serializer = new XmlSerializer(typeof(List<ExecCommandInfo>));
					StreamReader sr = new StreamReader("infos.xml", new UTF8Encoding(false));
					this._infos = (List<ExecCommandInfo>)serializer.Deserialize(sr);
					sr.Close();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
					return;
				}
				foreach (ExecCommandInfo info in this._infos)
				{
					this.comboBox_infos.Items.Add(info.name);
				}
			}
		}
		private void save_infos()
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(List<ExecCommandInfo>));
				StreamWriter sw = new StreamWriter("infos.xml", false, new UTF8Encoding(false));
				serializer.Serialize(sw, this._infos);
				sw.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
		private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Save();
			this.save_infos();
		}
		private void button_exec_dir_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.SelectedPath = this.textBox_exec_dir.Text;
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.textBox_exec_dir.Text = this.folderBrowserDialog1.SelectedPath;
			}
		}
		private void button_exec_Click(object sender, EventArgs e)
		{
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
			ProcessStartInfo psi = new ProcessStartInfo();
			psi.RedirectStandardInput = false;
			psi.RedirectStandardOutput = true;
			psi.RedirectStandardError = true;
			psi.UseShellExecute = false;
			psi.CreateNoWindow = true;
			psi.FileName = exe_file;
			psi.Arguments = args;
			psi.WorkingDirectory = this.textBox_exec_dir.Text;
			Process p = null;
			try
			{
				p = Process.Start(psi);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			string stdout = p.StandardOutput.ReadToEnd();
			string stderr = p.StandardError.ReadToEnd();
			p.WaitForExit();
			Form_output form = new Form_output(stdout + stderr);
			form.ShowDialog();
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
			if (this.comboBox_infos.Text == "")
			{
				MessageBox.Show("名前を入力してください");
				this.comboBox_infos.Focus();
			}
			else
			{
				ExecCommandInfo info = this.get_info_from_form();
				this.add_info(info);
			}
		}
		private ExecCommandInfo get_info_from_form()
		{
			return new ExecCommandInfo(this.comboBox_infos.Text, this.textBox_commandLine.Text, this.textBox_exec_dir.Text);
		}
		private void add_info(ExecCommandInfo info)
		{
			if (this._infos.Count == 0)
			{
				this._infos.Add(info);
				this.comboBox_infos.Items.Add(info.name);
			}
			else
			{
				ExecCommandInfo obj = this._infos.FirstOrDefault((ExecCommandInfo elem) => elem.name == info.name);
				if (obj == null)
				{
					this._infos.Add(info);
					this.comboBox_infos.Items.Add(info.name);
				}
				else
				{
					obj = info;
				}
			}
		}
		private void disp_info(ExecCommandInfo info)
		{
			this.textBox_commandLine.Text = info.commandLine;
			this.textBox_exec_dir.Text = info.exec_dir;
		}
		private void comboBox_infos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!(this.comboBox_infos.Text == ""))
			{
				string name = this.comboBox_infos.Text;
				ExecCommandInfo info = this._infos.First((ExecCommandInfo elem) => elem.name == name);
				this.disp_info(info);
			}
		}
    }
}
