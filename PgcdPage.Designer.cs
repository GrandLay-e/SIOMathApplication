namespace SIO_Math
{
    partial class PgcdPage
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
            nb1Pgcd = new TextBox();
            nb2Pgcd = new TextBox();
            calculPgcd = new Button();
            resultPgcd = new Label();
            SuspendLayout();
            // 
            // nb1Pgcd
            // 
            nb1Pgcd.Location = new Point(174, 117);
            nb1Pgcd.Name = "nb1Pgcd";
            nb1Pgcd.Size = new Size(125, 27);
            nb1Pgcd.TabIndex = 0;
            // 
            // nb2Pgcd
            // 
            nb2Pgcd.Location = new Point(485, 121);
            nb2Pgcd.Name = "nb2Pgcd";
            nb2Pgcd.Size = new Size(125, 27);
            nb2Pgcd.TabIndex = 1;
            // 
            // calculPgcd
            // 
            calculPgcd.Location = new Point(350, 197);
            calculPgcd.Name = "calculPgcd";
            calculPgcd.Size = new Size(94, 29);
            calculPgcd.TabIndex = 2;
            calculPgcd.Text = "Calculer";
            calculPgcd.UseVisualStyleBackColor = true;
            calculPgcd.Click += calculPgcd_Click;
            // 
            // resultPgcd
            // 
            resultPgcd.AutoSize = true;
            resultPgcd.Location = new Point(366, 318);
            resultPgcd.Name = "resultPgcd";
            resultPgcd.Size = new Size(57, 20);
            resultPgcd.TabIndex = 3;
            resultPgcd.Text = "________";
            // 
            // PgcdPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultPgcd);
            Controls.Add(calculPgcd);
            Controls.Add(nb2Pgcd);
            Controls.Add(nb1Pgcd);
            Name = "PgcdPage";
            Size = new Size(857, 523);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nb1Pgcd;
        private TextBox nb2Pgcd;
        private Button calculPgcd;
        private Label resultPgcd;
    }
}
