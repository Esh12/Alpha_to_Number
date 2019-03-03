using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbertoAlpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userinput_TextChanged(object sender, EventArgs e)
        {
            this.Text = userinput.Text;
        }

        public void ConvertStringBreak_Click(object sender, EventArgs e)
        {
            
              //  string userValue;
                if (userinput.Text == "")
                {
                MessageBox.Show("Enter Something");
            }
                else
                {
                string breakup = "";

                foreach (char number in userinput.Text)
                {
                    int index = char.ToUpper(number) - 64;
                    breakup += $"{number} is {index}\n";
                    


                }
                Number.Text = breakup;

                int total = 0;

                foreach (char number in userinput.Text)
                {
                    int index = char.ToUpper(number) - 64;
                    total += index;
                    
                  
                }
                string myString = total.ToString();
                Show.Text = $"The total is {myString}";


            }
            
        }
        

        private void Show_Click(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {

        }
    }
}
