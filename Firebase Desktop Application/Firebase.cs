using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase_Desktop_Application;
using System.Collections;
using System.IO;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Reactive.Linq;
using System.Data.OleDb;

namespace Firebase_Desktop_Application
{

    public partial class FirebaseUi : Form
    {
        Firebase.Database.FirebaseClient firebase;
        public delegate void delegateUpdateUiBox(String text);
        IDisposable observable;
        List<string> fileName;
        BindingSource fileNameBinding = new BindingSource();
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
            fileName = new List<string>();
            string[] tArray = (string[])Registry.GetValue(keyName,
            "TestArray",
            new string[] { "Not Found!!" });
            for (int i = 0; i < tArray.Length; i++)
            {
                fileName.Add(tArray[i]);
            }
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
              .Child("input")
              .AsObservable<ChatMessage>()
              .Where(f => !string.IsNullOrEmpty(f.Key))
              .Subscribe(f =>
              {
                  if (f.EventType == FirebaseEventType.InsertOrUpdate)
                  {
                      MessageBox.Show("InsertOrUpdate");
                      outcomePush.BeginInvoke(DelegateUpdateUiBox, f.Object.text);
                  }
                  else
                  {
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
            //custom object to support existing database
            ArrayList liker = new ArrayList();
            liker.Add("12345");
            ArrayList UnLiker = new ArrayList();
            UnLiker.Add("1234");
            ArrayList favourite = new ArrayList();
            favourite.Add("1234");
            var dino = await firebase
              .Child("input")
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
            ofd.FileName = "*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName.Add(ofd.FileName);
                fileNameBinding.DataSource = fileName;

                fileNameBinding.ResetBindings(false);

                //openExcelFile(ofd.FileName, 1);
            }

        }

        private void openExcelFile(string path,int sheetNo)
        {
            try
            {
                Excel excel = new Excel(path, 1);
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

        private string ReadFromRegistry(string key,string subkey)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(subkey);
            if (rk == null)
            {
                MessageBox.Show("read null");
                return null;
            }
            else return rk.GetValue(key.ToUpper()) + "";
        }
        private void WritetoRegistry(string key,string subkey,string value)
        {
            List<string> liker = new List<string>();
            liker.Add("12345");
            liker.Add("45678");
            
            string[] strings = fileName.ToArray();
            Registry.SetValue(keyName, "TestArray", strings);
        }
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey1 = "RegistrySetValueExample";
        const string keyName = userRoot + "\\" + subkey1;

        private void DeleteFromRegistry(string subkey)
        {
            Registry.CurrentUser.DeleteSubKeyTree(subkey);
            MessageBox.Show(subkey+" deleted");
        }


        private void registry_Click(object sender, EventArgs e)
        {
            WritetoRegistry("Name", "hindi", "narendra modi");
        }

        private void readRegistry_Click(object sender, EventArgs e)
        {
            
        }

        private void fileNameListBox_DoubleClick(object sender, EventArgs e)
        {
            openExcelFile(fileNameListBox.SelectedItem.ToString(), 1);

        }

        private void openExcelDataView(string path)
        {

            //solve error by downloading:   https://www.microsoft.com/en-us/download/confirmation.aspx?id=13255
            try
            {
                String name = "Sheet1";
                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                path +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Something's wrong");
            }
        }
    }
}