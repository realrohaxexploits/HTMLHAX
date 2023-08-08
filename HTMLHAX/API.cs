using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HTMLHAX
{
    public class FormControls
    {
        public string getonlinestring(string url)
        {
            return definers.wc.DownloadString(url);
        }
        public void Close()
        {
            Application.Exit();
        }
        public void downloadfile(string url, string path)
        {
            definers.wc.DownloadFile(url, path);
        }
        public string readfile(string path)
        {
            return File.ReadAllText(path);
        }
        public void writefile(string path, string data)
        {
            File.WriteAllText(path, data);
        }
        public string LoadChosenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Find Scripts";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return File.ReadAllText(ofd.FileName);
            }
            return "";

        }
        public void SaveChosenFile(string data)
        {
           SaveFileDialog ofd = new SaveFileDialog();
           ofd.Title = "Find Scripts";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               File.WriteAllText (ofd.FileName, data);
               
            }
           
            
        }
        public string GetCurrentDirectory()
        {
           return Environment.CurrentDirectory;
        }

    }    
    public class exploitcontrols
    {
        public void executescript(string script) { apicalls.executescript(script); }
        
        
        public void inject() { apicalls.inject(); }
        public void loadscriptfromurl(string url)
        {
            executescript(definers.wc.DownloadString(url));
        }
        public void DoBTools()
        {
            loadscriptfromurl("https://cdn.wearedevs.net/scripts/BTools.txt");
        }
        public void DoDex()
        {
            loadscriptfromurl("https://cdn.wearedevs.net/scripts/Dex%20Explorer.txt");
        }
        public void DoFly()
        {
            loadscriptfromurl("https://cdn.wearedevs.net/scripts/Fly.txt");
        }

    }
}
