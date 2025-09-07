using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIO_Math
{
    public partial class CongruencePage : UserControl
    {
        // to choose between simple congruence or list of congruences modulos
        private string selectedItem;
        
        //private Point initialNb1Location;
        private Point initialNb2Location;
        private Point initialModuloLocation;
        private Point initialNb2TextLocation;
        private Point initialModuloTextLocation;

        
        public CongruencePage()
        {
            InitializeComponent();
            selectedItem = congruence.Text;

            initialNb2Location = nb2.Location;
            initialNb2TextLocation = nb2Text.Location;
            
            initialModuloLocation = modulo.Location;
            initialModuloTextLocation = moduloText.Location;

        }

        private void calculCongruence_Click(object sender, EventArgs e)
        {
            long _nb1, _nb2, _modulo;
            string _result, operations = "", resultText = "";

            bool isNb1Convertible, isNb2Convertible, isModuloConvertible;
            isNb1Convertible = nb1.Text.isDecimal();
            isNb2Convertible = nb2.Text.isDecimal();
            isModuloConvertible = modulo.Text.isDecimal();

            if (isNb1Convertible && isNb2Convertible)
            {
                _nb1 = long.Parse(nb1.Text);
                _nb2 = long.Parse(nb2.Text);
                if (selectedItem == congruence.Text)
                {
                    if (isModuloConvertible)
                    {
                        _modulo = long.Parse(modulo.Text);
                        _result = MathFunctions.Congruence(_nb1, _nb2, _modulo).ConvertListToStringToDisplayOperations("", 1);
                        operations = MathFunctions.Congruence(_nb1, _nb2, _modulo).ConvertListToStringToDisplayOperations();
                        if (_result == "0")
                            resultText = $"{_nb1} ≡ {_nb2} [{_modulo}]";
                        else
                            resultText = $"{_nb1} n'est pas congru à {_nb2} [{_modulo}]";
                    }
                    else
                        MessageBox.Show(" ! ");

                }
                else //if (selectedItem == congruList.Text)
                {
                    operations = MathFunctions.FindCongruences(_nb1, _nb2).ConvertListToStringToDisplayOperations();
                    resultText = MathFunctions.FindCongruences(_nb1, _nb2).ConvertListToStringToDisplayOperations(",", 1);
                }
            }
            else
                //result = "Vérifiez votre saisie ! ";
                MessageBox.Show("Vérifiez votre saisie ! ");

            resultCongruence.Text = resultText;
            congruencesOperations.Text = operations;
        }

        private void congurence_Click(object sender, EventArgs e)
        {
            selectedItem = congruence.Text;
            
            nb2.Location = initialNb2Location;
            nb2Text.Location = initialNb2TextLocation;
            
            moduloText.Show();
            modulo.Show();
        }

        private void congruList_Click(object sender, EventArgs e)
        {
            selectedItem = congruList.Text;
            
            nb2.Location = initialModuloLocation;
            nb2Text.Location = initialModuloTextLocation;
            
            moduloText.Hide();
            modulo.Hide();
        }

        private void menuCongruence_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var clickedItem =  sender  as ToolStripMenuItem;
            if (clickedItem != null)
            {
                string selectedText = clickedItem.Text;
            }
        }
    }
}
