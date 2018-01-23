using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeConverter
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string method that accepts argument character M
        private string morseConverter(char M)
        {
            //initialize variable char input equal to Parsed char of M.ToString()
            char input   = char.Parse(M.ToString());
            switch (input)
            {
                //switch cases for each character available
                //A-Z is a 4 digit code, Add space at end of code to seperate character
                //?, Comma, and period are 6 morse digit add space to end
                //in the case of a space return two spaces to seperate words
                case ' ':
                    return "  ";
                case 'A':
                    return ".-   ";
                case 'B':
                    return "-... ";
                case 'C':
                    return "-.-. ";
                case 'D':
                    return "-..  ";
                case 'E':
                    return ".    ";
                case 'F':
                    return "..-. ";
                case 'G':
                    return "--.  ";
                case 'H':
                    return ".... ";
                case 'I':
                    return "..   ";
                case 'J':
                    return ".--- ";
                case 'K':
                    return "-.-  ";
                case 'L':
                    return ".-.. ";
                case 'M':
                    return "--  "; //the book appears to state this is "--- ", even though other resources online state its just "--  "
                case 'N':
                    return "-.   ";
                case 'O':
                    return "---  ";
                case 'P':
                    return ".--. ";
                case 'Q':
                    return "--.- ";
                case 'R':
                    return ".-.  ";
                case 'S':
                    return "...  ";
                case 'T':
                    return "-    ";
                case 'U':
                    return "..-  ";
                case 'V':
                    return "...- ";
                case 'W':
                    return ".--  ";
                case 'X':
                    return "-..- ";
                case 'Y':
                    return "-.-- ";
                case 'Z':
                    return "--.. ";             
                case '0':
                    return "----- ";
                case '1':
                    return ".---- ";
                case '2':
                    return "..--- ";
                case '3':
                    return "...-- ";
                case '4':
                    return "....- ";
                case '5':
                    return "..... ";
                case '6':
                    return "-.... ";
                case '7':
                    return "--... ";
                case '8':
                    return "---.. ";
                case '9':
                    return "----. ";
                case ',':
                    return "--..-- ";
                case '.':
                    return ".-.-.- ";
                case '?':
                    return "..--.. ";
                case '!': //Morse code table in book doesnt list !, used online resource to find this.
                    return "-.-.-- ";
                default:
                    return "";
            }
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //string inputText is equal to textbox text value passed ToUpper method to make all characters Capital
            string inputText = (inputTextBox.Text).ToUpper(); 
            morseTextBox.Clear(); //When convert button clicked morseTextbox is cleared to accept conversion

            //foreach loop for each character in inputText
            foreach (char letter in inputText)
            {
                //add morseConverter method with argument for letter in inputText                
                morseTextBox.Text += morseConverter(letter);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear both text boxes
            morseTextBox.Clear();
            inputTextBox.Clear();
        }
    }
}
