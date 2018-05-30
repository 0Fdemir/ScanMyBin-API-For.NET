using Newtonsoft.Json;
using ScanMyBinCSharp.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScanMyBinCSharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region "constants"
        private string scanID;
        private System.Net.WebClient wc = new System.Net.WebClient();

        private const string apiKey = "yourapikey"; // Apikey here
        private const string websiteLink = "https://scanmybin.net/result/";
        private const string scanUrl = "https://scanmybin.net/api/new/";
        private const string statusURL = "https://scanmybin.net/api/status/";
        private const string resultURL = "https://scanmybin.net/api/scan/";

        /// <summary>
        ///     0 => "Scan created.",
        ///     1 => "The uploaded file exceeds the upload_max_filesize.",
        ///     2 => "The uploaded file exceeds the MAX_FILE_SIZE directive that was specified in the HTML form.",
        ///     3 => "The uploaded file was only partially uploaded.",
        ///     4 => "Invalid API key.",
        ///     5 => "This API key is expired.",
        ///     6 => "This key can't be used for API.",
        ///     7 => "Max authorized IP for this API."
        ///     0 => "Maintenance Mode."
        ///     </summary>
        private enum UploadFlags
        {
            CREATED = 0,
            UPLOAD_MAX_FILESIZE = 1,
            MAX_FILE_SIZE = 2,
            PARTIALLY_UPLOAD = 3,
            INVALID_APIKEY = 4,
            EXPIRED_APIKEY = 5,
            CANT_USED = 6,
            MAX_AUTHORIZED = 7,
            MAINTENANCE = 8
        }
        #endregion

        #region "functions"

        private delegate void SetStatusDelegate(string text);
        public void SetStatus(string text)
        {
            if (this.InvokeRequired)
            {
                SetStatusDelegate del = new SetStatusDelegate(SetStatus);
                this.BeginInvoke(del, new object[] { text });
            }
            else
                this.lblProgress.Text = text;
        }

        public JsonResult ScanFile(string filename)
        {
            string request;

            SetStatus("Uploading...");

            try
            {
                request = Encoding.UTF8.GetString(wc.UploadFile(scanUrl + apiKey, filename));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            JsonUpload uploadJson = JsonConvert.DeserializeObject<JsonUpload>(request);

            if (uploadJson.Status != (int)UploadFlags.CREATED)
            {
                SetStatus(uploadJson.Status_strg);
                MessageBox.Show(uploadJson.Status_strg);

                return null;
            }

            scanID = uploadJson.scan_id;

            do
            {
                SetStatus("Scanning...");
                System.Threading.Thread.Sleep(2000);
            }
            while (GetStatus().Status == 0); // 0 => "scannig", 1 => "finish"

            SetStatus("Finish");

            JsonResult resultJson = GetResult();

            return resultJson;
        }

        private JsonStatus GetStatus()
        {
            try
            {
                string result = wc.DownloadString(statusURL + scanID);

                JsonStatus parsedJson = JsonConvert.DeserializeObject<JsonStatus>(result);

                return parsedJson;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private JsonResult GetResult()
        {
            try
            {
                string result = wc.DownloadString(resultURL + scanID + "/full");

                JsonResult parsedJson = JsonConvert.DeserializeObject<JsonResult>(result);

                return parsedJson;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Dictionary<string, string> ParseAvResults(JsonResult _jsonResult)
        {
            try
            {
                Dictionary<string, string> avResults = new Dictionary<string, string>();

                foreach (var x in _jsonResult.Data)
                    avResults.Add(x.Key, x.Value);

                return avResults;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public string GetResultLink()
        {
            return websiteLink + scanID;
        }

        private void EnableDisableButton()
        {
            Button[] Buttons = new Button[] { Button1, Button2, Button3 };

            foreach (var ButtonObj in Buttons)
            {
                if (ButtonObj.Enabled == true)
                    ButtonObj.Enabled = false;
                else
                    ButtonObj.Enabled = true;
                ButtonObj.Refresh();
            }
        }

        private void ScanThread()
        {
            try
            {
                EnableDisableButton();

                JsonResult result = ScanFile(fileName.Text);

                if (result != null)
                {
                    txtMD5.Text = result.Md5;
                    resultLink.Text = GetResultLink();
                    lblRatio.Text = result.Detection + "/" + result.Total;
                    lblDate.Text = result.Date.ToString();

                    foreach (var x in result.Data)
                        grid.Rows.Add(new string[] { x.Key.ToString(), x.Value.ToString() });
                }

                EnableDisableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                EnableDisableButton();
            }
        }
        #endregion

        #region "buttons"

        private void Button2_Click(object sender, EventArgs e)
        {
            if (resultLink.Text != null)
                Clipboard.SetText(resultLink.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(fileName.Text) == false)
            {
                MessageBox.Show("File not found!");
                return;
            }

            grid.Rows.Clear();

            new Thread(ScanThread).Start();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "All Files (*.*)|*.*";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
                fileName.Text = dialog.FileName;
            }
        }

        #endregion

        #region "object events"
        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.ColumnIndex == 1)
            {
                if ((string)cell.Value == "Clean")
                    e.CellStyle.ForeColor = Color.Green;
                else
                    e.CellStyle.ForeColor = Color.Red;
            }
            
        }
        #endregion

    }
}
