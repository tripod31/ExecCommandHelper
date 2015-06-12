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
        private Thread _thread;
        public Form_output(ExecCommand ec)
        {
            InitializeComponent();
            _ec = ec;
        }

        private void Form_output_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.form_output_size;   // databindingするとおかしくなる
            label_status.Text = "実行中";
            this._thread = new Thread(() =>
            {
                bool bExit = false;
                while (!bExit) {
                    Thread.Sleep(100);
                    this.Invoke((Action)(() =>
                    {
                        // Dispatcherを利用してUIスレッドに処理を配送
                        string str = _ec.stdout + _ec.stderr;

                        textBox1.AppendText(str.Substring(textBox1.Text.Length));   //自動スクロールさせるため差分をappend

                        //// 以下のテキストボックススクロール処理をいれると、ボタンのイベント処理に入らない場合がある
                        ////カレット位置を末尾に移動
                        //textBox1.SelectionStart = textBox1.Text.Length;
                        ////テキストボックスにフォーカスを移動
                        //textBox1.Focus();
                        ////カレット位置までスクロール
                        //textBox1.ScrollToCaret();
                                                
                        if (this._ec.process.HasExited)
                        {
                            button_abort.Enabled = false;
                            label_status.Text = "終了";
                            bExit = true;
                        }
                    }));
                }
            });  
            this._thread.Start();  // 別スレッドでの処理開始
 
            //
            // UIのTaskSchedulerを渡す
            // エラーにならないが、画面が固まる
            //

            //Task.Factory.StartNew(() =>
            //{
            //    while (true)
            //    {
            //        System.Threading.Thread.Sleep(1000);
            //        disp_output();
            //    }
            //}, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            
 
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
            Properties.Settings.Default.form_output_size = this.Size;
            if (this._thread.IsAlive)
                this._thread.Abort();
            if (!this._ec.process.HasExited)
                this._ec.process.Kill();

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


    }
}
