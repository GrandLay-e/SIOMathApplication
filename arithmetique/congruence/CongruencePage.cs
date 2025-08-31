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
        private string selectedItem;
        private Point initialNb1Location;
        private Point initialNb2Location;
        private Point initialModuloLocation;
        public CongruencePage()
        {
            InitializeComponent();
            selectedItem = congruence.Text;
            initialNb1Location = nb1.Location;
            initialNb2Location = nb2.Location;
            initialModuloLocation = modulo.Location;

        }

        private void calculCongruence_Click(object sender, EventArgs e)
        {
            long _nb1, _nb2, _modulo, _result;
            string result;
            List<long> listCongruences = new List<long>();

            bool isNb1Convertible, isNb2Convertible, isModuloConvertible;
            isNb1Convertible = long.TryParse(nb1.Text, out _nb1);
            isNb2Convertible = long.TryParse(nb2.Text, out _nb2);
            isModuloConvertible = long.TryParse(modulo.Text, out _modulo);

            if (isNb1Convertible && isNb2Convertible)
            {
                if (selectedItem == congruence.Text)
                {
                    if (isModuloConvertible)
                    {
                        _result = MathFunctions.Congruence(_nb1, _nb2, _modulo);
                        if (_result == 0)
                            result = $"{_nb1} ≡ {_nb2} [{_modulo}]";
                        else
                            result = $"{_nb1} n'est pas congru à {_nb2} [{_modulo}]";
                    }
                    else
                        result = "Vérifiez votre saisie ! ";

                }
                else //if (selectedItem == congruList.Text)
                {
                    listCongruences = MathFunctions.FindCongruences(_nb1, _nb2);
                    result = string.Join(", ", listCongruences.Select(elt => elt.ToString()));
                }
            }
            else
                result = "Vérifiez votre saisie ! ";

            resultCongruence.Text = result;
        }

        private void congurence_Click(object sender, EventArgs e)
        {
            selectedItem = congruence.Text;
            nb1.Location = initialNb1Location;
            nb2.Location = initialNb2Location;
            modulo.Location = initialModuloLocation;
            modulo.Show();
        }

        private void congruList_Click(object sender, EventArgs e)
        {
            selectedItem = congruList.Text;
            nb2.Location = initialModuloLocation;
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
