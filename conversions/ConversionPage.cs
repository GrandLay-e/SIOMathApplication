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
        { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private string ConvertNumber(string baseDepart, string baseDestination, string number)
        {
            string result = "";
            long _number = 0;
            bool isInputNumberDecimal, isInputNumberBinary, isInputNumberHexadecimal;
            isInputNumberDecimal = number.isDecimal();
            isInputNumberBinary = number.isBinary();
            isInputNumberHexadecimal = number.isHexadecimal();

            if (isInputNumberDecimal)
                long.TryParse(number, out _number);

            switch (baseDepart)
            {
                case "Decimal":
                    if (!isInputNumberDecimal)
                    {
                        MessageBox.Show("Invalide Decimal Input ! ");
                        break;
                    }
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
                    if (!isInputNumberBinary)
                    {
                        MessageBox.Show("Invalid Binary Input ! ");
                        break;
                    }
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
                    if (!isInputNumberHexadecimal){
                        MessageBox.Show("Invalid Hexadecimal Input ! ");
                        break;
                    }
                    switch (baseDestination)
                    {
                        case "Decimal":
                            result = MathFunctions.ConvertHexadecimalToDecimal(number);
                            break;
                        case "Binary":
                            result = MathFunctions.ConvertHexadecimalToBinary(number);
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
            string showedText = "";
            if (BaseDepart.Text == "" || baseDestination.Text == "" || numberToConvert.Text == "")
                MessageBox.Show("Vérifiez votre saisie ! ");
            else
                showedText = ConvertNumber(BaseDepart.Text, baseDestination.Text, numberToConvert.Text);

            result.Text = showedText;

        }

    }
}
