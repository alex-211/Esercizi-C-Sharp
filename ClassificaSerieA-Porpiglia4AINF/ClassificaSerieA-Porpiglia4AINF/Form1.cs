// Ignore Spelling: punteggio retiFatte retiSubite MAXV squadre squadra trova

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificaSerieA_Porpiglia4AINF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct squadra
        {
            public string nome;
            public int punteggio;
            public int retiFatte;
            public int retiSubite;
        }

        public const int MAXV = 10;
        public int nv = 0;
        public squadra[] arraySquadre = new squadra[MAXV];

        private void BTaggSquadra_Click(object sender, EventArgs e)
        {
            if (nv == MAXV)
            {
                MessageBox.Show("Array pieno");
                return;
            }

            /*for (int i = 0; i < nv; i++)
            {
                if (TXTaggSquadra.Text == arraySquadre[i].nome)
                {
                    MessageBox.Show("Squadra " + TXTaggSquadra.Text + " già inserita");
                    return;
                }
            }*/

            if (trovaSquadra(TXTaggSquadra.Text) == -1)
            {
                MessageBox.Show("Squadra " + TXTaggSquadra.Text + " già inserita");
                return;
            }


            arraySquadre[nv].nome = TXTaggSquadra.Text;
            CBaddPunteggio.Items.Add(arraySquadre[nv].nome);
            CBaddReti.Items.Add(arraySquadre[nv].nome);
            refreshLST();
            nv++;
        }

        private void BTaddVittoria_Click(object sender, EventArgs e)
        {
            arraySquadre[trovaSquadra(CBaddPunteggio.Text)].punteggio += 3;
            refreshLST();
        }

        private void BTaddPareggio_Click(object sender, EventArgs e)
        {
            arraySquadre[trovaSquadra(CBaddPunteggio.Text)].punteggio += 1;
            refreshLST();
        }

        private void BTaddReti_Click(object sender, EventArgs e)
        {
            arraySquadre[trovaSquadra(CBaddReti.Text)].retiFatte += (int)NUDretiFatte.Value;
            arraySquadre[trovaSquadra(CBaddReti.Text)].retiSubite += (int)NUDretiSubite.Value;
            refreshLST();
        }

        public void refreshLST() // fa il refresh della LSTclassifica quando viene chiamata (viene chiamata ogni volta che c'è una modifica alle squadre o un'aggiunta)
        {
            // non ho capito la consegna, da rivedere
            LSTclassifica.Items.Clear();
            LSTclassifica.Items.Add("Nome squadra, " + "punti, " + "reti subite, " + "reti fatte");

            for (int i = 0; i < nv; i++)
            {
                LSTclassifica.Items.Add(arraySquadre[i].nome + " " + arraySquadre[i].punteggio + " " + arraySquadre[i].retiSubite + " " + arraySquadre[i].retiFatte);
            }
        }

        public int trovaSquadra(string nome) // restituisce la posizione nel vettore della squadra usando il parametro nome, se non è presente, restituisce -1
        {
            for (int i = 0; i < nv; i++)
            {
                if (nome == arraySquadre[i].nome)
                {
                    return i;
                }
            }

            return -1;
            
        }
    }
}
