﻿namespace Firebase_Desktop_Application
{
    partial class FirebaseUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.push = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.outcomePush = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.nodeListener = new System.Windows.Forms.Button();
            this.disposeListener = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExcelLocation = new System.Windows.Forms.Button();
            this.registry = new System.Windows.Forms.Button();
            this.readRegistry = new System.Windows.Forms.Button();
            this.fileNameListBox = new System.Windows.Forms.ListBox();
            this.printAsExcel = new System.Windows.Forms.Button();
            this.printToExcel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProcessingLabel = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.test = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.getImage = new System.Windows.Forms.Button();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uploadToFirebase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatMessageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // push
            // 
            this.push.Location = new System.Drawing.Point(30, 57);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 23);
            this.push.TabIndex = 0;
            this.push.Text = "push";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(187, 57);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 1;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // outcomePush
            // 
            this.outcomePush.Location = new System.Drawing.Point(12, 12);
            this.outcomePush.Name = "outcomePush";
            this.outcomePush.Size = new System.Drawing.Size(477, 22);
            this.outcomePush.TabIndex = 2;
            this.outcomePush.TextChanged += new System.EventHandler(this.outcomePush_TextChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(369, 57);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // nodeListener
            // 
            this.nodeListener.Location = new System.Drawing.Point(477, 57);
            this.nodeListener.Name = "nodeListener";
            this.nodeListener.Size = new System.Drawing.Size(75, 23);
            this.nodeListener.TabIndex = 4;
            this.nodeListener.Text = "listener";
            this.nodeListener.UseVisualStyleBackColor = true;
            this.nodeListener.Click += new System.EventHandler(this.nodeListener_Click);
            // 
            // disposeListener
            // 
            this.disposeListener.Location = new System.Drawing.Point(742, 57);
            this.disposeListener.Name = "disposeListener";
            this.disposeListener.Size = new System.Drawing.Size(116, 23);
            this.disposeListener.TabIndex = 5;
            this.disposeListener.Text = "delete listener";
            this.disposeListener.UseVisualStyleBackColor = true;
            this.disposeListener.Click += new System.EventHandler(this.testTime_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameBox.Location = new System.Drawing.Point(248, 101);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(120, 26);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "Name";
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageBox.Location = new System.Drawing.Point(12, 101);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(196, 26);
            this.messageBox.TabIndex = 7;
            this.messageBox.Text = "Message";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(385, 98);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(104, 29);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.timeCurrentDataGridViewTextBoxColumn,
            this.photoUrlDataGridViewTextBoxColumn,
            this.posterIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chatMessageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 130);
            this.dataGridView1.TabIndex = 9;
            // 
            // ExcelLocation
            // 
            this.ExcelLocation.Location = new System.Drawing.Point(672, 151);
            this.ExcelLocation.Name = "ExcelLocation";
            this.ExcelLocation.Size = new System.Drawing.Size(104, 62);
            this.ExcelLocation.TabIndex = 10;
            this.ExcelLocation.Text = "Open";
            this.ExcelLocation.UseVisualStyleBackColor = true;
            this.ExcelLocation.Click += new System.EventHandler(this.ExcelLocation_Click);
            // 
            // registry
            // 
            this.registry.Location = new System.Drawing.Point(527, 96);
            this.registry.Name = "registry";
            this.registry.Size = new System.Drawing.Size(116, 31);
            this.registry.TabIndex = 11;
            this.registry.Text = "write registry";
            this.registry.UseVisualStyleBackColor = true;
            this.registry.Click += new System.EventHandler(this.registry_Click);
            // 
            // readRegistry
            // 
            this.readRegistry.Location = new System.Drawing.Point(672, 104);
            this.readRegistry.Name = "readRegistry";
            this.readRegistry.Size = new System.Drawing.Size(116, 23);
            this.readRegistry.TabIndex = 12;
            this.readRegistry.Text = "readRegistry";
            this.readRegistry.UseVisualStyleBackColor = true;
            this.readRegistry.Click += new System.EventHandler(this.readRegistry_Click);
            // 
            // fileNameListBox
            // 
            this.fileNameListBox.FormattingEnabled = true;
            this.fileNameListBox.ItemHeight = 16;
            this.fileNameListBox.Location = new System.Drawing.Point(385, 151);
            this.fileNameListBox.Name = "fileNameListBox";
            this.fileNameListBox.Size = new System.Drawing.Size(258, 68);
            this.fileNameListBox.TabIndex = 13;
            this.fileNameListBox.SelectedIndexChanged += new System.EventHandler(this.fileNameListBox_SelectedIndexChanged);
            this.fileNameListBox.DoubleClick += new System.EventHandler(this.fileNameListBox_DoubleClick);
            // 
            // printAsExcel
            // 
            this.printAsExcel.Location = new System.Drawing.Point(794, 312);
            this.printAsExcel.Name = "printAsExcel";
            this.printAsExcel.Size = new System.Drawing.Size(119, 23);
            this.printAsExcel.TabIndex = 14;
            this.printAsExcel.Text = "print to datagrid";
            this.printAsExcel.UseVisualStyleBackColor = true;
            this.printAsExcel.Click += new System.EventHandler(this.printToDataGrid_Click);
            // 
            // printToExcel
            // 
            this.printToExcel.Location = new System.Drawing.Point(805, 283);
            this.printToExcel.Name = "printToExcel";
            this.printToExcel.Size = new System.Drawing.Size(108, 23);
            this.printToExcel.TabIndex = 15;
            this.printToExcel.Text = "print to excel";
            this.printToExcel.UseVisualStyleBackColor = true;
            this.printToExcel.Click += new System.EventHandler(this.printToExcel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(758, 17);
            this.progressBar1.TabIndex = 16;
            // 
            // ProcessingLabel
            // 
            this.ProcessingLabel.AutoSize = true;
            this.ProcessingLabel.Location = new System.Drawing.Point(809, 338);
            this.ProcessingLabel.Name = "ProcessingLabel";
            this.ProcessingLabel.Size = new System.Drawing.Size(90, 17);
            this.ProcessingLabel.TabIndex = 17;
            this.ProcessingLabel.Text = "Processing...";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(791, 151);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(104, 43);
            this.test.TabIndex = 18;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 182);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // loadImage
            // 
            this.loadImage.Location = new System.Drawing.Point(742, 392);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(171, 23);
            this.loadImage.TabIndex = 20;
            this.loadImage.Text = "Load Image from Url";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.Location = new System.Drawing.Point(742, 448);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(168, 44);
            this.saveImage.TabIndex = 21;
            this.saveImage.Text = "Save Image";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // getImage
            // 
            this.getImage.Location = new System.Drawing.Point(732, 498);
            this.getImage.Name = "getImage";
            this.getImage.Size = new System.Drawing.Size(181, 33);
            this.getImage.TabIndex = 22;
            this.getImage.Text = "Get Image from Desktop";
            this.getImage.UseVisualStyleBackColor = true;
            this.getImage.Click += new System.EventHandler(this.getImage_Click);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.HeaderText = "text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // timeCurrentDataGridViewTextBoxColumn
            // 
            this.timeCurrentDataGridViewTextBoxColumn.DataPropertyName = "timeCurrent";
            this.timeCurrentDataGridViewTextBoxColumn.HeaderText = "timeCurrent";
            this.timeCurrentDataGridViewTextBoxColumn.Name = "timeCurrentDataGridViewTextBoxColumn";
            // 
            // photoUrlDataGridViewTextBoxColumn
            // 
            this.photoUrlDataGridViewTextBoxColumn.DataPropertyName = "photoUrl";
            this.photoUrlDataGridViewTextBoxColumn.HeaderText = "photoUrl";
            this.photoUrlDataGridViewTextBoxColumn.Name = "photoUrlDataGridViewTextBoxColumn";
            // 
            // posterIdDataGridViewTextBoxColumn
            // 
            this.posterIdDataGridViewTextBoxColumn.DataPropertyName = "posterId";
            this.posterIdDataGridViewTextBoxColumn.HeaderText = "posterId";
            this.posterIdDataGridViewTextBoxColumn.Name = "posterIdDataGridViewTextBoxColumn";
            // 
            // chatMessageBindingSource
            // 
            this.chatMessageBindingSource.DataSource = typeof(Firebase_Desktop_Application.ChatMessage);
            this.chatMessageBindingSource.CurrentChanged += new System.EventHandler(this.chatMessageBindingSource_CurrentChanged);
            // 
            // uploadToFirebase
            // 
            this.uploadToFirebase.Location = new System.Drawing.Point(739, 419);
            this.uploadToFirebase.Name = "uploadToFirebase";
            this.uploadToFirebase.Size = new System.Drawing.Size(171, 23);
            this.uploadToFirebase.TabIndex = 23;
            this.uploadToFirebase.Text = "Upload to firebase";
            this.uploadToFirebase.UseVisualStyleBackColor = true;
            this.uploadToFirebase.Click += new System.EventHandler(this.uploadToFirebase_Click);
            // 
            // FirebaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 578);
            this.Controls.Add(this.uploadToFirebase);
            this.Controls.Add(this.getImage);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.ProcessingLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.printToExcel);
            this.Controls.Add(this.printAsExcel);
            this.Controls.Add(this.fileNameListBox);
            this.Controls.Add(this.readRegistry);
            this.Controls.Add(this.registry);
            this.Controls.Add(this.ExcelLocation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.disposeListener);
            this.Controls.Add(this.nodeListener);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.outcomePush);
            this.Controls.Add(this.update);
            this.Controls.Add(this.push);
            this.Name = "FirebaseUi";
            this.Text = "Firebase Ui";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatMessageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox outcomePush;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button nodeListener;
        private System.Windows.Forms.Button disposeListener;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExcelLocation;
        private System.Windows.Forms.Button registry;
        private System.Windows.Forms.Button readRegistry;
        private System.Windows.Forms.ListBox fileNameListBox;
        private System.Windows.Forms.Button printAsExcel;
        private System.Windows.Forms.Button printToExcel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ProcessingLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCurrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chatMessageBindingSource;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button getImage;
        private System.Windows.Forms.Button uploadToFirebase;
    }
}

