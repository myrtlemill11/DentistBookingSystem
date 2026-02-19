namespace frontEndDraft
{
    partial class PatientLogin
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
            this.ID_number = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.insertPassword = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ID_number
            // 
            this.ID_number.Location = new System.Drawing.Point(446, 187);
            this.ID_number.Name = "ID_number";
            this.ID_number.Size = new System.Drawing.Size(242, 31);
            this.ID_number.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(203, 187);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(224, 25);
            this.ID.TabIndex = 1;
            this.ID.Text = "Insert ID number here:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(203, 257);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 25);
            this.password.TabIndex = 2;
            this.password.Text = "Insert password here:";
            // 
            // insertPassword
            // 
            this.insertPassword.Location = new System.Drawing.Point(446, 254);
            this.insertPassword.Name = "insertPassword";
            this.insertPassword.Size = new System.Drawing.Size(242, 31);
            this.insertPassword.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(492, 331);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(153, 53);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // feedback
            // 
            this.feedback.Location = new System.Drawing.Point(446, 427);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(242, 131);
            this.feedback.TabIndex = 5;
            this.feedback.Text = "";
            // 
            // PatientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 736);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.insertPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ID_number);
            this.Name = "PatientLogin";
            this.Text = "PatientLogin";
            this.Load += new System.EventHandler(this.PatientLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_number;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox insertPassword;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox feedback;
    }
}