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
            nb1Text = new Label();
            nb2Text = new Label();
            moduloText = new Label();
            label1 = new Label();
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
            resultCongruence.Location = new Point(246, 444);
            resultCongruence.Name = "resultCongruence";
            resultCongruence.Size = new Size(0, 20);
            resultCongruence.TabIndex = 4;
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
            // nb1Text
            // 
            nb1Text.AutoSize = true;
            nb1Text.Location = new Point(167, 100);
            nb1Text.Name = "nb1Text";
            nb1Text.Size = new Size(78, 20);
            nb1Text.TabIndex = 6;
            nb1Text.Text = "Nombre A";
            // 
            // nb2Text
            // 
            nb2Text.AutoSize = true;
            nb2Text.Location = new Point(396, 100);
            nb2Text.Name = "nb2Text";
            nb2Text.Size = new Size(77, 20);
            nb2Text.TabIndex = 7;
            nb2Text.Text = "Nombre B";
            // 
            // moduloText
            // 
            moduloText.AutoSize = true;
            moduloText.Location = new Point(654, 100);
            moduloText.Name = "moduloText";
            moduloText.Size = new Size(61, 20);
            moduloText.TabIndex = 8;
            moduloText.Text = "Modulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 444);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "Result : ";
            // 
            // CongruencePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(moduloText);
            Controls.Add(nb2Text);
            Controls.Add(nb1Text);
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
        private Label nb1Text;
        private Label nb2Text;
        private Label moduloText;
        private Label label1;
    }
}
