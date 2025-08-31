namespace SIO_Math
{
    partial class CongruencePage
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
            modulo = new TextBox();
            calculCongruence = new Button();
            resultCongruence = new Label();
            menuCongruence = new MenuStrip();
            congruence = new ToolStripMenuItem();
            congruList = new ToolStripMenuItem();
            menuCongruence.SuspendLayout();
            SuspendLayout();
            // 
            // nb1
            // 
            nb1.Location = new Point(142, 152);
            nb1.Name = "nb1";
            nb1.Size = new Size(125, 27);
            nb1.TabIndex = 0;
            // 
            // nb2
            // 
            nb2.Location = new Point(378, 152);
            nb2.Name = "nb2";
            nb2.Size = new Size(125, 27);
            nb2.TabIndex = 1;
            // 
            // modulo
            // 
            modulo.Location = new Point(620, 152);
            modulo.Name = "modulo";
            modulo.Size = new Size(125, 27);
            modulo.TabIndex = 2;
            // 
            // calculCongruence
            // 
            calculCongruence.Location = new Point(396, 272);
            calculCongruence.Name = "calculCongruence";
            calculCongruence.Size = new Size(94, 29);
            calculCongruence.TabIndex = 3;
            calculCongruence.Text = "Calculer";
            calculCongruence.UseVisualStyleBackColor = true;
            calculCongruence.Click += calculCongruence_Click;
            // 
            // resultCongruence
            // 
            resultCongruence.AutoSize = true;
            resultCongruence.Location = new Point(422, 383);
            resultCongruence.Name = "resultCongruence";
            resultCongruence.Size = new Size(39, 20);
            resultCongruence.TabIndex = 4;
            resultCongruence.Text = "_____";
            // 
            // menuCongruence
            // 
            menuCongruence.ImageScalingSize = new Size(20, 20);
            menuCongruence.Items.AddRange(new ToolStripItem[] { congruence, congruList });
            menuCongruence.Location = new Point(0, 0);
            menuCongruence.Name = "menuCongruence";
            menuCongruence.RenderMode = ToolStripRenderMode.Professional;
            menuCongruence.Size = new Size(866, 28);
            menuCongruence.TabIndex = 5;
            menuCongruence.Text = "menuCongruence";
            menuCongruence.ItemClicked += menuCongruence_ItemClicked;
            // 
            // congruence
            // 
            congruence.Name = "congruence";
            congruence.Size = new Size(146, 24);
            congruence.Text = "Calcul Congruence";
            congruence.Click += congurence_Click;
            // 
            // congruList
            // 
            congruList.Name = "congruList";
            congruList.Size = new Size(192, 24);
            congruList.Text = "Liste de modulos congrus";
            congruList.Click += congruList_Click;
            // 
            // CongruencePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultCongruence);
            Controls.Add(calculCongruence);
            Controls.Add(modulo);
            Controls.Add(nb2);
            Controls.Add(nb1);
            Controls.Add(menuCongruence);
            Name = "CongruencePage";
            Size = new Size(866, 599);
            menuCongruence.ResumeLayout(false);
            menuCongruence.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nb1;
        private TextBox nb2;
        private TextBox modulo;
        private Button calculCongruence;
        private Label resultCongruence;
        private MenuStrip menuCongruence;
        private ToolStripMenuItem congruence;
        private ToolStripMenuItem congruList;
    }
}
