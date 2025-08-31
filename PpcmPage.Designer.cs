namespace SIO_Math
{
    partial class PpcmPage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            nb1 = new TextBox();
            nb2 = new TextBox();
            calculButton = new Button();
            ppcmResult = new Label();
            SuspendLayout();
            // 
            // nb1
            // 
            nb1.Location = new Point(149, 111);
            nb1.Name = "nb1";
            nb1.Size = new Size(125, 27);
            nb1.TabIndex = 0;
            // 
            // nb2
            // 
            nb2.Location = new Point(471, 111);
            nb2.Name = "nb2";
            nb2.Size = new Size(125, 27);
            nb2.TabIndex = 1;
            // 
            // calculButton
            // 
            calculButton.Location = new Point(322, 225);
            calculButton.Name = "calculButton";
            calculButton.Size = new Size(94, 29);
            calculButton.TabIndex = 2;
            calculButton.Text = "PPCM";
            calculButton.UseVisualStyleBackColor = true;
            calculButton.Click += calculButton_Click;
            // 
            // ppcmResult
            // 
            ppcmResult.AutoSize = true;
            ppcmResult.Location = new Point(346, 350);
            ppcmResult.Name = "ppcmResult";
            ppcmResult.Size = new Size(39, 20);
            ppcmResult.TabIndex = 3;
            ppcmResult.Text = "_____";
            // 
            // PpcmPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ppcmResult);
            Controls.Add(calculButton);
            Controls.Add(nb2);
            Controls.Add(nb1);
            Name = "PpcmPage";
            Size = new Size(810, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nb1;
        private TextBox nb2;
        private Button calculButton;
        private Label ppcmResult;
    }
}
