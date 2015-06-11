using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ExecCommandHelper
{
    public class ExecCommandInfoCtrl
    {
        private List<ExecCommandInfo> _infos;
        public List<ExecCommandInfo> Infos
        {
            get { return _infos; }
        }

        public ExecCommandInfoCtrl()
        {
            _infos = new List<ExecCommandInfo>();
        }

        public ExecCommandInfo get_info(string name)
        {
            return _infos.FirstOrDefault((ExecCommandInfo elem) => elem.name == name);
        }

        public void add_info(ExecCommandInfo info)
        {
            ExecCommandInfo obj = this._infos.FirstOrDefault((ExecCommandInfo elem) => elem.name == info.name);
            if (obj == null)
            {
                _infos.Add(info);
            }
            else
            {
                obj.copy(info);
            }

        }

        public void delete_info(string name)
        {
            ExecCommandInfo obj = _infos.FirstOrDefault((ExecCommandInfo elem) => elem.name == name);
            if (obj != null)
            {
                _infos.Remove(obj);
            }
        }

        public void load_infos(string xml_file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ExecCommandInfo>));
            StreamReader sr = new StreamReader("infos.xml", new UTF8Encoding(false));
            this._infos = (List<ExecCommandInfo>)serializer.Deserialize(sr);
            sr.Close();
        }

        public void save_infos(string xml_file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ExecCommandInfo>));
            StreamWriter sw = new StreamWriter(xml_file, false, new UTF8Encoding(false));
            serializer.Serialize(sw, this._infos);
            sw.Close();
        }



    }

    public class ExecCommandInfo
    {
        private string _name;
        private string _commandLine;
        private string _exec_dir;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }


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

        public ExecCommandInfo(string name,string commandLine,string exec_dir)
        {
            _name = name;
            _commandLine = commandLine;
            _exec_dir = exec_dir;
        }

        public void copy(ExecCommandInfo info)
        {
            _name = info.name;
            _commandLine = info.commandLine;
            _exec_dir = info.exec_dir;
        }
    }
}
