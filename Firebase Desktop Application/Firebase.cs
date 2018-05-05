using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Reactive.Linq;
using System.Data.OleDb;
using System.Net;
using System.Drawing.Imaging;

namespace Firebase_Desktop_Application
{

    public partial class FirebaseUi : Form
    {
        Firebase.Database.FirebaseClient firebase;
        public delegate void delegateUpdateUiBox(String text);
        IDisposable observable;
        List<string> fileName;
        List<ChatMessage> chats;
        BindingSource fileNameBinding = new BindingSource();
        BindingSource dataGridViewBinding = new BindingSource();

        public FirebaseUi()
        {
            InitializeComponent();
            MainPage_OnLoaded();
        }
        private void MainPage_OnLoaded()
        {
            var auth = Secrets.FirebaseSecret;
            firebase = new Firebase.Database.FirebaseClient(
              Secrets.BasePath,
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              });
            chats = new List<ChatMessage>();

            fileName = new List<string>();
            string[] tArray = (string[])Registry.GetValue(keyName,
            "TestArray",
            new string[] { "Not Found!!" });
            for (int i = 0; i < tArray.Length; i++)
            {
                fileName.Add(tArray[i]);
            }
            dataGridView1.DataSource = dataGridViewBinding;
            fileNameBinding.DataSource = fileName;
            //only add unsold items 

            fileNameListBox.DataSource = fileNameBinding;

        }

        private void push_Click(object sender, EventArgs e)
        {
            //working push gives child as chatmessage object

            pushToDatabase("ritik", "ok");
        }

        private async void update_Click(object sender, EventArgs e)
        {
            // add new item directly to the specified location (this will overwrite whatever data already exists at that location)

            ArrayList liker = new ArrayList();
            liker.Add("12345");
            ArrayList UnLiker = new ArrayList();
            UnLiker.Add("1234");
            ArrayList favourite = new ArrayList();
            favourite.Add("1234");

            await firebase
              .Child("test")
              .PutAsync(new ChatMessage("kk",
                            GetDate(),
                            null,
                            "Ritik",
                            UnLiker,
                            liker, favourite));
            MessageBox.Show("updated!!");

        }

        private async void delete_Click(object sender, EventArgs e)
        {
            //working delete task to delete given node
            await firebase
            .Child("test")
            .DeleteAsync();

            MessageBox.Show("deleted");
        }

        private void nodeListener_Click(object sender, EventArgs e)
        {
            /*var observable = firebase
              .Child("input")
              .AsObservable<ChatMessage>()
              .Subscribe(d => MessageBox.Show(d.Object.text+""));
              */
            /*delegateUpdateUiBox DelegateUpdateUiBox = new delegateUpdateUiBox(UpdateUiTextBox);
            var observable = firebase
              .Child("input")
              .AsObservable<ChatMessage>()
              .Subscribe(d =>outcomePush.BeginInvoke(DelegateUpdateUiBox, d.Object.text + ""));
              */
            delegateUpdateUiBox DelegateUpdateUiBox = new delegateUpdateUiBox(UpdateUiTextBox);
            observable = firebase
              .Child("test")
              .AsObservable<ChatMessage>()
              .Where(f => !string.IsNullOrEmpty(f.Key))
              .Subscribe(f =>
              {
                  if (f.EventType == FirebaseEventType.InsertOrUpdate)
                  {
                      //MessageBox.Show(chats.Any(x => x.timeCurrent == f.Object.timeCurrent)+" ");
                      if (!chats.Any(x => x.timeCurrent == f.Object.timeCurrent)) chats.Add(f.Object);

                      MessageBox.Show("InsertOrUpdate");

                      outcomePush.BeginInvoke(DelegateUpdateUiBox, f.Object.text);
                  }
                  else
                  {
                      chats.Remove(f.Object);
                      MessageBox.Show("Remove");
                      outcomePush.BeginInvoke(DelegateUpdateUiBox, f.Object.text);
                  }
              });
        }

        private void UpdateUiTextBox(string text)
        {   //update ui thread
            //https://www.youtube.com/watch?v=9AIApJmbulY
            outcomePush.Text = text;
        }

        public string RemoveNameSubstring(string name)
        {
            // to access main thread on listener update3
            int index = name.IndexOf("/Name");
            string uniqueKey = (index < 0) ? name : name.Remove(index, "/Name".Length);
            return uniqueKey;


        }

        private void outcomePush_TextChanged(object sender, EventArgs e)
        {

        }

        private void testTime_Click(object sender, EventArgs e)
        {
            observable.Dispose();
        }

