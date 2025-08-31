namespace SIO_Math
{
    partial class ConversionPage
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
            BaseDepart = new ComboBox();
            from = new Label();
            to = new Label();
            baseDestination = new ComboBox();
            ResultShow = new Label();
            result = new Label();
            number = new Label();
            numberToConvert = new TextBox();
            conversionButton = new Button();
            SuspendLayout();
            // 
            // BaseDepart
            // 
            BaseDepart.FormattingEnabled = true;
            BaseDepart.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            BaseDepart.Location = new Point(53, 119);
            BaseDepart.Name = "BaseDepart";
            BaseDepart.Size = new Size(221, 28);
            BaseDepart.TabIndex = 0;
            BaseDepart.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // from
            // 
            from.AutoSize = true;
            from.Location = new Point(138, 82);
            from.Name = "from";
            from.Size = new Size(43, 20);
            from.TabIndex = 1;
            from.Text = "From";
            // 
            // to
            // 
            to.AutoSize = true;
            to.Location = new Point(526, 83);
            to.Name = "to";
            to.Size = new Size(25, 20);
            to.TabIndex = 2;
            to.Text = "To";
            // 
            // baseDestination
            // 
            baseDestination.FormattingEnabled = true;
            baseDestination.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            baseDestination.Location = new Point(432, 119);
            baseDestination.Name = "baseDestination";
            baseDestination.Size = new Size(221, 28);
            baseDestination.TabIndex = 3;
            // 
            // ResultShow
            // 
            ResultShow.AutoSize = true;
            ResultShow.Location = new Point(329, 349);
            ResultShow.Name = "ResultShow";
            ResultShow.Size = new Size(49, 20);
            ResultShow.TabIndex = 4;
            ResultShow.Text = "Result";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(329, 391);
            result.Name = "result";
            result.Size = new Size(45, 20);
            result.TabIndex = 5;
            result.Text = "______";
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(329, 199);
            number.Name = "number";
            number.Size = new Size(63, 20);
            number.TabIndex = 6;
            number.Text = "Number";
            // 
            // numberToConvert
            // 
            numberToConvert.Location = new Point(298, 234);
            numberToConvert.Name = "numberToConvert";
            numberToConvert.Size = new Size(125, 27);
            numberToConvert.TabIndex = 7;
            // 
            // conversionButton
            // 
            conversionButton.Location = new Point(312, 294);
            conversionButton.Name = "conversionButton";
            conversionButton.Size = new Size(94, 29);
            conversionButton.TabIndex = 8;
            conversionButton.Text = "Convert";
            conversionButton.UseVisualStyleBackColor = true;
            conversionButton.Click += conversionButton_Click;
            // 
            // ConversionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(conversionButton);
            Controls.Add(numberToConvert);
            Controls.Add(number);
            Controls.Add(result);
            Controls.Add(ResultShow);
            Controls.Add(baseDestination);
            Controls.Add(to);
            Controls.Add(from);
            Controls.Add(BaseDepart);
            Name = "ConversionPage";
            Size = new Size(780, 515);
            Load += ConversionPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BaseDepart;
        private Label from;
        private Label to;
        private ComboBox baseDestination;
        private Label ResultShow;
        private Label result;
        private Label number;
        private TextBox numberToConvert;
        private Button conversionButton;
    }
}
