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
        private void disp_output()
        {
            textBox1.Text = _ec.stdout + _ec.stderr;
            textBox1.SelectionStart = 0;
        }
        
        private void Form_output_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.form_output_size;   // databindingするとおかしくなる
            this._thread = new Thread(() =>
            {
                while (true) { 
                    Thread.Sleep(100);
                    this.Invoke((Action)(() =>
                    {
                        // Dispatcherを利用してUIスレッドに処理を配送
                        disp_output();
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
            this._thread.Abort();
        }
        private void kill_process()
        {
            if (!this._ec.process.HasExited)
                this._ec.process.Kill();
        }
        private void button_abort_Click(object sender, EventArgs e)
        {
            kill_process();
        }


    }
}
