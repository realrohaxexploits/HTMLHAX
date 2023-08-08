using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTMLHAX
{
     public static class definers
    {   
        // WebClient for loading scripts from websites (Similar to "loadstring(game:HttpGet("")"
        public static WebClient wc = new WebClient();
        // Set this to the URL on your website with your exploit's UI and Code
        public static string url = "https://github.com/realrohaxexploits/HTMLHAX";
        // Add your exploit api's class (if it has one) below.

    }
    public static class apicalls
    {
        //Define your execution and injection functions here.
        //If your making a custom api with extra functions, add them here and modify API.cs > exploitcontrols
        public static void executescript(string script)
        {

        }
        public static void inject()
        {

        }
    }
}
