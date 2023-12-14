// Ignore Spelling: inserisci Corretti dati idraulico incasso medio

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            if (TXTsrch.Text == "")
            {
                LST1.Items.Clear();
                LST1.Items.Add(array);
            }
            else
            {
                LST1.Items.Clear();
                for (int i = 0; i < nv; i++) 
                { 
                    if (TXTsrch.Text.Contains(array[i].interventionType))
                    {
                        LST1.Items.Add(array[i]);
                    }
                }
                TXTavgIncome.Text = Convert.ToString(incassoMedio());
                TXTmaxIcome.Text = Convert.ToString(incassoMassimo());
            }
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

            if (nv == MAXV)
            {
                MessageBox.Show("Vettore pieno");
                return;
            }

            array[nv].day = useless.day;
            array[nv].interventionType = useless.interventionType;
            array[nv].revenue = useless.revenue;
            nv++; 
        }

        public float incassoMedio()
        {
            float totale = 0;
            float counter = 0;

            for (int i = 0; i < nv;  i++)
            {
                if (array[i].interventionType == TXTsrch.Text)
                {
                    totale += array[i].revenue;
                    counter++;
                }
            }

            if (counter == 0)
            {
                return 0;
            }
            else
            {
                return totale / counter;
            }
        }

        public float incassoMassimo()
        {
            float max = array[0].revenue;

            for (int i = 0; i < nv; i++)
            {
                if (array[i].revenue > max)
                {
                    max = array[i].revenue;
                }
            }
            return max;
        }

        private void BTopen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se apri un file ora, perderai i dati non salvati");
            string filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files | (*.txt)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            if (filePath == "") // not sure this is needed 
            {
                return;
            }

            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            StreamReader sReader = new StreamReader(file);

            // code n shit

            file.Close();
            sReader.Close();

        }

        private void BTsave_Click(object sender, EventArgs e)
        {

            string folderPath = "";
            FolderBrowserDialog dialogChooseFolder = new FolderBrowserDialog();

            if (dialogChooseFolder.ShowDialog() == DialogResult.OK)
            {
                folderPath = dialogChooseFolder.SelectedPath + "/idraulico.txt";
            }

            if (folderPath == "")
            {
                MessageBox.Show("");
                return;
            }
            else
            {
                if (File.Exists(folderPath))
                {
                    FileStream file = new FileStream(folderPath, FileMode.Truncate, FileAccess.ReadWrite, FileShare.Write);
                    StreamWriter sWriter = new StreamWriter(file);

                    for (int i = 0; i < nv; i++)
                    {
                        sWriter.Write("" + array[i].day + ",");
                        sWriter.Write("" + array[i].interventionType + ",");
                        sWriter.WriteLine("" + array[i].revenue + "");
                    }

                    sWriter.Close();
                    file.Close();
                }
                else
                {
                    FileStream file = new FileStream(folderPath, FileMode.Open, FileAccess.ReadWrite, FileShare.Write);
                    StreamWriter sWriter = new StreamWriter(file);

                    for (int i = 0; i < nv; i++)
                    {
                        sWriter.Write("" + array[i].day + ",");
                        sWriter.Write("" + array[i].interventionType + ",");
                        sWriter.WriteLine("" + array[i].revenue + "");
                    }

                    sWriter.Close();
                    file.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
