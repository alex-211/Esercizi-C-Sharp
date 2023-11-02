using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_ConFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Hide();
        }

        public struct voti
        {
            int italiano;
            int storia;
            int inglese;
            int matematica;
            int informatica;
            int s_r;
            int tpsit;
            int telecomunicazioni;
        }

        public voti voto;
        public bool sistemaSelezionato = false;

        private void BTadd_Click(object sender, EventArgs e)
        {
            if (sistemaSelezionato == false)
            {
                MessageBox.Show("Selezionare il sistema di valutazione");
                return;
            }
        }

        private void CBsistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            sistemaSelezionato = true;

            if ((string)CBsistema.SelectedItem == "Lettere")
            {
                CBvoto.Items.Add("A+");
                CBvoto.Items.Add("A");
                CBvoto.Items.Add("A-");
                CBvoto.Items.Add("B+");
                CBvoto.Items.Add("B");
                CBvoto.Items.Add("B-");
                CBvoto.Items.Add("C+");
                CBvoto.Items.Add("C");
                CBvoto.Items.Add("C-");
                CBvoto.Items.Add("D");
                CBvoto.Items.Add("D-");
                CBvoto.Items.Add("F");
            }
            else if ((string)CBsistema.SelectedItem == "Numeri 0-100")
            {
                for (int i = 0; i <= 100; i++)
                {
                    CBvoto.Items.Add(Convert.ToString(i));
                }
            }
            else if ((string)CBsistema.SelectedItem == "Numeri 0-10")
            {
                for (int i = 0; i <= 10; i++)
                {
                    CBvoto.Items.Add(Convert.ToString(i));
                }
            }

            label2.Hide();
            CBsistema.Hide();
            label5.Show();
        }
    }
}
