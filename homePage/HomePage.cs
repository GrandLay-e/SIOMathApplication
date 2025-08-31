using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIO_Math
{
    public partial class HomePage : UserControl
    {
        public event Action<string> ButtonClicked;
        private ConversionPage conversion;
        public HomePage()
        {
            conversion = new ConversionPage();
            InitializeComponent();
        }
        private void conversions_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke("conversion");
        }

        private void arithmetique_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke("arithmetique");
        }
    }
}
