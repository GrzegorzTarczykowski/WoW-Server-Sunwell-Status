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
        PictureBox currentPictureBoxToLoad;
        string currentAddressToUri;
        public FactionPictureHandling(string addresToUri, PictureBox pictureBoxToLoadPicture)
        {
            webCLientToLoadPicture = new WebClient();
            currentAddressToUri = addresToUri;
            currentPictureBoxToLoad = pictureBoxToLoadPicture;
        }

        public void loadPicture()
        {
            webCLientToLoadPicture.DownloadDataAsync(new Uri(currentAddressToUri));
            webCLientToLoadPicture.DownloadDataCompleted += callBackLoadPicture;
        }

        private void callBackLoadPicture(object sender, DownloadDataCompletedEventArgs e)
        {
            var ms = new MemoryStream(e.Result);
            currentPictureBoxToLoad.Image = Image.FromStream(ms);
        }
    }
}
