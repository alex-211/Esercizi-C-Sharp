// Ignore Spelling: inserisci Corretti dati

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idraulico
{
    public partial class Form1 : Form
    {
        public struct interventions
        {
            public int day;
            public float revenue;
            public string interventionType;
        }

        const int MAXV = 10;
        int nv = 0;
        interventions[] array = new interventions[MAXV];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTadd_Click(object sender, EventArgs e)
        {
            leggiDati();
        }

        private void TXTsrch_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool datiCorretti()
        {
            if (TXTrevenue.Text == "")
            {
                MessageBox.Show("L'incasso non è stato compilato");
                return false;
            }

            if (TXTservice.Text == "")
            {
                MessageBox.Show("Il tipo di servizio non è stato compilato");
                return false;
            }

            if (!(float.TryParse(TXTrevenue.Text, out float no)))
            {
                MessageBox.Show("L'incasso deve essere un numero");
                return false;
            }

            return true;
        }

        private void leggiDati()
        {
            if (datiCorretti() == false)
            {
                return;
            }

            interventions useless;
            useless.day = (int)NUDday.Value;
            useless.revenue = Convert.ToSingle(TXTrevenue.Text);
            useless.interventionType = TXTservice.Text;

            inserisci(useless);

        }

        public void inserisci(interventions useless)
        {
            leggiDati();

            if (nv == MAXV)
            {
                MessageBox.Show("Vettore pieno");
                return;
            }

            array[nv].day = useless.day;
            array[nv].interventionType = useless.interventionType;
            array[nv].revenue = useless.revenue;
        }
    }
}
