using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.BrowserSubprocess;
using CefSharp;
using CefSharp.Core;


namespace HTMLHAX
{
    public partial class HTMLHAX : Form
    {
        public HTMLHAX()
        {
            InitializeComponent();
            //These lines of code basically translate the C# classes into Javascript classes.
            MainBrowser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            MainBrowser.JavascriptObjectRepository.Register("exploit",
                new exploitcontrols(),false, options: BindingOptions.DefaultBinder);
            MainBrowser.JavascriptObjectRepository.Register("app",
                new FormControls(), false, options: BindingOptions.DefaultBinder);
        }

        private void HTMLHAX_Load(object sender, EventArgs e)
        {
            MainBrowser.LoadUrl(definers.url);   
        }
    }
}
