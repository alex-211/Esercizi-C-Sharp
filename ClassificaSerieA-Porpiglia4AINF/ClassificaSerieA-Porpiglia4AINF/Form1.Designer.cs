namespace ClassificaSerieA_Porpiglia4AINF
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
            this.label2 = new System.Windows.Forms.Label();
            this.TXTaggSquadra = new System.Windows.Forms.TextBox();
            this.BTaggSquadra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBaddPunteggio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTaddVittoria = new System.Windows.Forms.Button();
            this.BTaddPareggio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBaddReti = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NUDretiFatte = new System.Windows.Forms.NumericUpDown();
            this.NUDretiSubite = new System.Windows.Forms.NumericUpDown();
            this.BTaddReti = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LSTclassifica = new System.Windows.Forms.ListBox();
            this.LBLdiffReti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDretiFatte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDretiSubite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aggiungi squadre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // TXTaggSquadra
            // 
            this.TXTaggSquadra.Location = new System.Drawing.Point(65, 43);
            this.TXTaggSquadra.Name = "TXTaggSquadra";
            this.TXTaggSquadra.Size = new System.Drawing.Size(128, 22);
            this.TXTaggSquadra.TabIndex = 2;
            // 
            // BTaggSquadra
            // 
            this.BTaggSquadra.Location = new System.Drawing.Point(199, 40);
            this.BTaggSquadra.Name = "BTaggSquadra";
            this.BTaggSquadra.Size = new System.Drawing.Size(75, 28);
            this.BTaggSquadra.TabIndex = 3;
            this.BTaggSquadra.Text = "Aggiungi";
            this.BTaggSquadra.UseVisualStyleBackColor = true;
            this.BTaggSquadra.Click += new System.EventHandler(this.BTaggSquadra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cambia punteggio";
            // 
            // CBaddPunteggio
            // 
            this.CBaddPunteggio.FormattingEnabled = true;
            this.CBaddPunteggio.Location = new System.Drawing.Point(116, 120);
            this.CBaddPunteggio.Name = "CBaddPunteggio";
            this.CBaddPunteggio.Size = new System.Drawing.Size(143, 24);
            this.CBaddPunteggio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scegli squadra";
            // 
            // BTaddVittoria
            // 
            this.BTaddVittoria.Location = new System.Drawing.Point(266, 120);
            this.BTaddVittoria.Name = "BTaddVittoria";
            this.BTaddVittoria.Size = new System.Drawing.Size(75, 23);
            this.BTaddVittoria.TabIndex = 7;
            this.BTaddVittoria.Text = "Vittoria";
            this.BTaddVittoria.UseVisualStyleBackColor = true;
            this.BTaddVittoria.Click += new System.EventHandler(this.BTaddVittoria_Click);
            // 
            // BTaddPareggio
            // 
            this.BTaddPareggio.Location = new System.Drawing.Point(347, 120);
            this.BTaddPareggio.Name = "BTaddPareggio";
            this.BTaddPareggio.Size = new System.Drawing.Size(75, 23);
            this.BTaddPareggio.TabIndex = 8;
            this.BTaddPareggio.Text = "Pareggio";
            this.BTaddPareggio.UseVisualStyleBackColor = true;
            this.BTaddPareggio.Click += new System.EventHandler(this.BTaddPareggio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aggiungi reti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Scegli squadra";
            // 
            // CBaddReti
            // 
            this.CBaddReti.FormattingEnabled = true;
            this.CBaddReti.Location = new System.Drawing.Point(116, 199);
            this.CBaddReti.Name = "CBaddReti";
            this.CBaddReti.Size = new System.Drawing.Size(143, 24);
            this.CBaddReti.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reti fatte:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Reti subite:";
            // 
            // NUDretiFatte
            // 
            this.NUDretiFatte.Location = new System.Drawing.Point(333, 201);
            this.NUDretiFatte.Name = "NUDretiFatte";
            this.NUDretiFatte.Size = new System.Drawing.Size(120, 22);
            this.NUDretiFatte.TabIndex = 14;
            // 
            // NUDretiSubite
            // 
            this.NUDretiSubite.Location = new System.Drawing.Point(551, 202);
            this.NUDretiSubite.Name = "NUDretiSubite";
            this.NUDretiSubite.Size = new System.Drawing.Size(120, 22);
            this.NUDretiSubite.TabIndex = 15;
            // 
            // BTaddReti
            // 
            this.BTaddReti.Location = new System.Drawing.Point(690, 203);
            this.BTaddReti.Name = "BTaddReti";
            this.BTaddReti.Size = new System.Drawing.Size(75, 23);
            this.BTaddReti.TabIndex = 16;
            this.BTaddReti.Text = "Invio";
            this.BTaddReti.UseVisualStyleBackColor = true;
            this.BTaddReti.Click += new System.EventHandler(this.BTaddReti_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Classifica squadre";
            // 
            // LSTclassifica
            // 
            this.LSTclassifica.FormattingEnabled = true;
            this.LSTclassifica.ItemHeight = 16;
            this.LSTclassifica.Items.AddRange(new object[] {
            "Le squadre appariranno qui in ordine di punteggio..."});
            this.LSTclassifica.Location = new System.Drawing.Point(15, 272);
            this.LSTclassifica.Name = "LSTclassifica";
            this.LSTclassifica.Size = new System.Drawing.Size(656, 84);
            this.LSTclassifica.TabIndex = 18;
            // 
            // LBLdiffReti
            // 
            this.LBLdiffReti.AutoSize = true;
            this.LBLdiffReti.Location = new System.Drawing.Point(15, 372);
            this.LBLdiffReti.Name = "LBLdiffReti";
            this.LBLdiffReti.Size = new System.Drawing.Size(287, 16);
            this.LBLdiffReti.TabIndex = 19;
            this.LBLdiffReti.Text = "La squadra con migliore differenza di reti è: N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.LBLdiffReti);
            this.Controls.Add(this.LSTclassifica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BTaddReti);
            this.Controls.Add(this.NUDretiSubite);
            this.Controls.Add(this.NUDretiFatte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBaddReti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTaddPareggio);
            this.Controls.Add(this.BTaddVittoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBaddPunteggio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTaggSquadra);
            this.Controls.Add(this.TXTaggSquadra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUDretiFatte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDretiSubite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTaggSquadra;
        private System.Windows.Forms.Button BTaggSquadra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBaddPunteggio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTaddVittoria;
        private System.Windows.Forms.Button BTaddPareggio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBaddReti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUDretiFatte;
        private System.Windows.Forms.NumericUpDown NUDretiSubite;
        private System.Windows.Forms.Button BTaddReti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox LSTclassifica;
        private System.Windows.Forms.Label LBLdiffReti;
    }
}

