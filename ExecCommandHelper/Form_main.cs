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


    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }
        
        private void ToolStripMenuItem_load_Click(object sender, EventArgs e)
        {
            //保存元のファイル名
            openFileDialog1.DefaultExt = "xml";
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = this.openFileDialog1.FileName;

            //XmlSerializerオブジェクトを作成
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(ExecCommandInfo));
            //読み込むファイルを開く
            System.IO.StreamReader sr = new System.IO.StreamReader(
                fileName, new System.Text.UTF8Encoding(false));
            //XMLファイルから読み込み、逆シリアル化する
            ExecCommandInfo obj = (ExecCommandInfo)serializer.Deserialize(sr);
            //ファイルを閉じる
            sr.Close();
            textBox_commandLine.Text = obj.commandLine;
            textBox_exec_dir.Text = obj.exec_dir;

        }

        private void ToolStripMenuItem_save_Click(object sender, EventArgs e)
        {
            //保存先のファイル名
            saveFileDialog1.DefaultExt = "xml";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = saveFileDialog1.FileName;

            //保存するクラス(SampleClass)のインスタンスを作成
            ExecCommandInfo obj = new ExecCommandInfo(textBox_commandLine.Text,textBox_exec_dir.Text);

            //XmlSerializerオブジェクトを作成
            //オブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(ExecCommandInfo));
            //書き込むファイルを開く（UTF-8 BOM無し）
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));
            //シリアル化し、XMLファイルに保存する
            serializer.Serialize(sw, obj);
            //ファイルを閉じる
            sw.Close();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button_exec_dir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBox_exec_dir.Text;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_exec_dir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            string exe_file,args;
            int pos = textBox_commandLine.Text.IndexOf(" ");
            if (pos > 0)
            {
                exe_file = textBox_commandLine.Text.Substring(0, pos);
                args = textBox_commandLine.Text.Substring(pos+1);
            }
            else
            {
                exe_file = textBox_commandLine.Text;
                args = "";
            }
            
            System.Diagnostics.ProcessStartInfo psi =
                new System.Diagnostics.ProcessStartInfo();

            //出力を読み取れるようにする
            psi.RedirectStandardInput = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            //ウィンドウを表示しないようにする
            psi.CreateNoWindow = true;

            psi.FileName = exe_file;
            psi.Arguments = args;
            psi.WorkingDirectory = textBox_exec_dir.Text;
            //起動
            System.Diagnostics.Process p=null;
            try
            {
                p = System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //出力を読み取る
            string stdout = p.StandardOutput.ReadToEnd();
            string stderr = p.StandardError.ReadToEnd();
            //WaitForExitはReadToEndの後である必要がある
            //(親プロセス、子プロセスでブロック防止のため)
            p.WaitForExit();

            Form_output form = new Form_output(stdout + stderr);
            form.ShowDialog();

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            ExecCommandInfo info = new ExecCommandInfo(textBox_commandLine.Text,textBox_exec_dir.Text);
            Form_edit form = new Form_edit( info);
            if (form.ShowDialog() == DialogResult.OK)
            {
                textBox_commandLine.Text = form.Info.commandLine;
            }
        }


    }


}
