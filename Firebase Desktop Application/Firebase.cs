using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using Firebase_Desktop_Application;
using System.Windows;
using FireSharp.EventStreaming;
using System.Threading;
using System.Collections;

namespace Firebase_Desktop_Application
{

    public partial class FirebaseUi : Form
    {
        public delegate void delegateUpdateUiBox(String text);
        IFirebaseConfig config1 = new FirebaseConfig
        {

            AuthSecret = Secrets.FirebaseSecret,
            BasePath = Secrets.BasePath

        };

        public FirebaseUi()
        {
            InitializeComponent();
            MainPage_OnLoaded();
        }

        private async void push_Click(object sender, EventArgs e)
        {
            //working push gives child as chatmessage object

            pushToDatabase("ritik","ok");
        }

        private async void update_Click(object sender, EventArgs e)
        {
            //working update updates current node with chatmessage object

            //custom object to support existing database
            ArrayList liker = new ArrayList();
            liker.Add("12345");
            ArrayList UnLiker = new ArrayList();
            UnLiker.Add("1234");
            ArrayList favourite = new ArrayList();
            favourite.Add("1234");
            ChatMessage todo = new ChatMessage
            {
                text = "kk",
                timeCurrent = GetDate(),
                photoUrl = null,
                posterId = "Ritik",
                saveIt = favourite,
                unlikedUsers = UnLiker,
                likedUsers = liker
            };

            FirebaseResponse response = await _client.UpdateAsync("test", todo);
            ChatMessage todo1 = response.ResultAs<ChatMessage>(); //The response will contain the data written
            MessageBox.Show(todo1.text);
        }

        private static FirebaseClient _client;

        private void MainPage_OnLoaded()
        {

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = Secrets.FirebaseSecret,
                BasePath = Secrets.BasePath
            };

            _client = new FirebaseClient(config);


        }

        private async void delete_Click(object sender, EventArgs e)
        {
            //working delete task to delete given node
            FirebaseResponse response = await _client.DeleteAsync("test"); //Deletes test collection
            Console.WriteLine(response.StatusCode);
            MessageBox.Show(response.StatusCode + "");
        }

        private async void nodeListener_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ready");
            //attach listener in different thread to input object
            EventStreamResponse response = await _client.OnAsync("input", (sender1, args, context) =>
            {

                delegateUpdateUiBox DelegateUpdateUiBox = new delegateUpdateUiBox(UpdateUiTextBox);
                outcomePush.BeginInvoke(DelegateUpdateUiBox, args.Data);
                
                MessageBox.Show("data: " + args.Data);

                //string paths = args.Path;
               // string key = RemoveNameSubstring(paths);
               // string uniqueKey = key.Split('/').Last();
               // MessageBox.Show("path: " + args.Path);
               // MessageBox.Show("key: " + key);
               // MessageBox.Show("uniquekey: " + uniqueKey);

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
           
        }

        private string GetDate()
        {
            var time = DateTime.Now;
            return time.ToString("MMM dd, yyyy H:mm:ss tt");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(nameBox.Text.Length > 0 && messageBox.Text.Length > 0)
            {
                pushToDatabase(nameBox.Text, messageBox.Text);
            }
            else
            {
                nameBox.Text = "";
                messageBox.Text = "";
            }
        }

        private async void pushToDatabase(String name,string text)
        {
            //custom object to support existing database
            ArrayList liker = new ArrayList();
            liker.Add("12345");
            ArrayList UnLiker = new ArrayList();
            UnLiker.Add("1234");
            ArrayList favourite = new ArrayList();
            favourite.Add("1234");
            ChatMessage todo = new ChatMessage
            {
                text = text,
                timeCurrent = GetDate(),
                photoUrl = null,
                posterId = name,
                saveIt = favourite,
                unlikedUsers = UnLiker,
                likedUsers = liker
            };
            PushResponse response = await _client.PushAsync("input", todo);
            var asd = response.Result.name;

            //  MessageBox.Show(asd);
            outcomePush.Text = asd;
        }
    }
}