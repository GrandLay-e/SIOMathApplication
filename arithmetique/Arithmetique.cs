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
    public partial class Arithmetique : UserControl
    {
        public event Action<string> ClickedOperation;
        public Arithmetique()
        {
            InitializeComponent();
        }

        private void Arithmetique_Load(object sender, EventArgs e)
        {

        }

        private void pgcd_Click(object sender, EventArgs e)
        {
            ClickedOperation?.Invoke("pgcd");
        }

        private void ppcm_Click(object sender, EventArgs e)
        {
            ClickedOperation?.Invoke("ppcm");
        }

        private void congruence_Click(object sender, EventArgs e)
        {
            ClickedOperation?.Invoke("congruence");

        }
    }
}
