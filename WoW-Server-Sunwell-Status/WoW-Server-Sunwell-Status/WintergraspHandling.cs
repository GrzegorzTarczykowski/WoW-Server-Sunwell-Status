using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WoW_Server_Sunwell_Status
{
    class WintergraspHandling
    {
        Match stringWebWintergraspTime;
        public string wintergrasptime;
        public WintergraspHandling(string stringWeb)
        {
            stringWebWintergraspTime = Regex.Match(stringWeb, "(([0-9]+):([0-9]+):([0-9]+))");
            wintergrasptime = stringWebWintergraspTime.Value;
        }
    }
}
