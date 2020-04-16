//B8030
//Cis 199
//Program 2
// Prof. Andrew
// due 10/18/2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            char letter;// seting letter variable
            string userInput = InputLNameInitial.Text;// putting input for user to put
            letter = userInput[0];// selects the first letter of the lastname entered.
            

            char.IsLetter(letter);//letting the program know its a letter

            {
                letter = char.ToUpper(letter);// with this program accept any letter, wheater upper case or lower case


                if (RseniorButton.Checked)// if statment excecute when senior is checked
                { 
                    if (letter <= 'D')//logic if the condition then run the messgage box.
                        MessageBox.Show("Rigester opens on: 4:00 PM, FRIDAY NOV. 2");// output if the condition is meet
                    else if (letter <= 'I')//logic if the condition then run the messgage box.
                        MessageBox.Show("Rigester opens on: 8:30 AM, FRIDAY NOV. 2");// output if the condition is meet
                    else if (letter <= 'O')//logic if the condition then run the messgage box.
                        MessageBox.Show("Rigester opens on: 10:00 AM, FRIDAY NOV. 2");// output if the condition is meet
                    else if (letter <= 'S')//logic if the condition then run the messgage box.
                        MessageBox.Show("Rigester opens on: 11:30 AM, FRIDAY NOV. 2");// output if the condition is meet
                    else
                        MessageBox.Show("Rigester opens on: 2:00 PM FRIDAY NOV. 2");// output if the condition is meet
                }

            if (Rjuniorbutton.Checked)//if statement that exceute when junior is checked
            {// if statement if then conditon is meet then it display the result underneath other wise it exceute the else if conditoin until it find the ture condtion.
                if (letter <= 'D')
                    MessageBox.Show("Rigester opens on: 4:00, MONDAY, NOV. 5");
                else if (letter <= 'I')
                    MessageBox.Show("Rigester opens on: 8:30, MONDAY, NOV. 5");
                else if (letter <= 'O')
                    MessageBox.Show("Rigester opens on: 10:00, MONDAY, NOV. 5");
                else if (letter <= 'S')
                    MessageBox.Show("Rigester opens on: 11:30, MONDAY, NOV. 5");
                else
                    MessageBox.Show("Rigester opens on: 2:00, MONDAY, NOV. 5");
            }
        

                if (RsophomoreButton.Checked)// if statement that excecute when Sophomore is checked in the radio button.
                {// if statement if then conditon is meet then it display the result underneath other wise it exceute the else if conditoin until it find the ture condtion.
                    if (letter <= 'B')
                        MessageBox.Show("Rigester opens on: 2:00, WEDNESDAY, NOV. 7");
                    else if (letter <= 'D')
                        MessageBox.Show("Rigester opens on: 4:00, WEDNESDAY, NOV. 7");
                    else if (letter <= 'F')
                        MessageBox.Show("Rigester opens on: 8:30, TUESDAY, NOV. 6");
                    else if (letter <= 'I')
                        MessageBox.Show("Rigester opens on: 10:00, TUESDAY, NOV. 6");
                    else if (letter <= 'L')
                        MessageBox.Show("Rigester opens on: 11:30, TUESDAY, NOV. 6");
                    else if (letter <= 'O')
                        MessageBox.Show("Rigester opens on: 2:00, TUESDAY, NOV. 6");
                    else if (letter <= 'Q')
                        MessageBox.Show("Rigester opens on: 4:00, TUESDAY, NOV. 6");
                    else if (letter <= 'S')
                        MessageBox.Show("v 8:30, WEDNESDAY, NOV. 7");
                    else if (letter<= 'V')
                        MessageBox.Show("Rigester opens on: 10:00, WEDNESDAY, NOV. 7");
                    else MessageBox.Show("Rigester opens on: 11:30, WEDNESDAY, NOV. 7");


                }
                if (RfreshmanButton.Checked)// if statement that excecute when Sophomore is checked in the radio button.
                {// if statement if then conditon is meet then it display the result underneath other wise it exceute the else if conditoin until it find the ture condtion.
                    if (letter <= 'B')
                        MessageBox.Show("Rigester opens on: 2:00, FRIDAY, NOV. 9");
                    else if (letter <= 'D')
                        MessageBox.Show("Rigester opens on: 4:00, FRIDAY, NOV. 9");
                    else if (letter <= 'F')
                        MessageBox.Show("Rigester opens on: 8:30, THURSDAY, NOV. 8");
                    else if (letter <= 'I')
                        MessageBox.Show("Rigester opens on: 10:00, THURSDAY, NOV. 8");
                    else if (letter <= 'L')
                        MessageBox.Show("Rigester opens on: 11:30, THURSDAY, NOV. 8");
                    else if (letter <= 'O')
                        MessageBox.Show("Rigester opens on: 2:00, THURSDAY, NOV. 8");
                    else if (letter <= 'Q')
                        MessageBox.Show("Rigester opens on: 4:00, THURSDAY, NOV. 8");
                    else if (letter <= 'S')
                        MessageBox.Show("Rigester opens on: 8:30, FRIDAY, NOV. 9");
                    else if (letter <= 'V')
                        MessageBox.Show("Rigester opens on: 10:00,FRIDAY, NOV. 9");
                    else MessageBox.Show("Rigester opens on: 11:30, FRIDAY, NOV. 9");

                }









                }
                
            }
    }
}
