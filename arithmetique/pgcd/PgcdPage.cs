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
    public partial class PgcdPage : UserControl
    {
        public PgcdPage()
        {
            InitializeComponent();
        }

        private void calculPgcd_Click(object sender, EventArgs e)
        {
            string result;
            long nb1, nb2;
            if (!long.TryParse(nb1Pgcd.Text, out nb1) || !long.TryParse(nb2Pgcd.Text, out nb2))
                result = "Saise incorrect !";
            else result = MathFunctions.Pgcd(long.Parse(nb1Pgcd.Text), long.Parse(nb2Pgcd.Text)).ToString();

            resultPgcd.Text = result;
        }
    }
}
