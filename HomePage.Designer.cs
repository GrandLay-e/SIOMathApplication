namespace SIO_Math
{
    partial class HomePage
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
            conversions = new Button();
            arithmetique = new Button();
            SuspendLayout();
            // 
            // conversions
            // 
            conversions.Location = new Point(90, 106);
            conversions.Name = "conversions";
            conversions.Size = new Size(250, 261);
            conversions.TabIndex = 0;
            conversions.Text = "Conversions";
            conversions.UseVisualStyleBackColor = true;
            conversions.Click += conversions_Click;
            // 
            // arithmetique
            // 
            arithmetique.Location = new Point(434, 106);
            arithmetique.Name = "arithmetique";
            arithmetique.Size = new Size(250, 261);
            arithmetique.TabIndex = 1;
            arithmetique.Text = "Arithmetique";
            arithmetique.UseVisualStyleBackColor = true;
            arithmetique.Click += arithmetique_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(arithmetique);
            Controls.Add(conversions);
            Name = "HomePage";
            Size = new Size(772, 523);
            ResumeLayout(false);
        }

        #endregion

        private Button conversions;
        private Button arithmetique;
    }
}
