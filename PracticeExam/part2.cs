using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PracticeExam
{
    public partial class part2 : Form
    {
        public part2()
        {
            InitializeComponent();
        }

        private void validateIpBttn_Click(object sender, EventArgs e)
        {
            var ipStr=ipv4Box.Text;
            string pattern = @"^([0-9]{1,3}.){3}[0-9]{1,3}$";

            if (Regex.IsMatch(ipStr,pattern)){

                regexResult.Text = "Is correct the IP v4 number";
            }
            else
            {
                regexResult.Text = "The IP v4 isn't correct, Please try again with the format: xxx.xxx.xxx.xxx";
            }

        }

        private void passwordBttn_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            string pass = passwordBox.Text;

            if (Length(pass) && lowUpper(pass) && puntuaction(pass))
            {
                messageLabel.Text = "Valid Password!!!";
            }
            else if (!Length(pass))
            {
                System.Windows.Forms.MessageBox.Show("Password has to be between 6 and 20 characteres");
            }
            else if (!lowUpper(pass))
            {
                System.Windows.Forms.MessageBox.Show("Password has to have at least 1 lower and 1 upper character");
            }
            else if (!puntuaction(pass))
            {
                System.Windows.Forms.MessageBox.Show("Password has to have at least 1 punctuation character");
            }
        }

        public Boolean Length(string str)
        {
            bool a;

            if (str.Length > 20 && str.Length < 6)
            {
                a = false;
            }
            else
            {
                a = true;
            }

            return a;
        }

        public Boolean lowUpper(string str)
        {
            bool b=false;
            char[] charPassword = str.ToCharArray();

            for (int i = 0; i < charPassword.Length; i++) 
            {
                if (Char.IsUpper(charPassword[i]))
                {
                    for (int j = 0; j < charPassword.Length; j++)
                    {
                        if (Char.IsLower(charPassword[j]))
                        {
                            b = true;
                            break;
                        }
                    }
                }
                

            }

            return b;   
            
        }

        public Boolean puntuaction(string str)
        {
            bool c=false;
            char[] charPassword = str.ToCharArray();

            for (int j = 0; j < charPassword.Length; j++)
            {
                if (Char.IsPunctuation(charPassword[j]))
                {
                    c = true;
                    break;
                }
            }
            return c;
        }


    }
}
