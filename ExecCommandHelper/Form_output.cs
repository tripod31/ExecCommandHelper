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
                    Thread.Sleep(1000);
                    this.Invoke((Action)(() =>
                    {
                        // Dispatcherを利用してUIスレッドに処理を配送
                        disp_output();
                    }));
                }

            });  
            this._thread.Start();  // 別スレッドでの処理開始
            /*
             * UIのTaskSchedulerを渡す
             * エラーにならないが、画面が固まる
            CancellationTokenSource cts = new CancellationTokenSource();
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                    disp_output();
                }
            }, cts.Token, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            */
            /*
             * UIスレッド以外でコントロールにアクセスするとエラー
            await Task.Run(() =>
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                    disp_output();
                }
            });
            */

        }

        private void Form_output_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.form_output_size = this.Size;
            this._thread.Abort();
        }

        private void button_abort_Click(object sender, EventArgs e)
        {
            if (!this._ec.process.HasExited)
                this._ec.process.Kill();
        }


    }
}
