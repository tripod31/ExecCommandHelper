using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace ExecCommandHelper
{
    public partial class Form_output : Form
    {
        private ExecCommand _ec;
        public Form_output(ExecCommand ec)
        {
            InitializeComponent();
            _ec = ec;
        }

        private void Form_output_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.form_output_size;   // databindingするとおかしくなる
            combobox_encoding.Text = Properties.Settings.Default.output_encoding;
            label_status.Text = "実行中";
            timer1.Start();
        }

        private void Form_output_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this._ec.process.HasExited)
            {
                if (MessageBox.Show("実行中です。中断しますか？", "確認",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this._ec.process.Kill();

                }
                else
                {
                    e.Cancel = true;
                    return; 
                }
            }
            Properties.Settings.Default.output_encoding = combobox_encoding.Text;

        }
        private void button_abort_Click(object sender, EventArgs e)
        {
            if (!this._ec.process.HasExited)
                this._ec.process.Kill();

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string str = _ec.stdout + _ec.stderr;
            //Shift JISとして文字列に変換
            byte[] bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(str);
            str = get_output_encoding().GetString(bytesData);

            textBox1.AppendText(str.Substring(textBox1.Text.Length));   //自動スクロールさせるため差分をappend

            if (this._ec.process.HasExited)
            {
                button_abort.Enabled = false;
                label_status.Text = "終了";
                timer1.Stop();
            }
        }

        private Encoding get_output_encoding()
        {
            Encoding enc = System.Text.Encoding.GetEncoding(932);
            switch (combobox_encoding.Text)
            {
                case "Shift_JIS":
                    enc = System.Text.Encoding.GetEncoding(932);
                    break;
                case "UTF-8":
                    enc = System.Text.Encoding.UTF8;
                    break;
                case "EUC":
                    enc = System.Text.Encoding.GetEncoding(51932);
                    break;

            }
            return enc;
        }


        private void combobox_encoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //Shift JISとして文字列に変換
            byte[] bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(str);
            str = get_output_encoding().GetString(bytesData);
            textBox1.Text = str;
        }


    }
}
