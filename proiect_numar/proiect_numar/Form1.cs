using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_numar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            //MessageBox.Show("S-a introdus:" + numberTextBox.Text);
            bool isNumber = Int32.TryParse (numberTextBox.Text, out int result);
            if(isNumber==true)
            {
                bool isPrime = true;
                for(int i=2 ; i<=result/2 ; i++)
                {
                    if (result % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if(isPrime==true)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }

            }
            else
            {
                this.BackColor=Color.Yellow;
                MessageBox.Show("S-a introdus un text");
                numberTextBox.Text = String.Empty;
            }
        }
    }
}
