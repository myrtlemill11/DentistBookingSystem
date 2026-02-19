namespace frontEndDraft
{
    partial class PatientEntry
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
            this.newPatient = new System.Windows.Forms.Button();
            this.returningPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPatient
            // 
            this.newPatient.Location = new System.Drawing.Point(537, 198);
            this.newPatient.Name = "newPatient";
            this.newPatient.Size = new System.Drawing.Size(193, 99);
            this.newPatient.TabIndex = 0;
            this.newPatient.Text = "New Patient";
            this.newPatient.UseVisualStyleBackColor = true;
            // 
            // returningPatient
            // 
            this.returningPatient.Location = new System.Drawing.Point(537, 337);
            this.returningPatient.Name = "returningPatient";
            this.returningPatient.Size = new System.Drawing.Size(193, 93);
            this.returningPatient.TabIndex = 1;
            this.returningPatient.Text = "Returning Patient";
            this.returningPatient.UseVisualStyleBackColor = true;
            this.returningPatient.Click += new System.EventHandler(this.returningPatient_Click_1);
            // 
            // PatientEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 756);
            this.Controls.Add(this.returningPatient);
            this.Controls.Add(this.newPatient);
            this.Name = "PatientEntry";
            this.Text = "PatientEntry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newPatient;
        private System.Windows.Forms.Button returningPatient;
    }
}