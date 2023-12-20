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

namespace ProvaComuneVecchia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NUDdurationMin.Maximum = decimal.MaxValue;
        }

        public struct music
        {
            public string songTitle;
            public string artist;
            public string album;
            public int durationMinutes;
            public int durationSeconds; 
        }

        const int MAXV = 10;
        int nv = 0;
        music[] collection = new music[MAXV];

        private void BTadd_Click(object sender, EventArgs e)
        {
            if (TXTtitle.Text == "")
            {
                MessageBox.Show("Il campo testo è vuoto");
                return;
            }

            if (TXTartist.Text == "")
            {
                MessageBox.Show("Il campo artista è vuoto");
                return;
            }

            if (TXTalbum.Text == "")
            {
                MessageBox.Show("Il campo album è vuoto, in casso fosse un singolo, inserire 'singolo'");
                return;
            }

            if (NUDdurationSec.Value == 0 && NUDdurationMin.Value == 0)
            {
                MessageBox.Show("La durata non può essere 0");
                return;
            }

            collection[nv].songTitle = TXTtitle.Text;
            collection[nv].artist = TXTartist.Text;
            collection[nv].album = TXTalbum.Text;
            collection[nv].durationMinutes = (int)NUDdurationMin.Value;
            collection[nv].durationSeconds = (int)NUDdurationSec.Value;
            nv++;
        }

        private void TXTsrcByArtist_TextChanged(object sender, EventArgs e)
        {
            if (TXTsrcByTitle.Text != "")
            {
                SrcBothParam();
                return;
            }

            LSTsrcRes.Items.Clear();
            for (int i = 0; i < nv; i++)
            {
                if (collection[i].artist.Contains(TXTsrcByArtist.Text))
                {
                    LSTsrcRes.Items.Add(collection[i].songTitle + " " + collection[i].artist + " " + collection[i].album);
                }
            }

            if (LSTsrcRes.Items.Count == 0)
            {
                LSTsrcRes.Items.Add("No result with those parameters :(");
            }
        }

        private void TXTsrcByTitle_TextChanged(object sender, EventArgs e)
        {
            if (TXTsrcByArtist.Text != "")
            {
                SrcBothParam();
                return;
            }

            LSTsrcRes.Items.Clear();
            for (int i = 0; i < nv; i++)
            {
                if (collection[i].songTitle.Contains(TXTsrcByTitle.Text))
                {
                    LSTsrcRes.Items.Add(collection[i].songTitle + " " + collection[i].artist + " " + collection[i].album);
                }
            }

            if (LSTsrcRes.Items.Count == 0)
            {
                LSTsrcRes.Items.Add("No result with those parameters :(");
            }
        }

        private void SrcBothParam()
        {
            LSTsrcRes.Items.Clear();
            for (int i = 0; i < nv; i++)
            {
                if (collection[i].songTitle.Contains(TXTsrcByTitle.Text) && collection[i].artist.Contains(TXTsrcByArtist.Text))
                {
                    LSTsrcRes.Items.Add(collection[i].songTitle + " " + collection[i].artist + " " + collection[i].album);
                }
            }

            if (LSTsrcRes.Items.Count == 0)
            {
                LSTsrcRes.Items.Add("No result with those parameters :(");
            }
        }

        private void BTsave_Click(object sender, EventArgs e)
        {
            string folderPath = "";

            FolderBrowserDialog dialogChooseFolder = new FolderBrowserDialog();

            if (dialogChooseFolder.ShowDialog() == DialogResult.OK)
            {
                folderPath = dialogChooseFolder.SelectedPath + "/DeathRowRecordsBackup.txt";
            }

            if (folderPath == "")
            {
                MessageBox.Show("");
                return;
            }

            if (File.Exists(folderPath))
            {
                FileStream file = new FileStream(folderPath, FileMode.Truncate, FileAccess.ReadWrite, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(file);

                for (int i = 0; i < nv; i++)
                {
                    sWriter.Write(collection[i].songTitle + "*");
                    sWriter.Write(collection[i].artist + "*");
                    sWriter.Write(collection[i].album + "*");
                    sWriter.Write(collection[i].durationMinutes + "*");
                    sWriter.WriteLine(collection[i].durationSeconds);

                }
            }
            else
            {
                FileStream file = new FileStream(folderPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(file);

                for (int i = 0; i < nv; i++)
                {
                    sWriter.Write(collection[i].songTitle + "*");
                    sWriter.Write(collection[i].artist + "*");
                    sWriter.Write(collection[i].album + "*");
                    sWriter.Write(collection[i].durationMinutes + "*");
                    sWriter.WriteLine(collection[i].durationSeconds);

                }
            }
        }

        private void BTloadFile_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
