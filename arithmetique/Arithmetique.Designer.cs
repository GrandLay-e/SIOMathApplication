namespace SIO_Math
{
    partial class Arithmetique
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
            pgcd = new Button();
            ppcm = new Button();
            congruence = new Button();
            SuspendLayout();
            // 
            // pgcd
            // 
            pgcd.Location = new Point(44, 93);
            pgcd.Name = "pgcd";
            pgcd.Size = new Size(195, 108);
            pgcd.TabIndex = 0;
            pgcd.Text = "P G C D";
            pgcd.UseVisualStyleBackColor = true;
            pgcd.Click += pgcd_Click;
            // 
            // ppcm
            // 
            ppcm.Location = new Point(518, 93);
            ppcm.Name = "ppcm";
            ppcm.Size = new Size(195, 108);
            ppcm.TabIndex = 1;
            ppcm.Text = "P P C M";
            ppcm.UseVisualStyleBackColor = true;
            ppcm.Click += ppcm_Click;
            // 
            // congruence
            // 
            congruence.Location = new Point(280, 316);
            congruence.Name = "congruence";
            congruence.Size = new Size(195, 108);
            congruence.TabIndex = 2;
            congruence.Text = "CONGRUENCE";
            congruence.UseVisualStyleBackColor = true;
            congruence.Click += congruence_Click;
            // 
            // Arithmetique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(congruence);
            Controls.Add(ppcm);
            Controls.Add(pgcd);
            Name = "Arithmetique";
            Size = new Size(779, 528);
            Load += Arithmetique_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button pgcd;
        private Button ppcm;
        private Button congruence;
    }
}
