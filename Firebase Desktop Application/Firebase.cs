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

namespace Firebase_Desktop_Application
{
    public partial class FirebaseUi : Form
    {
        public FirebaseUi()
        {
            InitializeComponent();
            MainPage_OnLoaded();
        }

        private async void push_Click(object sender, EventArgs e)
        {
            //working push gives child as chatmessage object
            ChatMessage todo = new ChatMessage
            {
                name = "Execute PUSH",
                text = "kk"
            };
            PushResponse response = await _client.PushAsync("test", todo);
            var asd = response.Result.name;

            //  MessageBox.Show(asd);
            outcomePush.Text = asd;
        }

        private async void update_Click(object sender, EventArgs e)
        {
            //working update updates current node with chatmessage object
            ChatMessage todo = new ChatMessage
            {
                name = "Execute UPDATE!",
                text = "update"
            };

            FirebaseResponse response = await _client.UpdateAsync("test/-LAXwhU7mV1oCiscwZiG", todo);
            ChatMessage todo1 = response.ResultAs<ChatMessage>(); //The response will contain the data written
            MessageBox.Show(todo1.name);
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

    }
}