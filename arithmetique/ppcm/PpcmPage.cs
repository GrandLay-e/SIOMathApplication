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
    public partial class PpcmPage : UserControl
    {
        public PpcmPage()
        {
            InitializeComponent();
        }

        private void calculButton_Click(object sender, EventArgs e)
        {
            long _nb1;
            long _nb2;
            
            bool isNb1Convertible = long.TryParse(nb1.Text, out _nb1);
            bool isNb2Convertible = long.TryParse(nb2.Text, out _nb2);

            if (isNb1Convertible && isNb2Convertible)
                ppcmResult.Text = MathFunctions.Ppcm(_nb1, _nb2).ToString();
            else
                ppcmResult.Text = "Vérifiez votre saisie";
        }
    }
}
