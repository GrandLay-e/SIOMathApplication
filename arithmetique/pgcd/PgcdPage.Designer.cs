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
            resultText = new Label();
            nb2Text = new Label();
            nb1Text = new Label();
            pgcdOperation = new Label();
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
            resultPgcd.Location = new Point(272, 378);
            resultPgcd.Name = "resultPgcd";
            resultPgcd.Size = new Size(0, 20);
            resultPgcd.TabIndex = 3;
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Location = new Point(196, 378);
            resultText.Name = "resultText";
            resultText.Size = new Size(60, 20);
            resultText.TabIndex = 9;
            resultText.Text = "Result : ";
            // 
            // nb2Text
            // 
            nb2Text.AutoSize = true;
            nb2Text.Location = new Point(505, 83);
            nb2Text.Name = "nb2Text";
            nb2Text.Size = new Size(77, 20);
            nb2Text.TabIndex = 8;
            nb2Text.Text = "Nombre B";
            // 
            // nb1Text
            // 
            nb1Text.AutoSize = true;
            nb1Text.Location = new Point(196, 83);
            nb1Text.Name = "nb1Text";
            nb1Text.Size = new Size(78, 20);
            nb1Text.TabIndex = 7;
            nb1Text.Text = "Nombre A";
            // 
            // pgcdOperation
            // 
            pgcdOperation.AutoSize = true;
            pgcdOperation.Location = new Point(197, 418);
            pgcdOperation.Name = "pgcdOperation";
            pgcdOperation.Size = new Size(0, 20);
            pgcdOperation.TabIndex = 10;
            // 
            // PgcdPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pgcdOperation);
            Controls.Add(resultText);
            Controls.Add(nb2Text);
            Controls.Add(nb1Text);
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
        private Label resultText;
        private Label nb2Text;
        private Label nb1Text;
        private Label pgcdOperation;
    }
}
