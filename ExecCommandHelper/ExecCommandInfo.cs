using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecCommandHelper
{
    public class ExecCommandInfo
    {
        private string _commandLine;
        private string _exec_dir;
        
        public string commandLine{
            get { return _commandLine; }
            set {_commandLine=value;}
        }
        public string exec_dir
        {
            get { return _exec_dir; }
            set { _exec_dir = value; }
        }

        public ExecCommandInfo()
        {

        }

        public ExecCommandInfo(string commandLine,string exec_dir)
        {
            _commandLine = commandLine;
            _exec_dir = exec_dir;
        }
    }
}
