using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace WoW_Server_Sunwell_Status
{
    public partial class Form1 : Form
    {
        WebClient webClient;
        string stringWeb;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            webClient = new WebClient();
            timerGeneral.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                FactionPictureHandling FPHAlliance = new FactionPictureHandling();
                FPHAlliance.loadPicture("https://sunwell.pl/application/images/misc/alliance2.png", pictureBoxAlliance);
            }).Start();
            new Thread(() =>
            {
                FactionPictureHandling FPHHorde = new FactionPictureHandling();
                FPHHorde.loadPicture("https://sunwell.pl/application/images/misc/horde2.png", pictureBoxHorde);
            }).Start();
            new Thread(() =>
            {
                List<string> listOfOnlinePlayers = new List<string>();
                List<string> listOfOnlinePlayersPercent = new List<string>();
                stringWeb = webClient.DownloadString("https://sunwell.pl/");
                PlayersOnlineHandling playerOnlineHandling = new PlayersOnlineHandling(stringWeb);
                listOfOnlinePlayers = playerOnlineHandling.returnNumberOnlinePlayers();
                listOfOnlinePlayersPercent = playerOnlineHandling.returnNumberOnlinePlayersPercent();
                Invoke(new Action(() =>
                {
                    labelAllianceOnline.Text = listOfOnlinePlayers[0];
                    labelHordeOnline.Text = listOfOnlinePlayers[1];
                    labelAllianceOnlinePercent.Text = listOfOnlinePlayersPercent[0];
                    labelHordeOnlinePercent.Text = listOfOnlinePlayersPercent[1];
                }));
            }).Start();

        }

        private void timerGeneral_Tick(object sender, EventArgs e)
        {
            List<string> listOfOnlinePlayers = new List<string>();
            List<string> listOfOnlinePlayersPercent = new List<string>();
            stringWeb = webClient.DownloadString("https://sunwell.pl/");
            PlayersOnlineHandling playerOnlineHandling = new PlayersOnlineHandling(stringWeb);
            listOfOnlinePlayers = playerOnlineHandling.returnNumberOnlinePlayers();
            listOfOnlinePlayersPercent = playerOnlineHandling.returnNumberOnlinePlayersPercent();
            Invoke(new Action(() =>
            {
                labelAllianceOnline.Text = listOfOnlinePlayers[0];
                labelHordeOnline.Text = listOfOnlinePlayers[1];
                labelAllianceOnlinePercent.Text = listOfOnlinePlayersPercent[0];
                labelHordeOnlinePercent.Text = listOfOnlinePlayersPercent[1];
            }));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerGeneral.Enabled = false;
        }
    }
}
