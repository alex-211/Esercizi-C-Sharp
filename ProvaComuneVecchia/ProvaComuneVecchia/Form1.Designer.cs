
namespace ProvaComuneVecchia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BTadd = new System.Windows.Forms.Button();
            this.TXTtitle = new System.Windows.Forms.TextBox();
            this.NUDdurationMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTartist = new System.Windows.Forms.TextBox();
            this.TXTalbum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDdurationSec = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTsrcByArtist = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTsrcByTitle = new System.Windows.Forms.TextBox();
            this.LSTsrcRes = new System.Windows.Forms.ListBox();
            this.LBLtotalDuration = new System.Windows.Forms.Label();
            this.BTsave = new System.Windows.Forms.Button();
            this.BTloadFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdurationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdurationSec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song title:";
            // 
            // BTadd
            // 
            this.BTadd.Location = new System.Drawing.Point(15, 135);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(199, 23);
            this.BTadd.TabIndex = 1;
            this.BTadd.Text = "Add";
            this.BTadd.UseVisualStyleBackColor = true;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // TXTtitle
            // 
            this.TXTtitle.Location = new System.Drawing.Point(72, 6);
            this.TXTtitle.Name = "TXTtitle";
            this.TXTtitle.Size = new System.Drawing.Size(142, 20);
            this.TXTtitle.TabIndex = 2;
            // 
            // NUDdurationMin
            // 
            this.NUDdurationMin.Location = new System.Drawing.Point(98, 97);
            this.NUDdurationMin.Name = "NUDdurationMin";
            this.NUDdurationMin.Size = new System.Drawing.Size(36, 20);
            this.NUDdurationMin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lenght";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Album:";
            // 
            // TXTartist
            // 
            this.TXTartist.Location = new System.Drawing.Point(72, 34);
            this.TXTartist.Name = "TXTartist";
            this.TXTartist.Size = new System.Drawing.Size(142, 20);
            this.TXTartist.TabIndex = 7;
            // 
            // TXTalbum
            // 
            this.TXTalbum.Location = new System.Drawing.Point(72, 63);
            this.TXTalbum.Name = "TXTalbum";
            this.TXTalbum.Size = new System.Drawing.Size(142, 20);
            this.TXTalbum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "sec";
            // 
            // NUDdurationSec
            // 
            this.NUDdurationSec.Location = new System.Drawing.Point(178, 97);
            this.NUDdurationSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUDdurationSec.Name = "NUDdurationSec";
            this.NUDdurationSec.Size = new System.Drawing.Size(36, 20);
            this.NUDdurationSec.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search by:";
            // 
            // TXTsrcByArtist
            // 
            this.TXTsrcByArtist.Location = new System.Drawing.Point(310, 31);
            this.TXTsrcByArtist.Name = "TXTsrcByArtist";
            this.TXTsrcByArtist.Size = new System.Drawing.Size(210, 20);
            this.TXTsrcByArtist.TabIndex = 13;
            this.TXTsrcByArtist.TextChanged += new System.EventHandler(this.TXTsrcByArtist_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Artist";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Song title:";
            // 
            // TXTsrcByTitle
            // 
            this.TXTsrcByTitle.Location = new System.Drawing.Point(599, 31);
            this.TXTsrcByTitle.Name = "TXTsrcByTitle";
            this.TXTsrcByTitle.Size = new System.Drawing.Size(189, 20);
            this.TXTsrcByTitle.TabIndex = 16;
            this.TXTsrcByTitle.TextChanged += new System.EventHandler(this.TXTsrcByTitle_TextChanged);
            // 
            // LSTsrcRes
            // 
            this.LSTsrcRes.FormattingEnabled = true;
            this.LSTsrcRes.Items.AddRange(new object[] {
            "Search results appear here..."});
            this.LSTsrcRes.Location = new System.Drawing.Point(277, 63);
            this.LSTsrcRes.Name = "LSTsrcRes";
            this.LSTsrcRes.Size = new System.Drawing.Size(511, 95);
            this.LSTsrcRes.TabIndex = 17;
            // 
            // LBLtotalDuration
            // 
            this.LBLtotalDuration.AutoSize = true;
            this.LBLtotalDuration.Location = new System.Drawing.Point(12, 175);
            this.LBLtotalDuration.Name = "LBLtotalDuration";
            this.LBLtotalDuration.Size = new System.Drawing.Size(129, 13);
            this.LBLtotalDuration.TabIndex = 19;
            this.LBLtotalDuration.Text = "Total songs duration: N/A";
            // 
            // BTsave
            // 
            this.BTsave.Location = new System.Drawing.Point(12, 191);
            this.BTsave.Name = "BTsave";
            this.BTsave.Size = new System.Drawing.Size(420, 23);
            this.BTsave.TabIndex = 20;
            this.BTsave.Text = "Save";
            this.BTsave.UseVisualStyleBackColor = true;
            this.BTsave.Click += new System.EventHandler(this.BTsave_Click);
            // 
            // BTloadFile
            // 
            this.BTloadFile.Location = new System.Drawing.Point(438, 191);
            this.BTloadFile.Name = "BTloadFile";
            this.BTloadFile.Size = new System.Drawing.Size(360, 23);
            this.BTloadFile.TabIndex = 21;
            this.BTloadFile.Text = "Load file";
            this.BTloadFile.UseVisualStyleBackColor = true;
            this.BTloadFile.Click += new System.EventHandler(this.BTloadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 223);
            this.Controls.Add(this.BTloadFile);
            this.Controls.Add(this.BTsave);
            this.Controls.Add(this.LBLtotalDuration);
            this.Controls.Add(this.LSTsrcRes);
            this.Controls.Add(this.TXTsrcByTitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTsrcByArtist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NUDdurationSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTalbum);
            this.Controls.Add(this.TXTartist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDdurationMin);
            this.Controls.Add(this.TXTtitle);
            this.Controls.Add(this.BTadd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NUDdurationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdurationSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTadd;
        private System.Windows.Forms.TextBox TXTtitle;
        private System.Windows.Forms.NumericUpDown NUDdurationMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTartist;
        private System.Windows.Forms.TextBox TXTalbum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDdurationSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTsrcByArtist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTsrcByTitle;
        private System.Windows.Forms.ListBox LSTsrcRes;
        private System.Windows.Forms.Label LBLtotalDuration;
        private System.Windows.Forms.Button BTsave;
        private System.Windows.Forms.Button BTloadFile;
    }
}

