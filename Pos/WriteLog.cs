using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    class WriteLog
    {
        static public void Start(string name,string type)
        {
            FileInfo s = new FileInfo(Application.StartupPath + @"\gposlog.txt");
            if (s.Exists)
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\gposlog.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string str = sr.ReadToEnd();
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(sr.ReadToEnd());
                sw.WriteLine("관리자 : " + name);
                sw.WriteLine("날짜 : " + DateTime.Now);
                sw.WriteLine("내용 :  " + type);
                sw.Flush();
                sw.Close();
                sr.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\gposlog.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine("관리자 : " + name);
                sw.WriteLine("날짜 : " + DateTime.Now);
                sw.WriteLine("내용 :  "+type);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
    }
}
