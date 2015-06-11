using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExecCommandHelper
{
    class ExecCommand
    {
        private Form _form;
        private Process _p;
        private int _ret = 0;
        private string _errmsg = "";
        private string _stdout = "";
        private string _stderr = "";


        public ExecCommand(Form form)
        {
            _form = form;
        }

        private int Exec(string exe_file, string args, string exec_dir, out string stdout, out string stderr, out string errmsg,EventHandler handler)
        {
            int ret = 0;
            stdout = "";
            stderr = "";
            errmsg = "";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.FileName = exe_file;
                psi.Arguments = args;
                psi.WorkingDirectory = exec_dir;

                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo = psi;
                //OutputDataReceivedイベントハンドラを追加
                p.OutputDataReceived += p_OutputDataReceived;
                p.ErrorDataReceived += p_ErrorDataReceived;

                //イベントハンドラがフォームを作成したスレッドで実行されるようにする
                p.SynchronizingObject = _form;
                //イベントハンドラの追加
                p.Exited += handler;
                //プロセスが終了したときに Exited イベントを発生させる
                p.EnableRaisingEvents = true;

                _stdout = "";
                _stderr = "";

                p.Start();

                //非同期で出力の読み取りを開始
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();

                _p = p;
                //p.WaitForExit();

            }
            catch (Exception e)
            {
                _errmsg = e.Message;
                ret = -1;
            }
            return ret;
        }
        //OutputDataReceivedイベントハンドラ
        //行が出力されるたびに呼び出される
        private void p_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (_stdout.Length > 0)
                _stdout += Environment.NewLine;
            _stdout += e.Data;
        }
        //ErrorDataReceivedイベントハンドラ
        private void p_ErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (_stderr.Length > 0)
                _stderr += Environment.NewLine;
            _stderr += e.Data;
        }
        private void p_Exited(object sender, EventArgs e)
        {

        }
    }
}
