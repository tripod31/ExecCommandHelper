using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExecCommandHelper
{
    /*
        非同期にコマンドを実行  
    */
    public class ExecCommand
    {

        private Process _process;
        private int _errcode = 0;
        private string _errmsg = "";
        private string _stdout = "";
        private string _stderr = "";
        private Encoding _encoding=Encoding.UTF8;

        public Process process
        {
            get { return _process; }
        }
        public int errcode
        {
            get { return _errcode; }
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
        public Encoding Encoding
        {
            get { return _encoding; }
            set
            {
                _encoding = value;
            }
        }

        public ExecCommand()
        {
        }

        // コマンドを非同期を実行
        public int ExecAsync(string exe_file, string args,string exec_dir,Form form=null,EventHandler exited_handler=null)
        {
            _errcode = 0;
            _errmsg = "";
            _stdout = "";
            _stderr = "";

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
                psi.StandardOutputEncoding = _encoding;
                psi.StandardErrorEncoding = _encoding;

                _process = new System.Diagnostics.Process();
                _process.StartInfo = psi;
                //OutputDataReceivedイベントハンドラを追加
                _process.OutputDataReceived += p_OutputDataReceived;
                _process.ErrorDataReceived += p_ErrorDataReceived;

                if (form!=null && exited_handler != null)
                {
                    //イベントハンドラがフォームを作成したスレッドで実行されるようにする
                    _process.SynchronizingObject = form;
                    //イベントハンドラの追加
                    _process.Exited += exited_handler;
                    //プロセスが終了したときに Exited イベントを発生させる
                    _process.EnableRaisingEvents = true;
                }

                _stdout = "";
                _stderr = "";

                _process.Start();

                //非同期で出力の読み取りを開始
                _process.BeginOutputReadLine();
                _process.BeginErrorReadLine();

                //p.WaitForExit();

            }
            catch (Exception e)
            {
                _errmsg = e.Message;
                _errcode = -1;
            }
            return _errcode;
        }

        // コマンドを同期実行
        public int ExecSync(string exe_file, string args, string exec_dir)
        {
            _errcode = 0;
            _errmsg = "";
            _stdout = "";
            _stderr = "";

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

                _process = new System.Diagnostics.Process();
                _process.StartInfo = psi;

                _stdout = "";
                _stderr = "";

                _process.Start();

                //非同期で出力の読み取りを開始
                _stdout=_process.StandardOutput.ReadToEnd();
                _stderr = _process.StandardError.ReadToEnd();

                _process.WaitForExit();

            }
            catch (Exception e)
            {
                _errmsg = e.Message;
                _errcode = -1;
            }
            return _errcode;
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
