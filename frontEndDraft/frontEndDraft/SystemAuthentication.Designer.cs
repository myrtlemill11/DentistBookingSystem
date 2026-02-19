namespace frontEndDraft
{
    partial class SystemAuthentication
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
            this.authenticate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authenticate
            // 
            this.authenticate.Location = new System.Drawing.Point(433, 273);
            this.authenticate.Name = "authenticate";
            this.authenticate.Size = new System.Drawing.Size(192, 80);
            this.authenticate.TabIndex = 0;
            this.authenticate.Text = "Authentication";
            this.authenticate.UseVisualStyleBackColor = true;
            this.authenticate.Click += new System.EventHandler(this.authenticate_Click);
            // 
            // SystemAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 683);
            this.Controls.Add(this.authenticate);
            this.Name = "SystemAuthentication";
            this.Text = "SystemAuthentication";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authenticate;
    }
}