namespace frontendDental_clinic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IsDoctor = new Button();
            IsPatient = new Button();
            SuspendLayout();
            // 
            // IsDoctor
            // 
            IsDoctor.Location = new Point(316, 116);
            IsDoctor.Name = "IsDoctor";
            IsDoctor.Size = new Size(122, 62);
            IsDoctor.TabIndex = 0;
            IsDoctor.Text = "Dentist";
            IsDoctor.UseVisualStyleBackColor = true;
            IsDoctor.Click += button1_Click;
            // 
            // IsPatient
            // 
            IsPatient.Location = new Point(316, 251);
            IsPatient.Name = "IsPatient";
            IsPatient.Size = new Size(122, 75);
            IsPatient.TabIndex = 1;
            IsPatient.Text = "Patient";
            IsPatient.UseVisualStyleBackColor = true;
            IsPatient.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IsPatient);
            Controls.Add(IsDoctor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button IsDoctor;
        private Button IsPatient;
    }
}
