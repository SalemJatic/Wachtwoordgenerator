using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wachtwoord_generator.Properties;
namespace Wachtwoord_generator
{
    public partial class Form1 : Form
    {
        
        private string _Hoofdletter;
        private string _Kleinenletter;
        private string _cijfer;
        private string _symbolen;
        private Event Event;



        public Form1()
        {
            InitializeComponent();
            Event = new Event();
            Event.Event1 += ShowMessageEvent;
        }


        private void ShowMessageEvent(object source, EventArgs args)
        {
            MessageBox.Show("Weet u zeker of u het programma wilt sluiten?");
        }

        private void Genereer_button_Click(object sender, EventArgs e)
        {
           

            if (!Hoofdletter_checkbox.Checked && !Kleinenletters_checkbox.Checked && !Cijfer_checkbox.Checked && !Symbolen_checkbox.Checked)
            {
                MessageBox.Show("Selecteer een van de vier checkboxen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
 
                Textbox1.Text = Genereer.GetRandomWachtwoord(Convert.ToInt32(WachtwoordLengthList.Value), GetStringTemplate());
            }




            //slaat de text vanm de textbox op in listbox.
            //de uitkomst van textbox 2 wordt opgeslagen in de listbox

            if (this.Textbox1.Text != "")
            {
                listbox1.Items.Add(this.Textbox1.Text);
                this.Textbox1.Focus();
                
            }
            else
            {
                MessageBox.Show("Toets iets in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.WachtwoordLengthList.Focus();
            }
        }

        private string GetStringTemplate()
        {
            StringBuilder template = new StringBuilder();
            if (Hoofdletter_checkbox.Checked)
                template.Append(_Hoofdletter);
            if (Kleinenletters_checkbox.Checked)
                template.Append(_Kleinenletter);
            if (Cijfer_checkbox.Checked)
                template.Append(_cijfer);
            if (Symbolen_checkbox.Checked)
                template.Append(_symbolen);
            return template.ToString();

        }

        public string sett { get; set; }
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            _Hoofdletter = Settings.Default.Letters.ToUpper();
            _Kleinenletter = Settings.Default.Letters.ToLower();
            _cijfer = Settings.Default.Cijfers;
            _symbolen = Settings.Default.Symbolen;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_close(object sender, FormClosingEventArgs e)
        {
            Event.StartEvent();
        }
    }
}
