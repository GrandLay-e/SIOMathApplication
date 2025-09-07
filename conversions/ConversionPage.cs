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

        private List<string> ConvertNumber(string baseDepart, string baseDestination, string number)
        {
            string result = "", operations = "";
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
                            operations = MathFunctions.ConvertDecimalToBinary(_number).ConvertListToStringToDisplayOperations();
                            result = MathFunctions.ConvertDecimalToBinary(_number).ConvertListToStringToDisplayOperations("", 1);
                            break;
                        case "Hexadecimal":
                            operations = MathFunctions.ConvertDecimalToHexadecimal(_number).ConvertListToStringToDisplayOperations();
                            result = MathFunctions.ConvertDecimalToHexadecimal(_number).ConvertListToStringToDisplayOperations("", 1);
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
                            operations = MathFunctions.ConvertBinaryToDecimal(_number).ConvertListToStringToDisplayOperations();
                            result = MathFunctions.ConvertBinaryToDecimal(_number).ConvertListToStringToDisplayOperations("",1);
                            break;
                        case "Hexadecimal":
                            result = MathFunctions.ConvertBinaryToHexadecimal(_number).ConvertListToStringToDisplayOperations("", 1);
                            operations = MathFunctions.ConvertBinaryToHexadecimal(_number).ConvertListToStringToDisplayOperations();
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
                            operations = MathFunctions.ConvertHexadecimalToDecimal(number).ConvertListToStringToDisplayOperations();
                            result = MathFunctions.ConvertHexadecimalToDecimal(number).ConvertListToStringToDisplayOperations("", 1);
                            break;
                        case "Binary":
                            operations = MathFunctions.ConvertHexadecimalToBinary(number).ConvertListToStringToDisplayOperations();
                            result = MathFunctions.ConvertHexadecimalToBinary(number).ConvertListToStringToDisplayOperations("", 1);
                            break;
                        default:
                            result = number;
                            break;
                    }
                    break;

                default:
                    throw new ArgumentException("Base de départ non prise en charge.");
            }
            return new List<string> {result, operations};
        }


        private void conversionButton_Click(object sender, EventArgs e)
        {
            string showedTextResult = "", ShowedTextOperations = "";
            if (BaseDepart.Text == "" || baseDestination.Text == "" || numberToConvert.Text == "")
                MessageBox.Show("Vérifiez votre saisie ! ");
            else
            {
                showedTextResult = ConvertNumber(BaseDepart.Text, baseDestination.Text, numberToConvert.Text)[0];
                ShowedTextOperations = ConvertNumber(BaseDepart.Text, baseDestination.Text, numberToConvert.Text)[1];
            }

            result.Text = showedTextResult;
            operations.Text = ShowedTextOperations;
            this.AutoScroll = true;
        }

    }
}
