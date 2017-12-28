using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WoW_Server_Sunwell_Status
{
    class FactionPictureHandling
    {
        WebClient webCLientToLoadPicture;
        public FactionPictureHandling()
        {
            webCLientToLoadPicture = new WebClient();
        }

        public void loadPicture(string addresToUri, PictureBox pictureBoxToLoadPicture)
        {
            webCLientToLoadPicture.DownloadDataAsync(new Uri(addresToUri), pictureBoxToLoadPicture);
            webCLientToLoadPicture.DownloadDataCompleted += callBackLoadPicture;
        }

        private void callBackLoadPicture(object sender, DownloadDataCompletedEventArgs e)
        {
            var ms = new MemoryStream(e.Result);
            PictureBox currentPictureBox = e.UserState as PictureBox;
            currentPictureBox.Image = Image.FromStream(ms);
        }
    }
}
