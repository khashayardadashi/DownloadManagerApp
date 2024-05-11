using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void url_TextChanged(object sender, EventArgs e)
        {
            filename.Text = Path.GetFileName(url.Text);
        }

        private void download_Click(object sender, EventArgs e)
        {
            var webclient = new WebClient();
            webclient.DownloadFileCompleted += Webclient_DownloadFileCompleted;
            webclient.DownloadProgressChanged += Webclient_DownloadProgressChanged;
            webclient.DownloadFileAsync(new Uri(url.Text), filename.Text);
        }

        private void Webclient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            num.Text = $"{e.ProgressPercentage}%";
        }

        private void Webclient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
        }
    }
}
