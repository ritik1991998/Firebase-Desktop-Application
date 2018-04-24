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
            this.testTime = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // push
            // 
            this.push.Location = new System.Drawing.Point(30, 81);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 23);
            this.push.TabIndex = 0;
            this.push.Text = "push";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(186, 81);
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
            this.delete.Location = new System.Drawing.Point(381, 81);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // nodeListener
            // 
            this.nodeListener.Location = new System.Drawing.Point(527, 81);
            this.nodeListener.Name = "nodeListener";
            this.nodeListener.Size = new System.Drawing.Size(75, 23);
            this.nodeListener.TabIndex = 4;
            this.nodeListener.Text = "listener";
            this.nodeListener.UseVisualStyleBackColor = true;
            this.nodeListener.Click += new System.EventHandler(this.nodeListener_Click);
            // 
            // testTime
            // 
            this.testTime.Location = new System.Drawing.Point(681, 81);
            this.testTime.Name = "testTime";
            this.testTime.Size = new System.Drawing.Size(75, 23);
            this.testTime.TabIndex = 5;
            this.testTime.Text = "testTime";
            this.testTime.UseVisualStyleBackColor = true;
            this.testTime.Click += new System.EventHandler(this.testTime_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameBox.Location = new System.Drawing.Point(369, 169);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(120, 26);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "Name";
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageBox.Location = new System.Drawing.Point(12, 166);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(212, 26);
            this.messageBox.TabIndex = 7;
            this.messageBox.Text = "Message";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(540, 166);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(104, 29);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // FirebaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.testTime);
            this.Controls.Add(this.nodeListener);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.outcomePush);
            this.Controls.Add(this.update);
            this.Controls.Add(this.push);
            this.Name = "FirebaseUi";
            this.Text = "Firebase Ui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox outcomePush;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button nodeListener;
        private System.Windows.Forms.Button testTime;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button submit;
    }
}

