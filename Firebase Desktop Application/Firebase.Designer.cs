namespace Firebase_Desktop_Application
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.nodeListener.Location = new System.Drawing.Point(527, 57);
            this.nodeListener.Name = "nodeListener";
            this.nodeListener.Size = new System.Drawing.Size(75, 23);
            this.nodeListener.TabIndex = 4;
            this.nodeListener.Text = "listener";
            this.nodeListener.UseVisualStyleBackColor = true;
            this.nodeListener.Click += new System.EventHandler(this.nodeListener_Click);
            // 
            // disposeListener
            // 
            this.disposeListener.Location = new System.Drawing.Point(672, 57);
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
            this.nameBox.Location = new System.Drawing.Point(248, 119);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(120, 26);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "Name";
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageBox.Location = new System.Drawing.Point(46, 119);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(196, 26);
            this.messageBox.TabIndex = 7;
            this.messageBox.Text = "Message";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(385, 119);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(104, 29);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 248);
            this.dataGridView1.TabIndex = 9;
            // 
            // ExcelLocation
            // 
            this.ExcelLocation.Location = new System.Drawing.Point(684, 122);
            this.ExcelLocation.Name = "ExcelLocation";
            this.ExcelLocation.Size = new System.Drawing.Size(104, 62);
            this.ExcelLocation.TabIndex = 10;
            this.ExcelLocation.Text = "Open";
            this.ExcelLocation.UseVisualStyleBackColor = true;
            this.ExcelLocation.Click += new System.EventHandler(this.ExcelLocation_Click);
            // 
            // registry
            // 
            this.registry.Location = new System.Drawing.Point(527, 125);
            this.registry.Name = "registry";
            this.registry.Size = new System.Drawing.Size(116, 23);
            this.registry.TabIndex = 11;
            this.registry.Text = "write registry";
            this.registry.UseVisualStyleBackColor = true;
            this.registry.Click += new System.EventHandler(this.registry_Click);
            // 
            // readRegistry
            // 
            this.readRegistry.Location = new System.Drawing.Point(527, 154);
            this.readRegistry.Name = "readRegistry";
            this.readRegistry.Size = new System.Drawing.Size(116, 23);
            this.readRegistry.TabIndex = 12;
            this.readRegistry.Text = "readRegistry";
            this.readRegistry.UseVisualStyleBackColor = true;
            this.readRegistry.Click += new System.EventHandler(this.readRegistry_Click);
            // 
            // FirebaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

