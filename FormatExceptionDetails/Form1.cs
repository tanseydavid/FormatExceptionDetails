using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatExceptionDetails
{
	// TEST COMMENT
    public partial class Form1 : Form
    {

        public string splitter = Environment.NewLine + "---------------------------------------------------------------------" + Environment.NewLine ;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            txtOutput.Text = FormatExceptionDetails(txtInput.Text);
        }

        private string FormatExceptionDetails(string text)
        {
            var formattedText = text.Replace(@"\r\n", Environment.NewLine);
            // var formattedText = text;
            formattedText = formattedText.Replace(" at ", Environment.NewLine + "\t at ");
            formattedText = formattedText.Replace(" in ", Environment.NewLine + "\t\t in ");
            formattedText = formattedText.Replace("\"InnerException\"", splitter + "\"InnerException\"");
            formattedText = formattedText.Replace("\"Message\"", Environment.NewLine + "\"Message\"");
            formattedText = formattedText.Replace("\"ExceptionMessage\"", Environment.NewLine + "\"ExceptionMessage\"");
            formattedText = formattedText.Replace("\"ExceptionType\"", Environment.NewLine + "\"ExceptionType\"");
            formattedText = formattedText.Replace("\"StackTrace\"", Environment.NewLine + "\"StackTrace\"");
            formattedText = formattedText.Replace("--- End", Environment.NewLine + "\t ---End");
            formattedText = formattedText.Replace("thrown ---\\r\\n", "thrown --" + Environment.NewLine);
            
            return formattedText;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
