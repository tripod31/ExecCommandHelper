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

        public Process process
        {
            get { return _p; }
        }
        public int ret_code
        {
            get { return _ret; }
        }
        public string errmsg
        {
            get { return _errmsg; }
        }
        public string stdout
        {
            get { return _stdout; }
        }
        public string stderr
        {
            get { return _stderr; }
        }

        public ExecCommand(Form form)
        {
            _form = form;
        }

        public int Exec(string exe_file, string args,string exec_dir,EventHandler handler)
        {
            _ret = 0;
            _stdout = "";
            _stderr = "";
            _errmsg = "";

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

                _p = new System.Diagnostics.Process();
                _p.StartInfo = psi;
                //OutputDataReceivedイベントハンドラを追加
                _p.OutputDataReceived += p_OutputDataReceived;
                _p.ErrorDataReceived += p_ErrorDataReceived;

                //イベントハンドラがフォームを作成したスレッドで実行されるようにする
                _p.SynchronizingObject = _form;
                //イベントハンドラの追加
                _p.Exited += handler;
                //プロセスが終了したときに Exited イベントを発生させる
                _p.EnableRaisingEvents = true;

                _stdout = "";
                _stderr = "";

                _p.Start();

                //非同期で出力の読み取りを開始
                _p.BeginOutputReadLine();
                _p.BeginErrorReadLine();

                //p.WaitForExit();

            }
            catch (Exception e)
            {
                _errmsg = e.Message;
                _ret = -1;
            }
            return _ret;
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
