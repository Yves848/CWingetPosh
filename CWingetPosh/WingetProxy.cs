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
        static public void WGList()
        {
            PowerShell posh = PowerShell.Create();
            posh.AddScript("winget list");

            Collection<PSObject> PSOuput;
            PSOuput = posh.Invoke();
            foreach (PSObject obj in PSOuput)
            {
                if (obj != null)
                {
                    Debug.WriteLine(obj.ToString());
                }


            }
        }
    }
}
