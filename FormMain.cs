using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wachtwoordgenerator
{
    public partial class FormMain : Form
    {
        

        public FormMain()
        {
            InitializeComponent();
        }

       
        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //wachtwoord genereren

            


            string randomstring = string.Empty;
            char[] array = "qwertyuiopasdfghjklzxcvbnm1234567890[];.,?!@#$%^&*()".ToCharArray();
            Random rand = new Random();
            int getnumber = Convert.ToInt32(textbox1.Text);
            for (int i=0;i<getnumber;i++)
            {
                int point = rand.Next(1, array.Length);
                if (!randomstring.Contains(array.GetValue(point).ToString()))
                randomstring += array.GetValue(point);
                else
                    i--;

            }

            
            

            textbox2.Text = randomstring;

            //slaat de text vanm de textbox op in listbox.
            //de uitkomst van textbox 1 wordt opgeslagen in de listbox

            if (this.textbox1.Text != "")
            {
                listBox1.Items.Add(this.textbox2.Text);
                this.textbox2.Focus();
                
            }
            else
            {
                MessageBox.Show("Toets iets in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textbox1.Focus();
            }

            











        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
