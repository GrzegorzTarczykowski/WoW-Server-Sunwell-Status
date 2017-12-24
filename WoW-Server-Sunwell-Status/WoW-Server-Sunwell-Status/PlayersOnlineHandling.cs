using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WoW_Server_Sunwell_Status
{
    class PlayersOnlineHandling
    {
        MatchCollection stringWebAllianceAndHorde;
        public PlayersOnlineHandling(string stringWeb)
        {
            stringWebAllianceAndHorde = Regex.Matches(stringWeb, "((line-height: 20px; width: )([0-9])+(%\">)([0-9])+)");
        }
        public List<string> returnNumberOnlinePlayers ()
        {
            List<string> listOfOnlinePlayers = new List<string>();
            foreach (Match singleMatch in stringWebAllianceAndHorde)
            {
                Match matche = Regex.Match(singleMatch.Value, "(([0-9])+(%\">)([0-9])+)");
                Match matcheOnline = Regex.Match(matche.Value, "(([0-9])+$)");
                listOfOnlinePlayers.Add(matcheOnline.Value);
            }
            return listOfOnlinePlayers;
        }
        public List<string> returnNumberOnlinePlayersPercent()
        {
            List<string> listOfOnlinePlayersPercent = new List<string>();
            foreach (Match singleMatch in stringWebAllianceAndHorde)
            {
                Match matche = Regex.Match(singleMatch.Value, "(([0-9])+(%\">)([0-9])+)");
                Match matcheOnlinePercent = Regex.Match(matche.Value, "(^([0-9])+)");
                listOfOnlinePlayersPercent.Add(matcheOnlinePercent.Value);
            }
            return listOfOnlinePlayersPercent;
        }
    }
}
