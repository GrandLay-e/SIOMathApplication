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
            SuspendLayout();
            // 
            // pannelContainer
            // 
            pannelContainer.Location = new Point(-2, 0);
            pannelContainer.Name = "pannelContainer";
            pannelContainer.Size = new Size(802, 450);
            pannelContainer.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pannelContainer);
            Name = "Form1";
            Text = "Mathématique BTS SIO";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pannelContainer;
    }
}
