using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace SIO_Math
{
    public partial class ConversionPage : UserControl
    {
        public ConversionPage()
        {
            InitializeComponent();

        }

        private void ConversionPage_Load(object sender, EventArgs e)
        {}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private string ConvertNumber(string baseDepart, string baseDestination, string number)
        {
            string result;
            int _number = Convert.ToInt32(number);
            switch (baseDepart)
            {
                case "Decimal":
                    switch (baseDestination)
                    {
                        case "Binary":
                            result = MathFunctions.ConvertDecimalToBinary(_number);
                            break;
                        case "Hexadecimal":
                            result = MathFunctions.ConvertDecimalToHexadecimal(_number);
                            break;
                        default:
                            result = number;
                            break;
                    }
                    break;

                case "Binary":
                    switch (baseDestination)
                    {
                        case "Decimal":
                            result = MathFunctions.ConvertBinaryToDecimal(_number);
                            break;
                        case "Hexadecimal":
                            result = MathFunctions.ConvertBinaryToHexadecimal(_number);
                            break;
                        default:
                            result = number;
                            break;
                    }
                    break;

                case "Hexadecimal":
                    switch (baseDestination)
                    {
                        case "Decimal":
                            result = MathFunctions.ConvertHexadecimalToDecimal(number);
                            break;
                        case "Hexadecimal":
                            result = MathFunctions.ConvertHexadecimalToDecimal(number);
                            break;
                        default:
                            result = number;
                            break;
                    }
                    break;
                default:
                    throw new ArgumentException("Base de départ non prise en charge.");
            }

            return result;
        }
        
        
        private void conversionButton_Click(object sender, EventArgs e)
        {
            string showedText;
            if (BaseDepart.Text == "" || baseDestination.Text == "" || numberToConvert.Text == "")
                showedText = "Assurez-vous d'avoir bien fait vos saisies";
            else
                showedText = ConvertNumber( BaseDepart.Text, baseDestination.Text, numberToConvert.Text);

            result.Text = showedText;
                 
        }
    }
}