        private string GetDate()
        {
            var time = DateTime.Now;
            return time.ToString("MMM dd, yyyy H:mm:ss tt");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length > 0 && messageBox.Text.Length > 0)
            {
                pushToDatabase(nameBox.Text, messageBox.Text);
            }
            else
            {
                nameBox.Text = "";
                messageBox.Text = "";
            }
        }

        private async void pushToDatabase(String name, string text)
        {
            ArrayList liker = new ArrayList();
            liker.Add("12345");
            ArrayList UnLiker = new ArrayList();
            UnLiker.Add("1234");
            ArrayList favourite = new ArrayList();
            favourite.Add("1234");
            var dino = await firebase
              .Child("test")
              .PostAsync(new ChatMessage(
                            text,
                            GetDate(),
                            null,
                            name,
                            UnLiker,
                            liker, favourite));

            //  MessageBox.Show(asd);
            outcomePush.Text = dino.Key;
        }

        private void ExcelLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Excel File";
            ofd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //ofd.FileName = "*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName.Add(ofd.FileName);
                fileNameBinding.DataSource = fileName;

                fileNameBinding.ResetBindings(false);

                //openExcelFile(ofd.FileName, 1);
            }

        }
        Excel excel;
        private void openExcelFile(string path, int sheetNo)
        {
            try
            {
                excel = new Excel(path, 1);
                for (int i = 1; i < 4; i++)
                {
                    pushToDatabase(excel.ReadCell(i, 2) + "", excel.ReadCell(i, 3) + "");
                }

                outcomePush.Text = excel.ReadCell(0, 0) + "";
                MessageBox.Show(excel.ReadCell(0, 0) + "");

                openExcelDataView(path);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("File removed, renamed or deleted");
                fileName.Remove(path);
                fileNameBinding.DataSource = fileName;

                fileNameBinding.ResetBindings(false);

            }
        }

        private string ReadFromRegistry(string key, string subkey)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(subkey);
            if (rk == null)
            {
                MessageBox.Show("read null");
                return null;
            }
            else return rk.GetValue(key.ToUpper()) + "";
        }
        private void WritetoRegistry(string key, string subkey, string value)
        {
            string[] strings = fileName.ToArray();
            Registry.SetValue(keyName, "TestArray", strings);
        }
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey1 = "RegistrySetValueExample";
        const string keyName = userRoot + "\\" + subkey1;

        private void DeleteFromRegistry(string subkey)
        {
            Registry.CurrentUser.DeleteSubKeyTree(subkey);
            MessageBox.Show(subkey + " deleted");
        }

        private void registry_Click(object sender, EventArgs e)
        {
            WritetoRegistry("Name", "hindi", "narendra modi");
        }

        private void readRegistry_Click(object sender, EventArgs e)
        {
            ArrayList liker = new ArrayList();
            liker.Add("12345");
            ArrayList UnLiker = new ArrayList();
            UnLiker.Add("1234");
            ArrayList favourite = new ArrayList();
            favourite.Add("1234");
            ChatMessage asdf = new ChatMessage(
                            "srk",
                            GetDate(),
                            "kuuu",
                            "anushka",
                            UnLiker,
                            liker, favourite);
            chats.Add(asdf);
            MessageBox.Show(chats[0].text);
        }

        private void fileNameListBox_DoubleClick(object sender, EventArgs e)
        {
            if (excel != null)
            {
                excel.Dump();
            }
            openExcelFile(fileNameListBox.SelectedItem.ToString(), 1);

        }

        private void openExcelDataView(string path)
        {
            //solve error by downloading:   https://www.microsoft.com/en-us/download/confirmation.aspx?id=13255
            //try
            //{
            String name = "Sheet1";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            path +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            //con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            //con.Close();
            //}
            //catch (Exception)
            //{
            // MessageBox.Show("Something's wrong");
            //}
        }

        private void printAsExcel_Click(object sender, EventArgs e)
        {

        }

        private void printToDataGrid_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(chats.Count + "");
            //dataGridView1.DataSource = chats;
            //dataGridView1.Update();
            //dataGridView1.Refresh();

            dataGridViewBinding.DataSource = chats;

            dataGridViewBinding.ResetBindings(false);

            dataGridView1.DataSource = dataGridViewBinding;
        }

        private void printToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Sheet1";
            ws.Cells[1, 1] = "S.no";

            for (int i = 1; i <= dataGridView1.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                {
                    // MessageBox.Show(i+":i ;j:"+j);

                    ws.Cells[i + 1, j + 1] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
                ws.Cells[i + 1, 1] = i;
            }


            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "chats";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                // try
                //{
                wb.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("The file would have been saved as " + saveFileDialog.FileName
                );
                fileName.Add(saveFileDialog.FileName);
                fileNameBinding.DataSource = fileName;

                fileNameBinding.ResetBindings(false);
                // }
                //catch (Exception)
                //{
                //  MessageBox.Show("error occured");
                //}
            }
            else
                MessageBox.Show("The Cancel button was clicked or Esc was pressed");


            app.Quit();
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        private void chatMessageBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FirebaseUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("closing");
            WritetoRegistry("Name", "hindi", "narendra modi");

        }

        private void fileNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {
            //con.Close();
            //oconn.Dispose;

            excel.Dump();

        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://i0.wp.com/youmeandtrends.com/wp-content/uploads/2016/05/nayanthara-beautiful-actress-images-Pretty-Indian-Girl-Photos.jpg");
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(str);

                    var imageSize = pictureBox1.Image.Size;
                    var fitSize = pictureBox1.ClientSize;
                    pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;

                }
            }
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                try {
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
                catch (Exception)
                {
                    MessageBox.Show("error occured");
                }

            }
        }

        private void getImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "Images|*.png;*.bmp;*.jpg|jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";

            //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\"; // <---
            //if (Directory.Exists(appPath) == false)                                              // <---
            //{                                                                                    // <---
            //    Directory.CreateDirectory(appPath);                                              // <---
            //}                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---
                    //File.Copy(filepath, appPath + iName); // <---
                    pictureBox1.Image = new Bitmap(opFile.OpenFile());

                    var imageSize = pictureBox1.Image.Size;
                    var fitSize = pictureBox1.ClientSize;
                    pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
    }
}