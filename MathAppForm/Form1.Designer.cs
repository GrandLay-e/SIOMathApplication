namespace SIO_Math
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
            pannelContainer = new Panel();
            home = new Button();
            SuspendLayout();
            // 
            // pannelContainer
            // 
            pannelContainer.Location = new Point(12, 47);
            pannelContainer.Name = "pannelContainer";
            pannelContainer.Size = new Size(940, 543);
            pannelContainer.TabIndex = 0;
            // 
            // home
            // 
            home.BackColor = Color.DarkGreen;
            home.BackgroundImageLayout = ImageLayout.Center;
            home.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            home.ForeColor = SystemColors.ButtonFace;
            home.Location = new Point(12, 12);
            home.Name = "home";
            home.Size = new Size(94, 29);
            home.TabIndex = 10;
            home.Text = "\U0001f6d6 Home";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 602);
            Controls.Add(home);
            Controls.Add(pannelContainer);
            Name = "Form1";
            Text = "Mathématique BTS SIO";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pannelContainer;
        private Button home;
    }
}
