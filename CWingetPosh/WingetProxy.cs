using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace CWingetPosh
{
    static class WingetProxy
    {
        /// <summary>
        /// 
        /// </summary>
        static public List<string> WGList()
        {
            List<string> list = new List<string>();
            PowerShell posh = PowerShell.Create();
            posh.AddScript("winget list");
            //posh.AddScript("$psVersiontable");

            Collection<PSObject> PSOuput;
            PSOuput = posh.Invoke();
            foreach (PSObject obj in PSOuput)
            {
                if (obj != null)
                {
                    byte[] utf8Bytes = Encoding.UTF8.GetBytes(obj.ToString());
                    string utf8String = Encoding.UTF8.GetString(utf8Bytes);
                    list.Add(utf8String);
                }
            }
            return list;
        }
    }
}
