﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase_Desktop_Application;
using System.Windows;
using System.Threading;
using System.Collections;
using System.IO;
using Firebase.Database;
using Firebase.Database.Query;

namespace Firebase_Desktop_Application
{

    public partial class FirebaseUi : Form
    {
        Firebase.Database.FirebaseClient firebase;
        public delegate void delegateUpdateUiBox(String text);
        
        public FirebaseUi()
        {
            InitializeComponent();
            MainPage_OnLoaded();
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

        private void MainPage_OnLoaded()
        {
            var auth = Secrets.FirebaseSecret;
            firebase = new Firebase.Database.FirebaseClient(
              Secrets.BasePath,
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              });
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
            delegateUpdateUiBox DelegateUpdateUiBox = new delegateUpdateUiBox(UpdateUiTextBox);
            var observable = firebase
              .Child("input")
              .AsObservable<ChatMessage>()
              .Subscribe(d =>outcomePush.BeginInvoke(DelegateUpdateUiBox, d.Object.text + ""));
            MessageBox.Show(observable+"   yup");
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
                MessageBox.Show(ofd.FileName);
                Excel excel = new Excel(ofd.FileName, 1);
                for (int i = 1; i < 4; i++)
                {
                    pushToDatabase(excel.ReadCell(i, 2) + "", excel.ReadCell(i, 3) + "");
                }

                outcomePush.Text = excel.ReadCell(0, 0) + "";
                MessageBox.Show(excel.ReadCell(0, 0) + "");
            }

        }
    }
}