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
            long _nb1, _nb2;
            bool isNb1Convertible, isNb2Convertible;

            isNb1Convertible = nb1.Text.isDecimal();
            isNb2Convertible = nb2.Text.isDecimal();

            if (isNb1Convertible && isNb2Convertible)
            {
                _nb1 = long.Parse(nb1.Text);
                _nb2 = long.Parse(nb2.Text);
                ppcmOperations.Text = MathFunctions.Ppcm(_nb1, _nb2).ConvertListToStringToDisplayOperations();
                ppcmResult.Text = MathFunctions.Ppcm(_nb1, _nb2).ConvertListToStringToDisplayOperations("", 1);
            }
            else
                MessageBox.Show("Invalid input number !");
        }
    }
}
