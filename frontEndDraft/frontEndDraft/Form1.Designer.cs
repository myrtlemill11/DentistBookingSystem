namespace frontEndDraft
{
    partial class Form1
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
            this.patient = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patient
            // 
            this.patient.Location = new System.Drawing.Point(482, 194);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(172, 111);
            this.patient.TabIndex = 0;
            this.patient.Text = "Patient";
            this.patient.UseVisualStyleBackColor = true;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(482, 345);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(172, 111);
            this.staff.TabIndex = 1;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 721);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.patient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Button staff;
    }
}

