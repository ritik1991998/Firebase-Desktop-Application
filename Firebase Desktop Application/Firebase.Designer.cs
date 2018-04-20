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
            this.update.Location = new System.Drawing.Point(381, 81);
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
            // 
            // FirebaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

