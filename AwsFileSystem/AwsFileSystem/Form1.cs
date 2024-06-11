using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AwsFileSystem
{
    public partial class Home : Form
    {
        AWSServer instance = AWSServer.getInstance();

        FolderBrowserDialog dialog = new FolderBrowserDialog();

        static bool is_connect = false;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set condition
            SetConditionButton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void LoadExplorer()
        {          
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                localBrowser.Url = new Uri(dialog.SelectedPath);
                local_site_txtbox.Text = dialog.SelectedPath;
            }
        }

        private void localBrowser_LocationChanged(object sender, EventArgs e)
        {
            local_site_txtbox.Text = dialog.SelectedPath.ToString();
        }

        private void local_back_btn_Click(object sender, EventArgs e)
        {
            if (localBrowser.CanGoBack)
            {
                localBrowser.GoBack();
                local_site_txtbox.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (localBrowser.CanGoForward)
            {
                localBrowser.GoForward();
                local_site_txtbox.Text = dialog.SelectedPath;
            }
        }

        private void localBrowser_TabIndexChanged(object sender, EventArgs e)
        {
            local_site_txtbox.Text = dialog.SelectedPath.ToString();
        }

        private void server_connect_btn_Click(object sender, EventArgs e)
        {
            RegionEndpoint region = RegionEndpoint.AFSouth1;

            switch (region_combobox.SelectedIndex)
            {
                case 0:
                    region = RegionEndpoint.AFSouth1;
                    break;
                case 1:
                    region = RegionEndpoint.APEast1;
                    break;
                case 2:
                    region = RegionEndpoint.APNortheast1;
                    break;
                case 3:
                    region = RegionEndpoint.APNortheast2;
                    break;
                case 4:
                    region = RegionEndpoint.APSouth1;
                    break;
                case 5:
                    region = RegionEndpoint.APSouth2;
                    break;
                case 6:
                    region = RegionEndpoint.APSoutheast1;
                    break;
                case 7:
                    region = RegionEndpoint.APSoutheast2;
                    break;
                case 8:
                    region = RegionEndpoint.APSoutheast3;
                    break;
                case 9:
                    region = RegionEndpoint.APSoutheast4;
                    break;
            }


            Task.Run(async () =>
            {
                await RunAsync(access_txtbox.Text.Trim()
                                    ,secret_txtbox.Text.Trim(),
                                        region);
            }).GetAwaiter().GetResult();
        
            // load local explorer            
            LoadExplorer();

            // Set condition button
            is_connect = true;

            SetConditionButton();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task RunAsync(string access , string secret , RegionEndpoint region )
        {
            instance.SetAccountAWS(access, secret, region);

            List<S3Bucket> listbucket = await instance.ConnectS3();

            string list_name = string.Empty;

            foreach (var bucket in listbucket)
            {
                list_name += bucket.BucketName;
            }

            serverBrowser.DocumentText = list_name;
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            // disconnect account
            instance.Disconnect();

            // set condition button
            is_connect = false;

            SetConditionButton();
        }

        private void disconnect_btn_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void server_connect_btn_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void SetConditionButton()
        {
            if (is_connect)
            {
                disconnect_btn.Enabled = true;
                server_connect_btn.Enabled = false;
            }
            else
            {
                disconnect_btn.Enabled = false;
                server_connect_btn.Enabled = true;
            }
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
